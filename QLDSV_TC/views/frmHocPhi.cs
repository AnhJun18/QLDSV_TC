using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class frmHocPhi : DevExpress.XtraEditors.XtraForm
    {
        private String masv = "";
        private int positionHocPhi = -1;
        private int positionCTHocPhi = -1;
        private bool ignoreBoxError = false;
        private String modeSave = "";
        public frmHocPhi()
        {
            InitializeComponent();
        }


        private void getThongTinSV()
        {
            DataTable dt = new DataTable();
            masv = txtMaSv.Text;
            string cmd = "EXEC dbo.SP_GET_THONGTINSINHVIEN '" + masv + "'";
            dt = Program.ExecSqlDataTable(cmd);

            txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
            txtLop.Text = dt.Rows[0]["MALOP"].ToString();
        }
        private void loadDataHocPhiSv()
        {
            try
            {
                getThongTinSV();
                this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                sP_GET_HOCPHIGridControl.DataSource = bds_SP_GET_HOCPHI;
                bds_SP_GET_HOCPHI.Position = 0;
                loadCTDongHocPhi();

                panelContent.Enabled = true;
                btnThem.Enabled = true;
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                sP_GET_HOCPHIGridControl.DataSource = null;
                sP_GET_CTDONG_HOCPHIGridControl.DataSource = null;
                txtHoTen.Text = null;
                txtLop.Text = null;
                panelContent.Enabled = false;
                txtMaSv.Focus();
                btnThem.Enabled = false;
                masv = null;
                positionHocPhi = -1;
                positionCTHocPhi = -1;

                return;
            }

        }
        
        private void loadCTDongHocPhi()
        {
            
            positionHocPhi = bds_SP_GET_HOCPHI.Position;
            String nienkhoa = ((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["NIENKHOA"].ToString();
            String hocky = ((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["HOCKY"].ToString();

            this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, nienkhoa, int.Parse(hocky));
            sP_GET_CTDONG_HOCPHIGridControl.DataSource = bds_SP_GET_CTDONG_HOCPHI;
          

            if (bds_SP_GET_CTDONG_HOCPHI.Count > 0)
            {
                btnSua.Enabled = barBtnXoa.Enabled = false;

            }
            else
            {
                btnSua.Enabled = barBtnXoa.Enabled = true;
            }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            loadDataHocPhiSv();

        }


        private void frmHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void txtMaSv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                loadDataHocPhiSv();
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            loadCTDongHocPhi();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modeSave = "ADD";
            panelNhapHocPhi.Enabled = true;
            bds_SP_GET_HOCPHI.AddNew();

            txtDaDong.Visible = labelDaDong.Visible = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            panelControl1.Enabled = false;
            sP_GET_HOCPHIGridControl.Enabled = false;
            sP_GET_CTDONG_HOCPHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            String nienkhoa = txtNienKhoa.Text.Trim();
            int hocky = (int)txtHocKy.Value;
            int hocphi = (int)txtHocPhi.Value;
            string cmd = null;
            if (modeSave.Equals("ADD"))
                    cmd  = "EXEC [dbo].[SP_ADD_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + " ," + hocphi + "";
            else
                cmd = "EXEC [dbo].[SP_UPDATE_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + " ," + hocphi + "";
            try
            {


                
                if (Program.ExecSqlNonQuery(cmd) != 0)
                        return;
             
                this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, nienkhoa, hocky);

                panelControl1.Enabled = true;
                panelNhapHocPhi.Enabled = false;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                panelControl1.Enabled = true;
                sP_GET_HOCPHIGridControl.Enabled = sP_GET_CTDONG_HOCPHIGridControl.Enabled = true;

                int i = 0;
                while ((i < bds_SP_GET_HOCPHI.Count))
                {
                    DataRowView row = (DataRowView)bds_SP_GET_HOCPHI[i];
                    if (row["NIENKHOA"].ToString().Trim().Equals(nienkhoa) && (int.Parse(row["HOCKY"].ToString()).Equals(hocky)))
                    {
                        bds_SP_GET_HOCPHI.Position = i;
                        positionHocPhi = i;
                        break;
                    }
                    i++;

                }

                MessageBox.Show("Học Phí đã được cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            modeSave = "Edit";
            panelNhapHocPhi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled=barBtnXoa.Enabled = false;
            btnGhi.Enabled = true;
            txtDaDong.Visible = labelDaDong.Visible = false;
            txtNienKhoa.Enabled = false;
            txtHocKy.Enabled = false;
           
            panelControl1.Enabled = false;
            sP_GET_CTDONG_HOCPHIGridControl.Enabled = false;
            sP_GET_HOCPHIGridControl.Enabled = false;

        }

        private void dongHocPhi_Click(object sender, EventArgs e)
        {


            bds_SP_GET_CTDONG_HOCPHI.AddNew();
            gridView2.SetRowCellValue(gridView2.FocusedRowHandle, "NGAYDONG", DateTime.Now.ToString());
            positionCTHocPhi = bds_SP_GET_CTDONG_HOCPHI.Count - 1;
            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now;
            colNGAYDONG.ColumnEdit = ed;

            dongHocPhi.Enabled = false;
            thoatDongHP.Enabled = true;

            btnThem.Enabled = false;
            btnGhi.Enabled = false;
            btnSua.Enabled = false;
            panelControl1.Enabled = false;
            sP_GET_HOCPHIGridControl.Enabled = false;

        }

        

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {



            if (gridView2.FocusedColumn.FieldName == "SOTIENDONG")
            {
                try
                {
                    int sotiencandong = int.Parse(((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["HOCPHI"].ToString()) - int.Parse(((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["DADONG"].ToString());
                    if (int.Parse(e.Value.ToString()) > sotiencandong)
                    {
                        e.ErrorText = "Số tiền cần đóng chỉ là " + sotiencandong + " vnđ\n Vui lòng không đóng nhiều hơn số tiền này";
                        e.Valid = false;
                    }

                }
                catch { }

            }
        }

        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bds_SP_GET_CTDONG_HOCPHI.Position != positionCTHocPhi)
                e.Cancel = true;

        }


        private void ghiCTHocPhi()
        {
            DataRowView dt = (DataRowView)bds_SP_GET_CTDONG_HOCPHI[bds_SP_GET_CTDONG_HOCPHI.Position];
            String nienkhoa = txtNienKhoa.Text;
            int hocky = int.Parse(txtHocKy.Text);
            int sotiendong = int.Parse(dt["SOTIENDONG"].ToString());
            DateTime ngaydong = Convert.ToDateTime( dt["NGAYDONG"].ToString());
          
            string cmd = "EXEC [dbo].[SP_SAVE_DONG_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + " ,'" + ngaydong.ToString("MM/dd/yyyy") + "' ," + sotiendong + "";
            try
            {
                if (Program.ExecSqlNonQuery(cmd) != 0)
                    return;
                this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, nienkhoa, hocky);

                panelControl1.Enabled = true;
                panelNhapHocPhi.Enabled = false;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                panelControl1.Enabled = true;
                sP_GET_HOCPHIGridControl.Enabled = true;
                int i = 0;
                while ((i < bds_SP_GET_HOCPHI.Count))
                {
                    DataRowView row = (DataRowView)bds_SP_GET_HOCPHI[i];
                    if (row["NIENKHOA"].ToString().Trim().Equals(nienkhoa) && (int.Parse(row["HOCKY"].ToString()).Equals(hocky)))
                    {
                        bds_SP_GET_HOCPHI.Position = i;
                        break;
                    }
                    i++;
                }
                positionCTHocPhi = -1;

            }
            catch
            {
                MessageBox.Show("Cập nhật học phí thất bại! \n Vui lòng cập nhật sau");
            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            ignoreBoxError = false;

            if (((DataRowView)e.Row)["SOTIENDONG"].ToString() == "")
            {
                e.ErrorText = "Bạn chưa nhập đầy đủ thông tin về số tiền cần đóng! \n" +
                           " Bạn có muốn tiếp tục không?  \n";
                e.Valid = false;
            }
            else
            {

                DialogResult tmpchoose = MessageBox.Show("Bạn có chắc chắn muốn đóng " + " vnđ \n Sinh viên: " + txtHoTen.Text + " Niên Khóa: " + txtNienKhoa.Text + " Học Kỳ: " + txtHocKy.Text,
                                       "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (tmpchoose == DialogResult.Yes)
                {
                    ghiCTHocPhi();
                    dongHocPhi.Enabled = true;
                    thoatDongHP.Enabled = false;
                   
                }
                else if (tmpchoose == DialogResult.No)
                {
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, txtNienKhoa.Text, int.Parse(txtHocKy.Text));
                    panelControl1.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    panelControl1.Enabled = true;
                    sP_GET_HOCPHIGridControl.Enabled = true;
                    dongHocPhi.Enabled = true;
                    thoatDongHP.Enabled = false;
                    positionCTHocPhi = -1;
                }
                else
                {
                    ignoreBoxError = true;
                    e.Valid = false;
                }

            }

        }

    

        private void gridView2_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            if (ignoreBoxError)
                e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            else
            {
                DialogResult dr = XtraMessageBox.Show(e.ErrorText, e.WindowCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.No)
                {
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore;
                    panelControl1.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    panelControl1.Enabled = true;
                    sP_GET_HOCPHIGridControl.Enabled = true;
                    positionCTHocPhi = -1;
                    ignoreBoxError = false;
                    dongHocPhi.Enabled = true;
                    thoatDongHP.Enabled = false;

                }
                else
                    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            }
                
        }

        private void thoatDongHP_Click(object sender, EventArgs e)
        {
            this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, txtNienKhoa.Text, int.Parse(txtHocKy.Text));
            panelControl1.Enabled = true;
            panelNhapHocPhi.Enabled = false;
            btnThem.Enabled = true;
            btnGhi.Enabled = false;
            panelControl1.Enabled = true;
            sP_GET_HOCPHIGridControl.Enabled = true;
            dongHocPhi.Enabled = true;
            thoatDongHP.Enabled = false;
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin học phí này ko?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                    String nienkhoa = txtNienKhoa.Text.Trim();
                    int hocky = (int)txtHocKy.Value;
                    int hocphi = (int)txtHocPhi.Value;
                try
                {

                    string cmd = "EXEC [dbo].[SP_DELETE_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + "";
                    int i = 0;
                   if( Program.ExecSqlNonQuery(cmd) !=0)
                    while ((i < bds_SP_GET_HOCPHI.Count))
                    {
                        DataRowView row = (DataRowView)bds_SP_GET_HOCPHI[i];
                        if (row["NIENKHOA"].ToString().Trim().Equals(nienkhoa) && (int.Parse(row["HOCKY"].ToString()).Equals(hocky)))
                        {
                            bds_SP_GET_HOCPHI.Position = i;
                                return;
                        }
                        i++;
                    }

                    this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                    sP_GET_HOCPHIGridControl.DataSource = bds_SP_GET_HOCPHI;
                    bds_SP_GET_HOCPHI.Position = 0;
                    loadCTDongHocPhi();
                    panelContent.Enabled = true;
                    btnThem.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Học Phí, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}