
namespace QLDSV_TC.views
{
    partial class frmNhapDiem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label mAMHLabel;
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.lOPTINCHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbNHOM = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.cbMAMH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelDiemSV = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTK = new DevExpress.XtraGrid.Columns.GridColumn();
            nHOMLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panelDiemSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nHOMLabel.Location = new System.Drawing.Point(484, 116);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(60, 21);
            nHOMLabel.TabIndex = 32;
            nHOMLabel.Text = "Nhóm:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(486, 65);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(73, 21);
            hOCKYLabel.TabIndex = 30;
            hOCKYLabel.Text = "Học Kỳ:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(86, 65);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(93, 21);
            nIENKHOALabel.TabIndex = 28;
            nIENKHOALabel.Text = "Niên Khóa:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(86, 114);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(115, 21);
            mAMHLabel.TabIndex = 27;
            mAMHLabel.Text = "Mã Môn Học:";
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTINCHITableAdapter
            // 
            this.lOPTINCHITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.lOPTINCHITableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.Controls.Add(this.cbKhoa);
            this.panelChonKhoa.Controls.Add(this.label2);
            this.panelChonKhoa.Controls.Add(this.label1);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Enabled = false;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelChonKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(1384, 90);
            this.panelChonKhoa.TabIndex = 2;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(470, 36);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(392, 29);
            this.cbKhoa.TabIndex = 3;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "KHOA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Điểm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnCN);
            this.panelControl2.Controls.Add(this.btnBD);
            this.panelControl2.Controls.Add(this.panelControl1);
            this.panelControl2.Controls.Add(this.gridControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 90);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1384, 213);
            this.panelControl2.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(526, 167);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 38);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCN.Enabled = false;
            this.btnCN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(391, 169);
            this.btnCN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(115, 37);
            this.btnCN.TabIndex = 28;
            this.btnCN.Text = "Cập Nhật";
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnBD
            // 
            this.btnBD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(264, 170);
            this.btnBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(93, 36);
            this.btnBD.TabIndex = 27;
            this.btnBD.Text = "Bắt Dầu";
            this.btnBD.UseVisualStyleBackColor = false;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(nHOMLabel);
            this.panelControl1.Controls.Add(this.cbNHOM);
            this.panelControl1.Controls.Add(hOCKYLabel);
            this.panelControl1.Controls.Add(this.cbHOCKY);
            this.panelControl1.Controls.Add(nIENKHOALabel);
            this.panelControl1.Controls.Add(this.cbNIENKHOA);
            this.panelControl1.Controls.Add(mAMHLabel);
            this.panelControl1.Controls.Add(this.cbMAMH);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(649, 153);
            this.panelControl1.TabIndex = 24;
            // 
            // cbNHOM
            // 
            this.cbNHOM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "NHOM", true));
            this.cbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNHOM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNHOM.FormattingEnabled = true;
            this.cbNHOM.Location = new System.Drawing.Point(574, 111);
            this.cbNHOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNHOM.Name = "cbNHOM";
            this.cbNHOM.Size = new System.Drawing.Size(233, 29);
            this.cbNHOM.TabIndex = 34;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "HOCKY", true));
            this.cbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHOCKY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.FormattingEnabled = true;
            this.cbHOCKY.Location = new System.Drawing.Point(574, 62);
            this.cbHOCKY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(233, 29);
            this.cbHOCKY.TabIndex = 33;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "NIENKHOA", true));
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(199, 59);
            this.cbNIENKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(233, 29);
            this.cbNIENKHOA.TabIndex = 31;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged_1);
            // 
            // cbMAMH
            // 
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "MAMH", true));
            this.cbMAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMAMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMAMH.FormattingEnabled = true;
            this.cbMAMH.Location = new System.Drawing.Point(199, 111);
            this.cbMAMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMAMH.Name = "cbMAMH";
            this.cbMAMH.Size = new System.Drawing.Size(233, 29);
            this.cbMAMH.TabIndex = 29;
            this.cbMAMH.SelectedIndexChanged += new System.EventHandler(this.cbMAMH_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nhập Thông Tin:";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Location = new System.Drawing.Point(651, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(731, 209);
            this.gridControl2.TabIndex = 23;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView2.DetailHeight = 431;
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "Mã Lớp Tín Chỉ";
            this.gridColumn1.FieldName = "MALTC";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.Caption = "Tên Môn Học";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowFocus = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Giáo Viên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowFocus = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // panelDiemSV
            // 
            this.panelDiemSV.Controls.Add(this.gridControl1);
            this.panelDiemSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiemSV.Location = new System.Drawing.Point(0, 303);
            this.panelDiemSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDiemSV.Name = "panelDiemSV";
            this.panelDiemSV.Size = new System.Drawing.Size(1384, 363);
            this.panelDiemSV.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ShowOnlyPredefinedDetails = true;
            this.gridControl1.Size = new System.Drawing.Size(1384, 363);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MASV,
            this.HOTEN,
            this.DIEM_CC,
            this.DIEM_GK,
            this.DIEM_CK,
            this.DIEMTK});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor_1);
            // 
            // MASV
            // 
            this.MASV.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.MASV.AppearanceCell.Options.UseBackColor = true;
            this.MASV.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MASV.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.MASV.AppearanceHeader.Options.UseBackColor = true;
            this.MASV.AppearanceHeader.Options.UseForeColor = true;
            this.MASV.Caption = "Mã Sinh Viên";
            this.MASV.FieldName = "MASV";
            this.MASV.MinWidth = 23;
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.AllowEdit = false;
            this.MASV.OptionsColumn.AllowFocus = false;
            this.MASV.OptionsColumn.ReadOnly = true;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 0;
            this.MASV.Width = 87;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HOTEN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.HOTEN.AppearanceHeader.Options.UseBackColor = true;
            this.HOTEN.AppearanceHeader.Options.UseForeColor = true;
            this.HOTEN.Caption = "Họ Tên Sinh Viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.MinWidth = 23;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowEdit = false;
            this.HOTEN.OptionsColumn.AllowFocus = false;
            this.HOTEN.OptionsColumn.ReadOnly = true;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            this.HOTEN.Width = 87;
            // 
            // DIEM_CC
            // 
            this.DIEM_CC.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEM_CC.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEM_CC.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM_CC.AppearanceHeader.Options.UseForeColor = true;
            this.DIEM_CC.Caption = "Điểm Chuyên Cần";
            this.DIEM_CC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIEM_CC.FieldName = "DIEM_CC";
            this.DIEM_CC.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DIEM_CC.MinWidth = 23;
            this.DIEM_CC.Name = "DIEM_CC";
            this.DIEM_CC.Visible = true;
            this.DIEM_CC.VisibleIndex = 2;
            this.DIEM_CC.Width = 87;
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEM_GK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEM_GK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM_GK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEM_GK.Caption = "Điểm Giữa Kì";
            this.DIEM_GK.FieldName = "DIEM_GK";
            this.DIEM_GK.MinWidth = 23;
            this.DIEM_GK.Name = "DIEM_GK";
            this.DIEM_GK.Visible = true;
            this.DIEM_GK.VisibleIndex = 3;
            this.DIEM_GK.Width = 87;
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEM_CK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEM_CK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM_CK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEM_CK.Caption = "Điểm Cuối Kì";
            this.DIEM_CK.FieldName = "DIEM_CK";
            this.DIEM_CK.MinWidth = 23;
            this.DIEM_CK.Name = "DIEM_CK";
            this.DIEM_CK.Visible = true;
            this.DIEM_CK.VisibleIndex = 4;
            this.DIEM_CK.Width = 87;
            // 
            // DIEMTK
            // 
            this.DIEMTK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEMTK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEMTK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEMTK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEMTK.Caption = "Điểm Tổng Kết";
            this.DIEMTK.FieldName = "gridColumn4";
            this.DIEMTK.MinWidth = 24;
            this.DIEMTK.Name = "DIEMTK";
            this.DIEMTK.OptionsColumn.AllowEdit = false;
            this.DIEMTK.OptionsColumn.AllowFocus = false;
            this.DIEMTK.OptionsColumn.ReadOnly = true;
            this.DIEMTK.UnboundExpression = "Round([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6, 1)";
            this.DIEMTK.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DIEMTK.Visible = true;
            this.DIEMTK.VisibleIndex = 5;
            this.DIEMTK.Width = 94;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 666);
            this.Controls.Add(this.panelDiemSV);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelChonKhoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panelDiemSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbNHOM;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private System.Windows.Forms.ComboBox cbMAMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Panel panelDiemSV;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTK;
    }
}