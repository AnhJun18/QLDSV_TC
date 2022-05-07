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
    public partial class frmMH : DevExpress.XtraEditors.XtraForm
    {
        public frmMH()
        {
            InitializeComponent();
        }
         private void frmMH_Load(object sender, EventArgs e)
                {

            DS.EnforceConstraints = false;
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);


                }

       

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            panelNhapLieu.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            mONHOCGridControl.Enabled = false;
        }
    }
}