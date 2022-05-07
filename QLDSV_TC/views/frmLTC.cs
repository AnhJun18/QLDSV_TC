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
    public partial class frmLTC : DevExpress.XtraEditors.XtraForm
    {
        public frmLTC()
        {
            InitializeComponent();
        }

        private void frmLTC_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hUYLOPCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mAGVLabel_Click(object sender, EventArgs e)
        {

        }

        private void mAGVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mAKHOALabel_Click(object sender, EventArgs e)
        {

        }

        private void sOSVTOITHIEULabel_Click(object sender, EventArgs e)
        {

        }

        private void nHOMSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void hUYLOPLabel_Click(object sender, EventArgs e)
        {

        }

        private void hOCKYSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mALTCLabel_Click(object sender, EventArgs e)
        {

        }
    }
}