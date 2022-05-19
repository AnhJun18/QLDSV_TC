using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();
        String loginNameSV = "";


        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();

            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            da.Fill(dt);

            conn_publisher.Close();
            Program.bdsDSPM.DataSource = dt;
            cmbKhoa.DataSource = Program.bdsDSPM;
            cmbKhoa.DisplayMember = "TENPHONG";
            cmbKhoa.ValueMember = "TENSERVER";
        }

        private int KetNoi_CSDLGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.constr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
                return 0;
            }
        }

        public frmLogin()
        {

            InitializeComponent();
        }

        private void hideshowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (hideshowpass.Checked)
            {
                txtPass.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            if (KetNoi_CSDLGoc() == 0) return;
            LayDSPM("SELECT * FROM Get_Subscribes");
            cmbKhoa.SelectedIndex = 0;
            Program.servername = cmbKhoa.SelectedValue.ToString();
        }
       

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            if (txtUserName.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtUserName.Text;
            Program.pass = txtPass.Text;

            if (Program.KetNoi(false) == 1)
            {
                String strCmd = "EXEC SP_CHECK_DANGNHAP '" + Program.mlogin + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else if(!cmbKhoa.Text.ToString().Equals("Kế Toán"))
            {
                Program.mlogin = "SVIEN";
                Program.pass = "1";
                loginNameSV = txtUserName.Text;
                Program.passSV = txtPass.Text;

                if (Program.KetNoi() == 0) return;

                String strCmd = "EXEC SP_CHECK_LOGIN_SV '" + Program.mlogin + "', '" + loginNameSV + "','" + Program.passSV + "'";
                Program.myReader = Program.ExecSqlDataReader(strCmd);
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui long kiem tra lại");
                return;
            }
            Program.mPhongBan = cmbKhoa.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passDN = Program.pass;
            if (Program.myReader == null)  {
                return;
            }

            Program.myReader.Read();

            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.frmChinh = new frmMain();
                Program.frmChinh.statusMa.Text = "MÃ: "+ Program.username.ToUpper();
                Program.frmChinh.statusTen.Text = "TÊN: " +Program.mHoten;
                Program.frmChinh.statusKhoa.Text = "QUYỀN: " +Program.mGroup;
                this.Visible = false;
                Thread.Sleep(500);
                Program.frmChinh.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui long kiem tra lại \n" +ex.Message, "", MessageBoxButtons.OK);
                return;
            }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
        public void loadAgain()
        {
            cmbKhoa.SelectedItem = Program.mGroup;
            Program.servername = cmbKhoa.SelectedValue.ToString();
            txtUserName.Text = null;
            txtPass.Text = null;
            txtUserName.Focus();
           
        }
    }
}