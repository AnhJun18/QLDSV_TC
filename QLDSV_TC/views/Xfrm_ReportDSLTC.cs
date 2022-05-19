using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
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
    public partial class Xfrm_ReportDSLTC : DevExpress.XtraEditors.XtraForm
    {
        public Xfrm_ReportDSLTC()
        {
            InitializeComponent();
        }

        private void frmReportDSLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            qLDSV_TCDataSet.EnforceConstraints = false;

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                panelControl1.Enabled = false;
            }
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
                loadcbNienkhoa();
                loadcbHocKi(cbNIENKHOA.Text);
            }
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }
        void loadcbNienkhoa()
        {

            string cmd = "EXEC dbo.SP_GET_NIENKHOA";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cbNIENKHOA.DataSource = dt;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";

        }
        void loadcbHocKi(string nienkhoa)
        {

            string cmd = "EXEC dbo.SP_GET_HOCKY '" + nienkhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbHOCKY.DataSource = dt;
            cbHOCKY.DisplayMember = "HOCKY";
            cbHOCKY.ValueMember = "HOCKY";

        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcbHocKi(cbNIENKHOA.Text);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (cbNIENKHOA.Text == "" || cbHOCKY.Text == "")
            {
                MessageBox.Show("Không có thông tin lớp tín chỉ", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            else
            {
                Report_DS_LopTinChi rpt = new Report_DS_LopTinChi(cbNIENKHOA.Text, int.Parse(cbHOCKY.Text));

                rpt.lbTD.Text = "KHOA " + cbKhoa.Text.ToUpper();
                rpt.lbNK.Text = cbNIENKHOA.Text;
                rpt.lbHK.Text = cbHOCKY.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            
        }
    }
}