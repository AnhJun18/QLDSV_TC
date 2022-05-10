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
        private int vitri;
        private String makhoa = "";
        public frmLTC()
        {
            InitializeComponent();
        }

        private void frmLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.

            qLDSV_TCDataSet.EnforceConstraints = false;

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);


            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);


            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Học Phí%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";

            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "KHOA")
            {
                panelControl1.Enabled = false;
            }

            DataTable dt = Program.ExecSqlDataTable("EXEC SP_GetMaKhoa");
            makhoa = dt.Rows[0][0].ToString();
            ltcMaMH.DataSource = bdsMONHOC;
            ltcMaMH.DisplayMember = "TENMH";
            ltcMaMH.ValueMember = "MAMH";


            DataTable dtc = new DataTable();
            dtc.Columns.Add("FullName", typeof(String));
            dtc.Columns.Add("MAGV", typeof(String));
            for (int i=0;i< bdsGV.Count; i++)
             {
                 DataRow workRow = dtc.NewRow();
                 workRow["FullName"] = ((DataRowView)bdsGV[i])["Ho"].ToString() + ' ' + ((DataRowView)bdsGV[i])["TEN"].ToString();
                 workRow["MaGV"] = ((DataRowView)bdsGV[i])["MAGV"].ToString();
                 dtc.Rows.Add(workRow);


             }


             ltcMAGV.DataSource = dtc;
             ltcMAGV.DisplayMember = "FullName";
            ltcMAGV.ValueMember = "MAGV";


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
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            }
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdslOPTINCHI.Position;
            bdslOPTINCHI.AddNew();

            panelControl2.Enabled = true;
            ltcHUYLOP.Checked = false;
            cbKhoa.Enabled = false;

            ltcMAKHOA.Text = makhoa;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            lOPTINCHIGridControl.Enabled = false;
            ltcMaMH.SelectedIndex = 0;
            txtMaMH.Text = ltcMaMH.SelectedValue.ToString();
            ltcMAGV.SelectedIndex = 0;
            txtMAGV.Text = ltcMAGV.SelectedValue.ToString();
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ltcHOCKY.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                ltcHOCKY.Focus();
                return;
            }
            if (ltcMAGV.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn giáo viên!", "", MessageBoxButtons.OK);
                ltcMAGV.Focus();
                return;
            }
            if (ltcMaMH.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                ltcMaMH.Focus();
                return;
            }
            if (ltcNHOM.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                ltcNHOM.Focus();
                return;
            }
            if (ltcNIENKHOA.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng điền niên khóa!", "", MessageBoxButtons.OK);
                ltcNIENKHOA.Focus();
                return;
            }
            if (ltcSOSVTOITHIEU.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập số sinh viên tối thiểu!", "", MessageBoxButtons.OK);
                ltcSOSVTOITHIEU.Focus();
                return;
            }
            MessageBox.Show(ltcMAGV.SelectedValue.ToString() + " _-" + ltcMaMH.SelectedValue.ToString() + " _-" + ltcMaMH.SelectedValue.ToString());
            try
            {
                bdslOPTINCHI.EndEdit();
                bdslOPTINCHI.ResetCurrentItem();
                this.lOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI);
                lOPTINCHIGridControl.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            panelControl2.Enabled = false;
            cbKhoa.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            vitri = bdslOPTINCHI.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnPH.Enabled = true;
            cbKhoa.Enabled = false;
        }

        private void btnPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdslOPTINCHI.CancelEdit();

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            if (btnThem.Enabled == false) bdslOPTINCHI.Position = vitri;
            lOPTINCHIGridControl.Enabled = true;
            panelControl2.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;
            cbKhoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp tín chỉ vì đã có sinh viên đăng kí ", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp tín chỉ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*malop = char.Parse(((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString());*/
                    bdslOPTINCHI.RemoveCurrent();
                    this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTINCHITableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
                    /*bdsLOP.Position = bdsLOP.Find("MALOP", malop);*/
                    return;
                }
            }
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ltcMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltcMaMH.SelectedValue != null)
                txtMaMH.Text = ltcMaMH.SelectedValue.ToString();
        }


        private void txtMaMH_EditValueChanged_1(object sender, EventArgs e)
        {

                if (txtMaMH.Text !=  "System.Data.DataRowView" && txtMaMH.Text != null)
                {
                    ltcMaMH.SelectedValue = txtMaMH.Text;
                }
            

        }

        private void ltcMAGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltcMAGV.SelectedValue != null)
                txtMAGV.Text = ltcMAGV.SelectedValue.ToString();
        }

        private void txtMAGV_EditValueChanged(object sender, EventArgs e)
        {
           if (txtMAGV.Text != "System.Data.DataRowView" && txtMAGV.Text != null)
            {
                ltcMAGV.SelectedValue = txtMAGV.Text;
            }

        }

        private void lOPTINCHIGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}