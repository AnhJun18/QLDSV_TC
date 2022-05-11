
namespace QLDSV_TC.views
{
    partial class frmDangKyLTC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbNienKhoa = new System.Windows.Forms.ComboBox();
            this.cbHocKy = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlLTC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaLTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIANGVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DADANGKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnHuyDK = new System.Windows.Forms.Button();
            this.txtMaLTC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControlDaDKy = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDaDKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNienKhoa
            // 
            this.cbNienKhoa.AccessibleDescription = "";
            this.cbNienKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNienKhoa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNienKhoa.FormattingEnabled = true;
            this.cbNienKhoa.Location = new System.Drawing.Point(728, 30);
            this.cbNienKhoa.Name = "cbNienKhoa";
            this.cbNienKhoa.Size = new System.Drawing.Size(220, 29);
            this.cbNienKhoa.TabIndex = 0;
            this.cbNienKhoa.Tag = "";
            this.cbNienKhoa.SelectedIndexChanged += new System.EventHandler(this.cbNienKhoa_SelectedIndexChanged);
            // 
            // cbHocKy
            // 
            this.cbHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHocKy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHocKy.FormattingEnabled = true;
            this.cbHocKy.Location = new System.Drawing.Point(728, 74);
            this.cbHocKy.Name = "cbHocKy";
            this.cbHocKy.Size = new System.Drawing.Size(220, 29);
            this.cbHocKy.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(983, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.cbHocKy);
            this.panelControl1.Controls.Add(this.cbNienKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1077, 138);
            this.panelControl1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Học Kỳ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(622, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Niên Khóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 134);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // gridControlLTC
            // 
            this.gridControlLTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlLTC.Location = new System.Drawing.Point(0, 138);
            this.gridControlLTC.MainView = this.gridView1;
            this.gridControlLTC.Name = "gridControlLTC";
            this.gridControlLTC.Size = new System.Drawing.Size(1077, 273);
            this.gridControlLTC.TabIndex = 27;
            this.gridControlLTC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.DetailTip.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.ViewCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.ViewCaption.Options.UseBackColor = true;
            this.gridView1.Appearance.ViewCaption.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaLTC,
            this.MAMH,
            this.TENMH,
            this.NHOM,
            this.GIANGVIEN,
            this.DADANGKY});
            this.gridView1.GridControl = this.gridControlLTC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // MaLTC
            // 
            this.MaLTC.Caption = "Mã LTC";
            this.MaLTC.FieldName = "MALTC";
            this.MaLTC.MinWidth = 25;
            this.MaLTC.Name = "MaLTC";
            this.MaLTC.Visible = true;
            this.MaLTC.VisibleIndex = 0;
            this.MaLTC.Width = 94;
            // 
            // MAMH
            // 
            this.MAMH.Caption = "MÃ MH";
            this.MAMH.FieldName = "MAMH";
            this.MAMH.MinWidth = 25;
            this.MAMH.Name = "MAMH";
            this.MAMH.Visible = true;
            this.MAMH.VisibleIndex = 1;
            this.MAMH.Width = 94;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "Tên Môn Học";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.MinWidth = 25;
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 2;
            this.TENMH.Width = 94;
            // 
            // NHOM
            // 
            this.NHOM.Caption = "Nhóm";
            this.NHOM.FieldName = "NHOM";
            this.NHOM.MinWidth = 25;
            this.NHOM.Name = "NHOM";
            this.NHOM.Visible = true;
            this.NHOM.VisibleIndex = 3;
            this.NHOM.Width = 94;
            // 
            // GIANGVIEN
            // 
            this.GIANGVIEN.Caption = "Giảng Viên";
            this.GIANGVIEN.FieldName = "GIANGVIEN";
            this.GIANGVIEN.MinWidth = 25;
            this.GIANGVIEN.Name = "GIANGVIEN";
            this.GIANGVIEN.Visible = true;
            this.GIANGVIEN.VisibleIndex = 4;
            this.GIANGVIEN.Width = 94;
            // 
            // DADANGKY
            // 
            this.DADANGKY.Caption = "Đã Đăng Ký";
            this.DADANGKY.FieldName = "DADANGKY";
            this.DADANGKY.MinWidth = 25;
            this.DADANGKY.Name = "DADANGKY";
            this.DADANGKY.Visible = true;
            this.DADANGKY.VisibleIndex = 5;
            this.DADANGKY.Width = 94;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtMH);
            this.panelControl4.Controls.Add(this.label5);
            this.panelControl4.Controls.Add(this.label4);
            this.panelControl4.Controls.Add(this.btnDK);
            this.panelControl4.Controls.Add(this.btnHuyDK);
            this.panelControl4.Controls.Add(this.txtMaLTC);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl4.Location = new System.Drawing.Point(0, 411);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(500, 180);
            this.panelControl4.TabIndex = 28;
            // 
            // txtMH
            // 
            this.txtMH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMH.Location = new System.Drawing.Point(187, 83);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(172, 28);
            this.txtMH.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Môn Học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã LTC";
            // 
            // btnDK
            // 
            this.btnDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDK.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDK.Location = new System.Drawing.Point(271, 136);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(75, 43);
            this.btnDK.TabIndex = 3;
            this.btnDK.Text = "Đăng Ký";
            this.btnDK.UseVisualStyleBackColor = false;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnHuyDK
            // 
            this.btnHuyDK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHuyDK.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDK.Location = new System.Drawing.Point(148, 136);
            this.btnHuyDK.Name = "btnHuyDK";
            this.btnHuyDK.Size = new System.Drawing.Size(101, 43);
            this.btnHuyDK.TabIndex = 2;
            this.btnHuyDK.Text = "Hủy Đăng Ký";
            this.btnHuyDK.UseVisualStyleBackColor = false;
            this.btnHuyDK.Click += new System.EventHandler(this.btnHuyDK_Click);
            // 
            // txtMaLTC
            // 
            this.txtMaLTC.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLTC.Location = new System.Drawing.Point(187, 43);
            this.txtMaLTC.Name = "txtMaLTC";
            this.txtMaLTC.Size = new System.Drawing.Size(172, 28);
            this.txtMaLTC.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(500, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 35);
            this.panel2.TabIndex = 29;
            // 
            // gridControlDaDKy
            // 
            this.gridControlDaDKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDaDKy.Location = new System.Drawing.Point(500, 446);
            this.gridControlDaDKy.MainView = this.gridView2;
            this.gridControlDaDKy.Name = "gridControlDaDKy";
            this.gridControlDaDKy.Size = new System.Drawing.Size(577, 145);
            this.gridControlDaDKy.TabIndex = 30;
            this.gridControlDaDKy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView2.GridControl = this.gridControlDaDKy;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "MÃ LTC";
            this.gridColumn6.FieldName = "MALTC";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã MH";
            this.gridColumn1.FieldName = "MAMH";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên MH";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nhóm";
            this.gridColumn3.FieldName = "NHOM";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Giảng Viên";
            this.gridColumn4.FieldName = "GIANGVIEN";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Đã Đăng Ký";
            this.gridColumn5.FieldName = "DADANGKY";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 94;
            // 
            // frmDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 591);
            this.Controls.Add(this.gridControlDaDKy);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.gridControlLTC);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDangKyLTC";
            this.Text = "frmDamgKyLTC";
            this.Load += new System.EventHandler(this.frmDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDaDKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlDaDKy;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gridControlLTC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAMH;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn NHOM;
        private DevExpress.XtraGrid.Columns.GridColumn GIANGVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn DADANGKY;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbHocKy;
        private System.Windows.Forms.ComboBox cbNienKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn MaLTC;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnHuyDK;
        private System.Windows.Forms.TextBox txtMaLTC;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}