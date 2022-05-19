
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
    public partial class frmCreateLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmCreateLogin()
        {
            InitializeComponent();
        }


        private void frmCreateLogin_Load(object sender, EventArgs e)
        {
           
            qLDSV_TCDataSet1.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet1.GIANGVIEN);
            
            
            if(Program.mGroup == "KHOA" || Program.mGroup == "PGV")
            {

                
                if (Program.mGroup == "KHOA")
                {
                    radioGroup1.SelectedIndex = 1;
                    radioGroup1.Properties.Items[0].Enabled = radioGroup1.Properties.Items[2].Enabled = false;
                }
                else
                {
                    radioGroup1.SelectedIndex = 0;
                    radioGroup1.Properties.Items[2].Enabled = false;
                }
            }
            else
            {
                radioGroup1.SelectedIndex = 2;
                radioGroup1.Properties.Items[0].Enabled = radioGroup1.Properties.Items[1].Enabled = false;
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if(teUSER.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống!", "Thông Báo", MessageBoxButtons.OK);
                teUSER.Focus();
            }
            else
            {
                try
                {
                    string query = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_TAOLOGIN] '" + teUSER.Text +

                          "','1','" + cbGV.SelectedValue.ToString() + "', '" + radioGroup1.EditValue.ToString()+

                          "'; SELECT  'Return Value' = @return_value ";
                    int tmp = Program.CheckDataHelper(query);

                    if (tmp == 1)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông Báo", MessageBoxButtons.OK);
                        teUSER.Focus();
                    }
                    else if (tmp == 2)
                    {
                        MessageBox.Show("Giáo viên đã có tài khoản", "Thông Báo", MessageBoxButtons.OK);
                        teUSER.Focus();
                    }
                    else if(tmp ==0)
                    {
                        MessageBox.Show("Tạo tài khoản thành công", "Thông Báo", MessageBoxButtons.OK);
                        teUSER.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi Vui Lòng Kiểm Tra Lại", "Thông Báo", MessageBoxButtons.OK);
                        teUSER.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Không thể tạo tài khoản", "Thông báo", MessageBoxButtons.OK);
                    teUSER.Text = "";
                }
            }
        }

    }
}