using DevExpress.XtraBars;
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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public frmChangePass()
        {
            InitializeComponent();
        }

        private void frmChangePass_Load(object sender, EventArgs e)
        {
            CV.Text =  Program.mGroup;
            maTK.Text = Program.username.ToUpper();
            HoTen.Text = Program.mHoten;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
                
            if (mkMoi.Text != mkMoi2.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không trùng khớp!", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            try
            {
                String strCmd = "";
                if (CV.Text == "SV")
                {
                    strCmd = "exec SP_CHANGEPASS "+ Program.username + " ,'" + mkHT.Text + "','" + mkMoi.Text + "';";
                }
                else
                    strCmd = "exec SP_CHANGEPASS " + Program.mlogin + " ,'" + mkHT.Text + "','" + mkMoi.Text + "';";

                MessageBox.Show(strCmd);
                SqlDataReader dataReader = Program.ExecSqlDataReader(strCmd);
                if (dataReader != null)
                {
                    MessageBox.Show("thay đổi mật khẩu thành công", "thông báo!", MessageBoxButtons.OK);
                    Program.frmChinh.Visible = false;
                    Program.frmLogin.Visible = true;
                    Program.bdsDSPM.RemoveFilter();
                    Program.frmLogin.loadAgain();
                }
                else
                {
                    MessageBox.Show("không thể thay đổi mật khẩu! Hay kiểm tra mật khẩu của bạn", "Thông báo", MessageBoxButtons.OK);
                    mkHT.Text = null;
                    mkMoi.Text = null;
                    mkMoi2.Text = null;
                    return;
                }
                
                
            }
            catch (Exception EX)
            {
                MessageBox.Show("không thể thay đổi mật khẩu! Hay kiểm tra mật khẩu của bạn", "Thông báo", MessageBoxButtons.OK);
                mkHT.Text = null;
                mkMoi.Text = null;
                mkMoi2.Text = null;
                return;
            }
            
            
         }
                
        

        private void btnHuy_Click(object sender, EventArgs e)
        {
            mkHT.Text = null;
            mkMoi.Text = null;
            mkMoi2.Text = null;
        }
    }
}