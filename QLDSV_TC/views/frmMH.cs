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
        private String flagmode="";
        private int positionMH = -1;
        private String tenMH = "";  // Giữ tên Môn học lúc sửa
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

            if (bdsMonHoc.Count > 0)
                btnXoa.Enabled = btnSua.Enabled = true;

                }

       

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            positionMH = bdsMonHoc.Position;
            panelNhapLieu.Enabled = true;
            bdsMonHoc.AddNew();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled =btnPH.Enabled= true;
            mONHOCGridControl.Enabled = false;
            txtMaMH.Enabled = true;
            STLyThuyet.Value = 0;
            STThucHanh.Value = 0;
            flagmode = "ADDMH";
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            positionMH = bdsMonHoc.Position;
            panelNhapLieu.Enabled = true;

            txtMaMH.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled =   btnPH.Enabled =true;
            mONHOCGridControl.Enabled = false;
            tenMH=txtTenMH.Text.Trim();
            flagmode = "EDITMH";
        }

        private bool checkMH()
        {

            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaMH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được thiếu!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMH.Focus();
                return false;
            }

            if (STLyThuyet.Value < 0)
            {     
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                STLyThuyet.Focus();
                return false;
            }
            if (STThucHanh.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                STThucHanh.Focus();
                return false;
            }

            if ((STLyThuyet.Value + STThucHanh.Value) <= 0 || (STLyThuyet.Value+STThucHanh.Value)%15 != 0 )
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                STLyThuyet.Focus();
                return false;
            }


            if (flagmode.Equals("ADDMH"))
            {
                string query = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKID] " +

                          " @ID = N'" + txtMaMH.Text.Trim() + "',  " +

                          " @Type = N'MAMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";

                int resultMa = Program.CheckDataHelper(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã Môn Học đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaMH.Focus();
                    return false;
                }

            }
          
           if(flagmode=="ADDMH"  ||  ( flagmode=="EDITMH" && tenMH != txtTenMH.Text.Trim()))
            {
                string query2 = " DECLARE @return_value INT " +

                          " EXEC @return_value = [dbo].[SP_CHECKNAME] " +

                          " @Name = N'" + txtTenMH.Text.Trim() + "',  " +

                          " @Type = N'TENMONHOC' " +

                          " SELECT  'Return Value' = @return_value ";
                int result2 = Program.CheckDataHelper(query2);
                if (result2 == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui lòng thử lại sau", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (result2 == 1)
                {
                    MessageBox.Show("Tên Môn Học đã tồn tại. Mời bạn nhập tên khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenMH.Focus();
                    return false;
                }
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
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            
                flagmode = "";
                tenMH = "";
                mONHOCGridControl.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnGhi.Enabled =btnPH.Enabled= false;
                panelNhapLieu.Enabled = false;
            }
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            if (bdsLTC.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học này vì đã mở lớp tín chỉ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này không ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
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
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMonHoc.Position = bdsMonHoc.Find("MAMH", mamh);
                    return;
                }
            }
            if (bdsMonHoc.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(flagmode=="ADDMH" || flagmode == "EDITMH")
            {
                 if (MessageBox.Show("Dữ liệu chưa được lưu! Bạn có muốn thoát không không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                                    this.Close();
            }
            else
                this.Close();
        }

        private void btnPH_ItemClick(object sender, ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            bdsMonHoc.Position = positionMH;

            panelNhapLieu.Enabled = false;

            btnThem.Enabled =true;

            if (bdsMonHoc.Count > 0)
                btnXoa.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = btnPH.Enabled = false;

            mONHOCGridControl.Enabled = true;
            flagmode = "";
            tenMH = "";
        }
    }
}