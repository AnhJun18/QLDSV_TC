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
           
                DS.EnforceConstraints = false;
                this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                this.lOPTINCHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);


                }

       

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            panelNhapLieu.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            mONHOCGridControl.Enabled = false;

            STLyThuyet.Value = 0;
            STThucHanh.Value = 0;
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelNhapLieu.Enabled = true;

            txtMaMH.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            mONHOCGridControl.Enabled = false;
        }

        private bool checkMH()
        {

            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return false;
            }

            if (STLyThuyet.Value < 0)
            {     
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK);
                STLyThuyet.Focus();
                return false;
            }
            if (STThucHanh.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK);
                STThucHanh.Focus();
                return false;
            }

            if ((STLyThuyet.Value + STThucHanh.Value) <= 0 || (STLyThuyet.Value+STThucHanh.Value)%15 != 0 )
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK);
                STLyThuyet.Focus();
                return false;
            }



            string query = " DECLARE @return_value INT " +

                           " EXEC @return_value = [dbo].[SP_CHECKID] " +

                           " @ID = N'" + txtMaMH.Text.Trim() + "',  " +

                           " @Type = N'MAMONHOC' " +

                           " SELECT  'Return Value' = @return_value ";

            int resultMa = Program.CheckDataHelper(query);
            if (resultMa == -1)
            {
                MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK);
                return false;
            }
            if (resultMa == 1)
            {
                MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (checkMH() == true)
            {
                try
                {
                    bdsMonHoc.EndEdit();
                    bdsMonHoc.ResetCurrentItem();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

            
               mONHOCGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled = false;
                panelNhapLieu.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã mở lớp tín chỉ lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này không ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string mamh = "";
                try
                {
                    mamh = ((DataRowView)bdsMonHoc[bdsMonHoc.Position])["MAMH"].ToString();
                    bdsMonHoc.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0) btnXoa.Enabled = false;
        }
    }
}