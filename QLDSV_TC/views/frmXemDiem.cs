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
    public partial class frmXemDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmXemDiem()
        {
            InitializeComponent();
            getThongTinSV();
            loadDataBangDiem();

        }

        private void getThongTinSV()
        {
            try
            {
                DataTable dt = new DataTable();
                string cmd = "EXEC dbo.SP_GET_THONGTINSINHVIEN '" + Program.username + "'";
                dt = Program.ExecSqlDataTable(cmd);

                lbMaSv.Text = Program.username;
                lbHoTen.Text = dt.Rows[0]["HOTEN"].ToString();

           /*     lbPhai.Text = dt.Rows[0]["PHAI"].ToString();
                lbNgaySinh.Text = dt.Rows[0]["NGAYSINH"].ToString();*/
                lbLop.Text = dt.Rows[0]["MALOP"].ToString() + "( " + dt.Rows[0]["TENLOP"].ToString() + " )";
                lbKhoa.Text = dt.Rows[0]["TENKHOA"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Không thể load thông tin của bạn trong sever" + e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void loadDataBangDiem()
        {
            string cmd = "EXEC [dbo].[SP_GETDIEMSV] '" + Program.username + "'";
            DataTable tableDiemSV = Program.ExecSqlDataTable(cmd);
            this.gridControl1.DataSource = tableDiemSV;

        }
    }
}