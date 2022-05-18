using DevExpress.Skins;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmNhapDiem : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPTINCHIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTINCHITableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);


            Program.bdsDSPM.Filter = "TENPHONG not LIKE 'Kế Toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENPHONG";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
            {
                panelChonKhoa.Enabled = true;
            }

            loadcbNienkhoa();
        }
        private void cbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
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
                loadcbNienkhoa();

            }
        }
        void loadcbNienkhoa()
        {

            string cmd = "EXEC dbo.SP_GET_NIENKHOA";
            DataTable dt = Program.ExecSqlDataTable(cmd);
            cbNIENKHOA.DataSource = dt;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";

        }
        void loadcbHocKi(string nienkhoa)
        {

            string cmd = "EXEC dbo.SP_GET_HOCKY '" + nienkhoa + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbHOCKY.DataSource = dt;
            cbHOCKY.DisplayMember = "HOCKY";
            cbHOCKY.ValueMember = "HOCKY";

        }
        void loadMH(string nienkhoa, string hocki)
        {

            string cmd = "EXEC dbo.SP_GET_MONHOC '" + nienkhoa + "', " + hocki;
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbMAMH.DataSource = dt;
            cbMAMH.DisplayMember = "MAMH";
            cbMAMH.ValueMember = "MAMH";
        }
        void loadNhom(string nienkhoa, string hocki, string mamonhoc)
        {

            string cmd = "EXEC dbo.SP_GET_NHOM '" + nienkhoa + "', " + hocki + ", '" + mamonhoc + "'";
            DataTable dt = Program.ExecSqlDataTable(cmd);

            cbNHOM.DataSource = dt;
            cbNHOM.DisplayMember = "NHOM";
            cbNHOM.ValueMember = "NHOM";
        }


        DataTable dkTable = new DataTable();
        private void loatBtnBD()
        {
            string cmd = "EXEC SP_DSDKMH '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", " + cbNHOM.Text + ", '" + cbMAMH.Text + "'";
            dkTable = Program.ExecSqlDataTable(cmd);
            this.gridControl1.DataSource = dkTable;
        }


        private void cbNIENKHOA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadcbHocKi(cbNIENKHOA.Text);
        }

        private void cbHOCKY_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMH(cbNIENKHOA.Text, cbHOCKY.Text);
        }

        private void cbMAMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadNhom(cbNIENKHOA.Text, cbHOCKY.Text, cbMAMH.Text);
        }

        private void btnBD_Click(object sender, EventArgs e)
        {
            string cmdd = "EXEC SP_SEARCH_LTC'" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", " + cbNHOM.Text + ", '" + cbMAMH.Text + "'";
            DataTable ltcTable = Program.ExecSqlDataTable(cmdd);
            this.gridControl2.DataSource = ltcTable;
            btnCN.Enabled = true;
            cbKhoa.Enabled = false;
            loatBtnBD();
            panelControl1.Enabled = btnBD.Enabled = false;
            /*this.DIEM_CK.OptionsColumn.ReadOnly = false; 
            this.DIEM_GK.OptionsColumn.ReadOnly = false; 
            this.DIEM_CC.OptionsColumn.ReadOnly = false;*/
            this.DIEM_CC.OptionsColumn.AllowFocus = true;
            this.DIEM_GK.OptionsColumn.AllowFocus = true;
            this.DIEM_CK.OptionsColumn.AllowFocus = true;
            gridControl1.Enabled = true;
            this.btnCN.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBD.BackColor = System.Drawing.SystemColors.ControlDark; ;
           
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            dt.Columns.Add("MASV", typeof(String));
            dt.Columns.Add("DIEM_CC", typeof(int));
            dt.Columns.Add("DIEM_GK", typeof(float));
            dt.Columns.Add("DIEM_CK", typeof(float));
            for (int i = 0; i < dkTable.Rows.Count; i++)
            {
                dt.Rows.Add(dkTable.Rows[i]["LOPTC"], dkTable.Rows[i]["MASV"], dkTable.Rows[i]["DIEM_CC"], dkTable.Rows[i]["DIEM_GK"], dkTable.Rows[i]["DIEM_CK"]);

            }
            try
            {
                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Structured;
                para.TypeName = "dbo.TYPE_DANGKY";
                para.ParameterName = "@DIEMTHI";
                para.Value = dt;
                Program.KetNoi();

                SqlCommand sqlcmd = new SqlCommand("SP_UPDATEDIEM", Program.conn);
                sqlcmd.Parameters.Clear();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.Add(para);
                sqlcmd.ExecuteNonQuery();
                loatBtnBD();
                panelControl1.Enabled = btnBD.Enabled = true;
                btnCN.Enabled = false;
                cbKhoa.Enabled = true;
                /*this.DIEM_CK.OptionsColumn.ReadOnly = true;
                this.DIEM_GK.OptionsColumn.ReadOnly = true;
                this.DIEM_CC.OptionsColumn.ReadOnly = true;*/
                this.DIEM_CC.OptionsColumn.AllowFocus = false;
                this.DIEM_GK.OptionsColumn.AllowFocus = false;
                this.DIEM_CK.OptionsColumn.AllowFocus = false;
                this.btnCN.BackColor = System.Drawing.SystemColors.ControlDark;
                this.btnBD.BackColor = System.Drawing.Color.SkyBlue;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi điểm thất bại\n" + ex.Message, "", MessageBoxButtons.OK);
                loatBtnBD();
            }
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(btnCN.Enabled == true)
            {
                if (MessageBox.Show("Dữ liệu chưa được cập nhật! Bạn có muốn thoát không? ", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    panelControl1.Enabled = btnBD.Enabled = true;
                    btnCN.Enabled = false;
                    cbKhoa.Enabled = true;
                    this.gridControl1.DataSource = null;
                    this.gridControl2.DataSource = null;
                    gridControl1.Enabled = false;
                  
                    this.btnCN.BackColor = System.Drawing.SystemColors.ControlDark;
                    this.btnBD.BackColor = System.Drawing.Color.SkyBlue;
                }

            }
            else
            {
                this.Close();
            }
           
            

        }

        private void gridView1_ValidatingEditor_1(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(e.Value);
                if (value > 10 || value < 0)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm Không Hợp lệ: 0 < Điểm < 10";
                }

            }
            catch { }
        }
    }
      

}