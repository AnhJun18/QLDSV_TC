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
            if (Program.mGroup == "KHOA")
            {
                panelControl1.Enabled = false;
            }
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

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            bdsLOP.AddNew();
            panelControl2.Enabled = true;
            cbKhoa.Enabled = false;
            DataTable dt = Program.ExecSqlDataTable("EXEC SP_GetMaKhoa");
            String makhoa = dt.Rows[0][0].ToString();
            teMAKHOA.Text = makhoa;
            
            btnThem.Enabled = btnSua.Enabled  = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            lOPGridControl.Enabled = false;
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
                this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                lOPGridControl.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled  = false;
            panelControl2.Enabled = false;
            cbKhoa.Enabled = true;
        }


        private void barLargeButtonSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            cbKhoa.Enabled = false;

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

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            }
        }

        private void btnPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            lOPGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            cbKhoa.Enabled = true;
        }
        
        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0 )
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }  
            if(MessageBox.Show("Bạn chắc chắn muốn xóa lớp học?", "Xác nhận", MessageBoxButtons.OKCancel ) == DialogResult.OK)
            {
                try
                {
                    /*malop = char.Parse(((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString());*/
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    /*bdsLOP.Position = bdsLOP.Find("MALOP", malop);*/
                    return;
                }
            }    
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
    
}