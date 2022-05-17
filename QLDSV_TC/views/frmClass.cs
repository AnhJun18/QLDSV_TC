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
        private String flagmode = "";
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
            /*Program.bdsDSPM.Filter = "TENPHONG LIKE 'Công Nghệ%' OR TENPHONG LIKE 'Viễn Thông%'   ";*/
            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Học Phí%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                panelChonKhoa.Enabled = false;
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            bdsLOP.AddNew();
            panelNhapLieu.Enabled = true;
            cbKhoa.Enabled = false;
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_GetMaKhoa");
            String makhoa = dt.Rows[0][0].ToString();
            teMAKHOA.Text = makhoa;
            
            btnThem.Enabled = btnSua.Enabled  = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            lOPGridControl.Enabled = gridControlsv.Enabled= panelbarSV.Enabled= false;
        }


        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return;
            }
            if (teTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp học không được để trống!", "", MessageBoxButtons.OK);
                teTENLOP.Focus();
                return;
            }
            if (tekHOAHOC.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                tekHOAHOC.Focus();
                return;
            }
            try
            {
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            lOPGridControl.Enabled = gridControlsv.Enabled =panelbarSV.Enabled= true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled  = false;
            panelNhapLieu.Enabled = false;
            cbKhoa.Enabled = true;
        }


        private void barLargeButtonSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            panelNhapLieu.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            cbKhoa.Enabled = false;
            txtMALOP.Enabled = false;

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

            }
        }

        private void btnPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            lOPGridControl.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            cbKhoa.Enabled = true;
        }
        
        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0 )
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }  
            if(MessageBox.Show("Bạn chắc chắn muốn xóa lớp học?", "Xác nhận", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                try
                {
                    /*malop = char.Parse(((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString());*/
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    /*bdsLOP.Position = bdsLOP.Find("MALOP", malop);*/
                    return;
                }
            }    
        }


        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnADDSV_Click(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            bdsSV.AddNew();
            positionSV = bdsSV.Count - 1;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
            panelChonKhoa.Enabled=lOPGridControl.Enabled = panelNhapLieu.Enabled = false;
            btnPH.Enabled=btnSaveSV.Enabled = true;
            flagmode = "ADDSV";
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsSV.Position != positionSV ||  gridView2.FocusedColumn.FieldName == "MALOP" || 
                (gridView2.FocusedColumn.FieldName == "DANGHIHOC" && flagmode.Equals("ADDSV"))
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
            DataRowView dt= (DataRowView ) bdsSV[positionSV];
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

            if (flagmode.Equals("ADDSV"))
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
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                lOPGridControl.Enabled = panelNhapLieu.Enabled = true;

                btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPH.Enabled = btnSua.Enabled = true;
                btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled =  true;
                btnSaveSV.Enabled = false;
                flagmode = "";

            }
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {

        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            positionSV = bdsSV.Position;
            flagmode = "EDITSV";
            btnSaveSV.Enabled  = btnPH.Enabled=true;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled= false;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled  = btnSua.Enabled = false;
            panelChonKhoa.Enabled = lOPGridControl.Enabled = panelNhapLieu.Enabled = false;
        }

        private void btnUndoSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            if (flagmode.Equals("EDITSV")) bdsSV.Position = positionSV;
            positionSV = -1;
            btnSaveSV.Enabled  = btnPH.Enabled =false;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = true;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnPH.Enabled = btnSua.Enabled = true;
            panelChonKhoa.Enabled = lOPGridControl.Enabled = panelNhapLieu.Enabled = true;
        }

       
    }
    
}