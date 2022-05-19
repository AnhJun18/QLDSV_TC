using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV_TC.reports;
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
    public partial class XfrmBangDiemLopTinChi : DevExpress.XtraEditors.XtraForm
    {
        public XfrmBangDiemLopTinChi()
        {
            InitializeComponent();
            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
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
        void loadMH(string nienkhoa, string hocki)
        {
            string cmd = "EXEC dbo.SP_GET_MONHOC '" + nienkhoa + "', " + hocki;
          
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbMAMH.DataSource = dt;
            cbMAMH.DisplayMember = "TENMH";
            cbMAMH.ValueMember = "MAMH";
        }
        void loadNhom(string nienkhoa, string hocki, string mamonhoc)
        {

            string cmd = "EXEC dbo.SP_GET_NHOM '" + nienkhoa + "', " + hocki + ", N'" + mamonhoc + "'";

            DataTable dt = Program.ExecSqlDataTable(cmd);
          
            cbNHOM.DataSource = dt;
            cbNHOM.DisplayMember = "NHOM";
            cbNHOM.ValueMember = "NHOM";
        }
        private void XfrmBangDiemLopTinChi_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
           
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
                cbNIENKHOA.DataSource = null;
                cbHOCKY.DataSource = null;
                cbMAMH.DataSource = null;
                cbNHOM.DataSource = null;
                loadcbNienkhoa();
                

            }
        }
        private void cbNIENKHOA_SelectedValueChanged(object sender, EventArgs e)
        {
          
            if(cbNIENKHOA.Text !=  "System.Data.DataRowView")
                loadcbHocKi(cbNIENKHOA.Text);
        }

        private void cbHOCKY_SelectedValueChanged(object sender, EventArgs e)
        {
       
            if (cbHOCKY.Text != "System.Data.DataRowView")
                loadMH(cbNIENKHOA.Text, cbHOCKY.Text);
        }
        private void cbMAMH_SelectedValueChanged(object sender, EventArgs e)
        {
           
            if (cbMAMH.Text != "System.Data.DataRowView" && cbMAMH.SelectedValue != null)
                loadNhom(cbNIENKHOA.Text, cbHOCKY.Text, cbMAMH.SelectedValue.ToString());
        }

        private void cbNHOM_SelectedValueChanged(object sender, EventArgs e)
        {

        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (cbNIENKHOA.Text == "" || cbHOCKY.Text == "" || cbMAMH.Text == "" || cbNHOM.Text == "")
                MessageBox.Show("Không có thông tin lớp tín chỉ bạn cần tìm", "THÔNG BÁO", MessageBoxButtons.OK);
            else
            {
                Report_BangDiemLTC rpt = new Report_BangDiemLTC(cbNIENKHOA.Text, int.Parse(cbHOCKY.Text), cbMAMH.SelectedValue.ToString(), int.Parse(cbNHOM.Text));

                rpt.labelTieuDe.Text = "BẢNG ĐIỂM HẾT MÔN \n KHOA " + cbKhoa.Text.ToUpper();
                rpt.lbNienKhoa.Text = cbNIENKHOA.Text;
                rpt.lbHocKy.Text = cbHOCKY.Text;
                rpt.lbMonHoc.Text = cbMAMH.Text;
                rpt.lbNhom.Text = cbNHOM.Text;

                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            
        }

    }
}