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
    public partial class frmDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        private BindingSource bdsLopTinchi = new BindingSource();
        private BindingSource bdsLopTinchiDaDKy = new BindingSource();
        private String masv = Program.username.ToUpper();
        public frmDangKyLTC()
        {
            InitializeComponent();
            getThongTinSV();
            
        }

        private void getThongTinSV()
        {
            try
            {
                     DataTable dt = new DataTable();
                    string cmd = "EXEC dbo.SP_GET_THONGTINSINHVIEN '" + masv + "'";
                    dt = Program.ExecSqlDataTable(cmd);

                    lbMaSv.Text = masv;
                    lbHoTen.Text=   dt.Rows[0]["HOTEN"].ToString();
                
                   /* lbPhai.Text = dt.Rows[0]["PHAI"].ToString();
                    lbNgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();*/
                    lbLop.Text = dt.Rows[0]["MALOP"].ToString()+"("+ dt.Rows[0]["TENLOP"].ToString()+")";
                    lbKhoa.Text = dt.Rows[0]["TENKHOA"].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Không thể load thông tin của bạn trong sever" +e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.Sp_Get_NienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            cbNienKhoa.DataSource = dt;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
        }

        private  void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.Sp_Get_HocKy'" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            cbHocKy.DataSource = dt;
            cbHocKy.DisplayMember = "HOCKY";
            cbHocKy.ValueMember = "HOCKY";
        }

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            loadcbNienkhoa();
        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
      

        }

        private void loadData()
        {
            string cmd = "EXEC [dbo].[SP_GET_LISTLOPTINCHI_DKI] '" + cbNienKhoa.Text + "', '" + cbHocKy.Text + "', '" + masv + "'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.gridControlLTC.DataSource = this.bdsLopTinchi;

            string cmd2 = "EXEC [dbo].[SP_GET_LISTLOPTINCHI_DADKI] '" + cbNienKhoa.Text + "', '" + cbHocKy.Text + "', '" + masv + "'";
            DataTable tableLopTCDaDKy = Program.ExecSqlDataTable(cmd2);
            this.bdsLopTinchiDaDKy.DataSource = tableLopTCDaDKy;
            this.gridControlDaDKy.DataSource = this.bdsLopTinchiDaDKy;

            panelDKHUYDK.Enabled = false;
            this.btnDK.BackColor = System.Drawing.Color.LightGray;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightGray;
            txtMaLTC.Text = null;
            txtMH.Text = null;
            txtMaGV.Text = null;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            loadData();
        }

        

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (bdsLopTinchi.Count > 0)
            {
                txtMaLTC.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["MALTC"].ToString();
                txtMH.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["TENMH"].ToString();
                txtMaGV.Text = ((DataRowView)bdsLopTinchi[bdsLopTinchi.Position])["GIANGVIEN"].ToString();
            }
            panelDKHUYDK.Enabled = true;
            btnDK.Enabled = true;
            btnHuyDK.Enabled = false;
            this.btnDK.BackColor = System.Drawing.Color.LightGreen;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightGray;
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          if (bdsLopTinchiDaDKy.Count > 0)
            {
                txtMaLTC.Text  = ((DataRowView)bdsLopTinchiDaDKy[bdsLopTinchiDaDKy.Position])["MALTC"].ToString();
                txtMH.Text = ((DataRowView)bdsLopTinchiDaDKy[bdsLopTinchiDaDKy.Position])["TENMH"].ToString();
                txtMaGV.Text = ((DataRowView)bdsLopTinchiDaDKy[bdsLopTinchiDaDKy.Position])["GIANGVIEN"].ToString();

            }
            panelDKHUYDK.Enabled = true;
            btnDK.Enabled = false;
            btnHuyDK.Enabled = true;
            this.btnDK.BackColor = System.Drawing.Color.LightGray;
            this.btnHuyDK.BackColor = System.Drawing.Color.LightPink;

        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_DKY_LTC] '" + txtMaLTC.Text + "' , '" + masv + "' ";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Đăng kí thành công!");
                    loadData();
                    
                }
                else
                {
                    MessageBox.Show("Đăng kí thất bại");
                }
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đăng kí lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string cmd = "EXEC [dbo].[SP_HUY_DKY_LTC] '" +txtMaLTC.Text + "' , '" + masv + "' ";
                if (Program.ExecSqlNonQuery(cmd) == 0)
                {
                    MessageBox.Show("Hủy đăng kí thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Hủy đăng kí thất bại");
                }
            }
        }
    }
}