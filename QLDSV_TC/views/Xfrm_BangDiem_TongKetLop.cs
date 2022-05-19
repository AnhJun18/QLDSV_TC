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
    public partial class Xfrm_BangDiem_TongKetLop : DevExpress.XtraEditors.XtraForm
    {
        public Xfrm_BangDiem_TongKetLop()
        {
            InitializeComponent();
            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }


        private void Xfrm_BangDiem_TongKetLop_Load(object sender, EventArgs e)
        {

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
           
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);


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

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                Report_BangDiem_TongKet_Lop rpt = new Report_BangDiem_TongKet_Lop(cbMaLop.Text.ToString());
                rpt.lbLop.Text = "Lớp: " + cbMaLop.Text + " - Niên Khóa: " + ((DataRowView)bdsLop[bdsLop.Position])["KHOAHOC"].ToString();

                rpt.lbKhoa.Text = "Khoa " + cbKhoa.Text;


                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();
            }
            catch
            {
                MessageBox.Show("Không thể tìm thấy thông tin cần in", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

               
        
    }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}