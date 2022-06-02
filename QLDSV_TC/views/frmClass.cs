using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class frmClass : DevExpress.XtraEditors.XtraForm
    {
        private int vitri;
        private int positionSV = -1;
        private String flagmodeClass = "";
        private String flagmodeSV = "";
        private String catcheTenLOP = "";  // giữ lại tên lớp lúc ấn edit
        public frmClass()
        {
            InitializeComponent();
        }


        private void frmClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.

            qLDSV_TCDataSet.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);
           

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            //    cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }
            if (bdsLOP.Count > 0)
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = true;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();

            if (cbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.pass = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.pass = Program.passDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);


            }
        }
        private void gridViewLop_RowCountChanged(object sender, EventArgs e)
        {
            if (bdsLOP.Count > 0 && !flagmodeClass.Equals("ADDCLASS"))
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = true;
            else
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = false;

        }
        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

            bdsLOP.AddNew();
            try
            {
                DataTable dt = Program.ExecSqlDataTable("EXEC SP_GetMaKhoa");
                String makhoa = dt.Rows[0][0].ToString();
                txtKhoa.Text = makhoa;
            }
            catch

            {
                bdsLOP.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }

            vitri = bdsLOP.Position;
            panelNhapLieu.Enabled = true;
            cbKhoa.Enabled = false;

            flagmodeClass = "ADDCLASS";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            lOPGridControl.Enabled = panelFormSV.Enabled = false;
            txtMALOP.Enabled = true;
           

        }

        private bool checkClass()
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return false;
            }
            if (flagmodeClass.Equals("ADDCLASS"))
            {
                string query = " DECLARE @return_value INT " +

                               " EXEC @return_value = [dbo].[SP_CHECKID] " +

                               " @ID = N'" + txtMALOP.Text.Trim() + "',  " +

                               " @Type = N'MALOP' " +

                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Lớp đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (flagmodeClass == "ADDCLASS" || (flagmodeClass == "EDITCLASS") && catcheTenLOP != txtTenLop.Text.Trim())
            {
                string query2 = " DECLARE @return_value INT " +

                              " EXEC @return_value = [dbo].[SP_CHECKNAME] " +

                              " @Name = N'" + txtTenLop.Text.Trim() + "',  " +

                              " @Type = N'TENLOP' " +

                              " SELECT  'Return Value' = @return_value ";

                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (result2 == 1)
                {
                    XtraMessageBox.Show("Tên Lớp đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (result2 == 2)
                {
                    XtraMessageBox.Show("Tên Lớp đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
           

            return true;
        }
        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (checkClass())
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    flagmodeClass ="!"+ flagmodeClass;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);


                }
                catch (Exception ex)
                {
                    flagmodeClass = flagmodeClass.Substring(1);
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                lOPGridControl.Enabled = panelFormSV.Enabled = true;
                btnThem.Enabled = true;
                btnGhi.Enabled = btnPH.Enabled = false;
                panelNhapLieu.Enabled = false;
                cbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = true;
                catcheTenLOP = "";
            }

        }
        private void barLargeButtonSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            panelNhapLieu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            cbKhoa.Enabled = false;
            txtMALOP.Enabled = false;
            flagmodeClass = "EDITCLASS";
            catcheTenLOP = txtTenLop.Text.Trim();

            lOPGridControl.Enabled = panelFormSV.Enabled = false;
            txtMALOP.Enabled = true;

        }



        private void btnPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            flagmodeClass = "";
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            lOPGridControl.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            cbKhoa.Enabled = true;
            catcheTenLOP="";
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            String malop = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp học?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }

        }


        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    this.Close();
            }
            else
                this.Close();
        }

        private void btnADDSV_Click(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.passDefaultSV;
            bdsSV.AddNew();
            positionSV = bdsSV.Count - 1;

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
            cbKhoa.Enabled = lOPGridControl.Enabled = false;
            btnUndoSV.Enabled = btnSaveSV.Enabled = true;
            flagmodeSV = "ADDSV";
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
           
            if (bdsSV.Position != positionSV || gridView2.FocusedColumn.FieldName == "MALOP"
                || (gridView2.FocusedColumn.FieldName == "DANGHIHOC" && flagmodeSV.Equals("ADDSV"))
                || (gridView2.FocusedColumn.FieldName == "MASV" && flagmodeSV.Equals("EDITSV"))
                )
                e.Cancel = true;
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

            if (gridView2.FocusedColumn.FieldName == "MASV")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên bạn nhập không đúng định dạng \n Ví dụ: N19DCCN001";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

        }


        private bool checkSV()
        {
            DataRowView dt = (DataRowView)bdsSV[positionSV];
            if (dt["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }
            if (dt["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);

                return false;
            }
            if (dt["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                return false;
            }

            if (dt["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "", MessageBoxButtons.OK);
                return false;
            }

            if (flagmodeSV.Equals("ADDSV"))
            {
                string query = " DECLARE @return_value INT " +

                               " EXEC @return_value = [dbo].[SP_CHECKID] " +

                               " @ID = N'" + dt["MASV"].ToString().Trim() + "',  " +

                               " @Type = N'MASV' " +

                               " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    XtraMessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "", MessageBoxButtons.OK);
                    return false;
                }
                if (resultMa == 1)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    XtraMessageBox.Show("Mã Sinh Viên đã tồn tại ở Khoa khác. Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void bntSaveSV_Click(object sender, EventArgs e)
        {
            if (checkSV() == true)
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    flagmodeSV = "";
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    flagmodeSV = "ADDSV";
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                lOPGridControl.Enabled =  cbKhoa.Enabled = true;
                positionSV = -1;
            
                btnThem.Enabled  = btnXoa.Enabled =btnSua.Enabled = true;
                btnADDSV.Enabled =true;
                btnUndoSV.Enabled=btnSaveSV.Enabled = false;
                btnDeleteSV.Enabled = btnEditSV.Enabled = true;


            }
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
          
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            positionSV = bdsSV.Position;
            flagmodeSV = "EDITSV";

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnSaveSV.Enabled = btnUndoSV.Enabled = true;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            cbKhoa.Enabled = lOPGridControl.Enabled = false;
        }

        private void btnUndoSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            flagmodeSV = "";
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
           
            if (flagmodeSV.Equals("EDITSV")) bdsSV.Position = positionSV;
            positionSV = -1;
            btnSaveSV.Enabled = btnUndoSV.Enabled = false;
            btnADDSV.Enabled =true;
            btnThem.Enabled =  btnXoa.Enabled= btnSua.Enabled = true;
            cbKhoa.Enabled = lOPGridControl.Enabled = true;
        
        }

        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {
       
            if (bdsSV.Count > 0 && !flagmodeSV.Equals("ADDSV"))
                btnDeleteSV.Enabled = btnEditSV.Enabled =true;
            else
                btnDeleteSV.Enabled = btnEditSV.Enabled = false;
        }
    }
    
}