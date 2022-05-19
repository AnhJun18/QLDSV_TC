using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLDSV_TC.reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class Xfrm_Report_BangDiemSV : DevExpress.XtraEditors.XtraForm
    {
        public Xfrm_Report_BangDiemSV()
        {
            InitializeComponent();
        }

        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sINHVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void frmReportBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            qLDSV_TCDataSet.EnforceConstraints = false;

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
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
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            }
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                tbMaSV.Focus();
            }
            else
            {
                try
                {

                    Report_PhieuDiemTheoSinhVien rpt = new Report_PhieuDiemTheoSinhVien(tbMaSV.Text);
                    rpt.lbTD.Text = "KHOA " + cbKhoa.Text.ToUpper();
                    rpt.lbSV.Text = "Bảng Điểm Sinh Viên: " + tbMaSV.Text;

                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sinh viên không tồn tại \n " + ex.Message);
                    tbMaSV.Focus();
                }

            }

        }
    }
}