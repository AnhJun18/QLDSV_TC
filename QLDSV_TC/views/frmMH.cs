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
                    // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MONHOC' table. You can move, or remove it, as needed.
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

                }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

       
        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}