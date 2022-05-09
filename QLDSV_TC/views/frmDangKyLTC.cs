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
        public frmDangKyLTC()
        {
            InitializeComponent();
            
        }

        private void loadcbNienkhoa()
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.Sp_GetNienKhoa";
            dt = Program.ExecSqlDataTable(cmd);

            cbNienKhoa.DataSource = dt;
            cbNienKhoa.DisplayMember = "NIENKHOA";
            cbNienKhoa.ValueMember = "NIENKHOA";
            cbHocKy.Enabled = false;
        }

        private  void loadcbHocKi(string nienkhoa)
        {
            DataTable dt = new DataTable();
            string cmd = "EXEC dbo.Sp_GetHocKy'" + nienkhoa + "'";
            dt = Program.ExecSqlDataTable(cmd);

            cbHocKy.DataSource = dt;
            cbHocKy.DisplayMember = "HOCKY";
            cbHocKy.ValueMember = "HOCKY";
        }

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            loadcbNienkhoa();
            cbNienKhoa.SelectedIndex = -1;

        }

        private void cbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNienKhoa.Text);
            if (cbNienKhoa.SelectedIndex != -1)
                cbHocKy.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cmd = "EXEC [dbo].[SP_GET_LISTLOPTINCHI_DKI] '" + cbNienKhoa.Text + "', '" + cbHocKy.Text + "', '"+ Program.username+"'";
            DataTable tableLopTC = Program.ExecSqlDataTable(cmd);
            MessageBox.Show(cmd);
            this.bdsLopTinchi.DataSource = tableLopTC;
            this.gridControlLTC.DataSource = this.bdsLopTinchi;

            string cmd2 = "EXEC [dbo].[SP_GET_LISTLOPTINCHI_DADKI] '" + cbNienKhoa.Text + "', '" + cbHocKy.Text+ "', '" + Program.username+ "'";
            DataTable tableLopTCDaDKy = Program.ExecSqlDataTable(cmd2);
            this.bdsLopTinchiDaDKy.DataSource = tableLopTCDaDKy;
            this.gridControlDaDKy.DataSource = this.bdsLopTinchiDaDKy;
        }

        private void panelControl4_Paint(object sender, PaintEventArgs e)
        {

        }
        
     
    }
}