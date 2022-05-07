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
    public partial class frmClass : DevExpress.XtraEditors.XtraForm
    {
        int vitri;
        public frmClass()
        {
            InitializeComponent();
        }

       
        private void frmClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.KHOA' table. You can move, or remove it, as needed.

            qLDSV_TCDataSet.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
            
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

           


            /*Program.bdsDSPM.Filter = "TENPHONG LIKE 'Công Nghệ%' OR TENPHONG LIKE 'Viễn Thông%'   ";*/
            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Học Phí%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void lOPGridControl_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            bdsLOP.AddNew();
            panelControl2.Enabled = true;
            teMALOP.Text = null;
            tekHOAHOC.Text = null;
            teTENLOP.Text = null;
            teMAKHOA.Text = "CNTT";
            
            btnThem.Enabled = btnSua.Enabled  = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(teMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp học không được để trống!", "", MessageBoxButtons.OK);
                teMALOP.Focus();
                return;
            }
            if (teTENLOP.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp học không được để trống!", "", MessageBoxButtons.OK);
                teTENLOP.Focus();
                return;
            }
            if (tekHOAHOC.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                tekHOAHOC.Focus();
                return;
            }
            try
            {
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = false;
            panelControl2.Enabled = false;
        }


        private void barLargeButtonSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}