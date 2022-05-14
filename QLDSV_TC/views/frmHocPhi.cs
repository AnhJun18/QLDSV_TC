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
        public frmHocPhi()
        {
            InitializeComponent();
        }



        private void loadDataHocPhiSv()
        {
            try
            {

                DataTable dt = new DataTable();
                masv = txtMaSv.Text;
                string cmd = "EXEC dbo.SP_GET_THONGTINSINHVIEN '" + masv + "'";
                dt = Program.ExecSqlDataTable(cmd);
                txtHoTen.Text = dt.Rows[0]["HOTEN"].ToString();
                txtLop.Text = dt.Rows[0]["MALOP"].ToString();

                this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                sP_GET_HOCPHIGridControl.DataSource = bds_SP_GET_HOCPHI;
                panelContent.Enabled = true;
                btnThem.Enabled = true;
                positionHocPhi = 0;
                bds_SP_GET_HOCPHI.Position = 0;
                

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

                return;
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
            if(e.KeyChar == (char)Keys.Enter)
                 loadDataHocPhiSv();
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            positionHocPhi = bds_SP_GET_HOCPHI.Position;
            String nienkhoa = ((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["NIENKHOA"].ToString();
            String hocky = ((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["HOCKY"].ToString();

            this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, nienkhoa, int.Parse(hocky));
            sP_GET_CTDONG_HOCPHIGridControl.DataSource = bds_SP_GET_CTDONG_HOCPHI;
            btnSua.Enabled = true;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelNhapHocPhi.Enabled = true;
            bds_SP_GET_HOCPHI.AddNew();
            txtDaDong.Visible = false;
            labelDaDong.Visible = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = true;
            panelControl1.Enabled = false;
            sP_GET_CTDONG_HOCPHIGridControl.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            String nienkhoa = txtNienKhoa.Text.Trim();
            int hocky = (int)txtHocKy.Value;
            int hocphi = (int)txtHocPhi.Value;
            string cmd = "EXEC [dbo].[SP_UPDATE_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + " ," +hocphi+ "";
            try
            {
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Học Phí đã được cập nhật thành công!");
                    this.sp_GET_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sp_GET_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_HOCPHI, masv);
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, nienkhoa, hocky);
                    panelControl1.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    panelControl1.Enabled = true;
                    sP_GET_CTDONG_HOCPHIGridControl.Enabled = true;
                    int i = 0;
                    while ((i < bds_SP_GET_HOCPHI.Count))
                    {
                        DataRowView row = (DataRowView)bds_SP_GET_HOCPHI[i];
                        if (row["NIENKHOA"].ToString().Trim().Equals(nienkhoa) && (int.Parse(row["HOCKY"].ToString()).Equals( hocky)))
                        {
                            bds_SP_GET_HOCPHI.Position = i;
                            positionHocPhi = i;
                            break;
                        }
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật học phí thất bại! \n Vui lòng cập nhật sau");
                }
            }
            catch
            {


            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_SP_GET_CTDONG_HOCPHI.Count > 0)
            {

                MessageBox.Show("Sinh Viên đã đóng học phí không thể sửa");
                return;
            }
            panelNhapHocPhi.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnGhi.Enabled = true;
            txtDaDong.Visible = false;
            labelDaDong.Visible = false;
            txtNienKhoa.ReadOnly = true;
            txtHocKy.ReadOnly = true;
            panelControl1.Enabled = false;
            sP_GET_CTDONG_HOCPHIGridControl.Enabled = false;

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void dongHocPhi_Click(object sender, EventArgs e)
        {
            bds_SP_GET_CTDONG_HOCPHI.AddNew();
            gridView2.SetRowCellValue(gridView2.FocusedRowHandle, "NGAYDONG","05/05/2012");

           /* gridView2.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle;
            gridView2.FocusedColumn.FieldName = "SOTIENDONG";
            gridView2.Focus();*/
            txtDaDong.Visible = false;
            btnThem.Enabled = false;
            btnGhi.Enabled = false;
            btnSua.Enabled = false;
            panelControl1.Enabled = false;
            sP_GET_HOCPHIGridControl.Enabled = false;
        
        }

        private void luuDongHocPhi_Click(object sender, EventArgs e)
        {
            
        }

        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

          
          
            if (gridView2.FocusedColumn.FieldName =="SOTIENDONG" )
            {
                try
                {
                          int sotiencandong = int.Parse(((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["HOCPHI"].ToString())- int.Parse(((DataRowView)bds_SP_GET_HOCPHI[positionHocPhi])["DADONG"].ToString());
                        if ( int.Parse(e.Value.ToString()) > sotiencandong)
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
            if(gridView2.FocusedRowHandle != DevExpress.XtraGrid.GridControl.NewItemRowHandle || gridView2.FocusedColumn.FieldName == "NGAYDONG")
                  e.Cancel = true;
            
        }


        private void ghiCTHocPhi()
        {
            DataRowView dt = (DataRowView)bds_SP_GET_CTDONG_HOCPHI[bds_SP_GET_CTDONG_HOCPHI.Position];
            String nienkhoa = txtNienKhoa.Text;
            int hocky = int.Parse(txtHocKy.Text);
            int sotiendong = int.Parse(dt["SOTIENDONG"].ToString());
            string cmd = "EXEC [dbo].[SP_SAVE_DONG_HOCPHI] '" + masv + "' , '" + nienkhoa + "' , " + hocky + " ," + sotiendong + "";

            if (Program.ExecSqlNonQuery(cmd) == 0)
            {
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
            }
            else
            {
                MessageBox.Show("Cập nhật học phí thất bại! \n Vui lòng cập nhật sau");
            }
        }
        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "SOTIENDONG")
            {
                DialogResult tmpchoose = MessageBox.Show("Bạn có chắc chắn muốn đóng " + e.Value + " vnđ \n Sinh viên: " + txtHoTen.Text + " Niên Khóa: " + txtNienKhoa.Text + " Học Kỳ: " + txtHocKy.Text,
                                       "Xác nhận", MessageBoxButtons.YesNoCancel);
                if ( tmpchoose == DialogResult.Yes)
                {
                    ghiCTHocPhi();
                }
                else if(tmpchoose == DialogResult.No)
                {
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sP_GET_CTDONG_HOCPHITableAdapter.Fill(this.qLDSV_TCDataSet1.SP_GET_CTDONG_HOCPHI, masv, txtNienKhoa.Text,int.Parse( txtHocKy.Text));
                    panelControl1.Enabled = true;
                    panelNhapHocPhi.Enabled = false;
                    btnThem.Enabled = true;
                    btnGhi.Enabled = false;
                    panelControl1.Enabled = true;
                    sP_GET_HOCPHIGridControl.Enabled = true;
                }

            }
        }

        private void gridView2_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (((DataRowView)e.Row)["SOTIENDONG"].ToString() == "")
            {
                e.ErrorText = "Bạn chưa nhập đầy đủ thông tin về số tiền cần đóng! \n" +
                           " Bạn có muốn tiếp tục không?  \n";
                    e.Valid = false;
            }  
        }
    }
}