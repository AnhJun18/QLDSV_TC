﻿using DevExpress.XtraBars;
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
    public partial class frmReportHocPhi : DevExpress.XtraEditors.XtraForm
    {
        public frmReportHocPhi()
        {
            InitializeComponent();
        }

        private void frmReportHocPhi_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet1.EnforceConstraints = false;
            

        }

        
        private String tenkhoa = "";
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (tbMaLop.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                tbMaLop.Focus();
            }
            else
            {

                try
                {
                    string cmd = "exec SP_GETKHOA '" + tbMaLop.Text + "'";
                    MessageBox.Show(cmd);
                    DataTable dt = Program.ExecSqlDataTable(cmd);
                    tenkhoa = dt.Rows[0][0].ToString();
                    MessageBox.Show(tenkhoa);
                    Report_HocPhiTheoLop rpt = new Report_HocPhiTheoLop(tbMaLop.Text, cbNIENKHOA.Text, int.Parse(cbHOCKY.Text));
                    rpt.lbKHOA.Text = "KHOA : " + tenkhoa.ToUpper();
                    rpt.lbMALOP.Text = "Mã Lớp: " + tbMaLop.Text.ToUpper();
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();

                }
                catch
                {
                    MessageBox.Show("Thông tin lớp học không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                    tbMaLop.Focus();
                }

            }

        }
    }
}