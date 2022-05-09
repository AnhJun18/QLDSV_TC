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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            /*this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);*/

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Học Phí%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                panelControl1.Enabled = false;
            }
            
            cbHOCKY.SelectedIndex = -1;
            cbMAMH.Text = "";
            cbNHOM.Text = "";
            loadcbNienkhoa();
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
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            }
        }
        void loadcbNienkhoa()
        {

            string cmd = "EXEC dbo.sp_get_NienKhoa";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cbNIENKHOA.DataSource = dt;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";

        }
        void loadcbHocKi(string nienkhoa)
        {

            string cmd = "EXEC dbo.sp_get_HocKy '" + nienkhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbHOCKY.DataSource = dt;
            cbHOCKY.DisplayMember = "HOCKY";
            cbHOCKY.ValueMember = "HOCKY";
            
        }
        void loadMH(string nienkhoa, string hocki)
        {

            string cmd = "EXEC dbo.sp_get_MonHoc '" + nienkhoa + "', " + hocki  ;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbMAMH.DataSource = dt;
            cbMAMH.DisplayMember = "MAMH";
            cbMAMH.ValueMember = "MAMH";
        }
        void loadNhom(string nienkhoa, string hocki, string mamonhoc)
        {

            string cmd = "EXEC dbo.sp_get_Nhom '" + nienkhoa + "', " + hocki + ", '" + mamonhoc + "'" ;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbNHOM.DataSource = dt;
            cbNHOM.DisplayMember = "NHOM";
            cbNHOM.ValueMember = "NHOM";
        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNIENKHOA.Text);
        }

        private void cbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhom(cbNIENKHOA.Text, cbHOCKY.Text, cbMAMH.Text);
        }

        private void cbHOCKY_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMH(cbNIENKHOA.Text, cbHOCKY.Text);
        }
        private BindingSource bdsDiem = new BindingSource();
        private BindingSource bdsLTC = new BindingSource();
        private void btnBD_Click(object sender, EventArgs e)
        {
            string cmdd = "EXEC SP_GET_LTC'" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", " + cbNHOM.Text + ", '" + cbMAMH.Text + "'";
            DataTable ltcTable = Program.ExecSqlDataTable(cmdd);
            this.bdsLTC.DataSource = ltcTable;
            this.gridControl2.DataSource = this.bdsLTC;

            string cmd = "EXEC SP_DSDkMH '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", " + cbNHOM.Text + ", '" + cbMAMH.Text + "'";
            DataTable diemTable = Program.ExecSqlDataTable(cmd);
            this.bdsDiem.DataSource = diemTable;
            this.gridControl1.DataSource = this.bdsDiem;
           
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
           
           
        }
    }
}