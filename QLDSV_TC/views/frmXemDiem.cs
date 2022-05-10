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
    public partial class frmXemDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmXemDiem()
        {
            InitializeComponent();
            loadDataBangDiem();

        }

        private void loadDataBangDiem()
        {
            string cmd = "EXEC [dbo].[SP_GETDIEMSV] '" + Program.username + "'";
            DataTable tableDiemSV = Program.ExecSqlDataTable(cmd);
            this.gridControl1.DataSource = tableDiemSV;

        }
    }
}