using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }


        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonClass_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmClass));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmClass = new frmClass();
                Program.frmClass.MdiParent = this;
                Program.frmClass.Show();

            }
        }

        private void barButtonMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmMH));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMH = new frmMH();
                Program.frmMH.MdiParent = this;
                Program.frmMH.Show();

            }
        }


        private void barButtonLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLTC = new frmLTC();
                Program.frmLTC.MdiParent = this;
                Program.frmLTC.Show();

            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSInhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(views.frmStudent));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmSinhVien = new frmStudent();
                Program.frmSinhVien.MdiParent = this;
                Program.frmSinhVien.Show();

            }
        }
    }
}