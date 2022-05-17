
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nHOMLabel;
            this.DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.lOPTINCHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbNHOM = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.cbMAMH = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnBD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTK = new DevExpress.XtraGrid.Columns.GridColumn();
            mAMHLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(61, 94);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(91, 17);
            mAMHLabel.TabIndex = 18;
            mAMHLabel.Text = "Mã Môn Học:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(61, 54);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(75, 17);
            nIENKHOALabel.TabIndex = 19;
            nIENKHOALabel.Text = "Niên Khóa:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(404, 54);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(58, 17);
            hOCKYLabel.TabIndex = 20;
            hOCKYLabel.Text = "Học Kỳ:";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nHOMLabel.Location = new System.Drawing.Point(402, 95);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(47, 17);
            nHOMLabel.TabIndex = 21;
            nHOMLabel.Text = "Nhóm:";
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEM_GK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEM_GK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM_GK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEM_GK.Caption = "Điểm Giữa Kì";
            this.DIEM_GK.FieldName = "DIEM_GK";
            this.DIEM_GK.Name = "DIEM_GK";
            this.DIEM_GK.Visible = true;
            this.DIEM_GK.VisibleIndex = 3;
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
            this.DIEM_CC.Name = "DIEM_CC";
            this.DIEM_CC.Visible = true;
            this.DIEM_CC.VisibleIndex = 2;
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbKhoa);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1186, 73);
            this.panelControl1.TabIndex = 2;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(281, 38);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(337, 25);
            this.cbKhoa.TabIndex = 3;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "KHOA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Điểm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gridControl2);
            this.panelControl2.Controls.Add(nHOMLabel);
            this.panelControl2.Controls.Add(this.cbNHOM);
            this.panelControl2.Controls.Add(hOCKYLabel);
            this.panelControl2.Controls.Add(this.cbHOCKY);
            this.panelControl2.Controls.Add(nIENKHOALabel);
            this.panelControl2.Controls.Add(this.cbNIENKHOA);
            this.panelControl2.Controls.Add(mAMHLabel);
            this.panelControl2.Controls.Add(this.cbMAMH);
            this.panelControl2.Controls.Add(this.button3);
            this.panelControl2.Controls.Add(this.btnCN);
            this.panelControl2.Controls.Add(this.btnBD);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 73);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1186, 173);
            this.panelControl2.TabIndex = 3;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridControl2.Location = new System.Drawing.Point(557, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(627, 169);
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
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn1
            // 
            this.gridColumn1.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn1.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.gridColumn1.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn1.AppearanceHeader.Options.UseForeColor = true;
            this.gridColumn1.Caption = "Mã Lớp Tín Chỉ";
            this.gridColumn1.FieldName = "MALTC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn2.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn2.Caption = "Tên Môn Học";
            this.gridColumn2.FieldName = "TENMH";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.BackColor = System.Drawing.Color.Teal;
            this.gridColumn3.AppearanceHeader.Options.UseBackColor = true;
            this.gridColumn3.Caption = "Giáo Viên";
            this.gridColumn3.FieldName = "HOTEN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // cbNHOM
            // 
            this.cbNHOM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "NHOM", true));
            this.cbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNHOM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNHOM.FormattingEnabled = true;
            this.cbNHOM.Location = new System.Drawing.Point(479, 91);
            this.cbNHOM.Name = "cbNHOM";
            this.cbNHOM.Size = new System.Drawing.Size(200, 25);
            this.cbNHOM.TabIndex = 22;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "HOCKY", true));
            this.cbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHOCKY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.FormattingEnabled = true;
            this.cbHOCKY.Location = new System.Drawing.Point(479, 51);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(200, 25);
            this.cbHOCKY.TabIndex = 21;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "NIENKHOA", true));
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(158, 49);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(200, 25);
            this.cbNIENKHOA.TabIndex = 20;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged);
            // 
            // cbMAMH
            // 
            this.cbMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "MAMH", true));
            this.cbMAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMAMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMAMH.FormattingEnabled = true;
            this.cbMAMH.Location = new System.Drawing.Point(158, 91);
            this.cbMAMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMAMH.Name = "cbMAMH";
            this.cbMAMH.Size = new System.Drawing.Size(200, 25);
            this.cbMAMH.TabIndex = 19;
            this.cbMAMH.SelectedIndexChanged += new System.EventHandler(this.cbMAMH_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(434, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCN
            // 
            this.btnCN.Enabled = false;
            this.btnCN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCN.Location = new System.Drawing.Point(318, 129);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(75, 23);
            this.btnCN.TabIndex = 10;
            this.btnCN.Text = "Cập Nhật";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnBD
            // 
            this.btnBD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(209, 130);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(75, 23);
            this.btnBD.TabIndex = 9;
            this.btnBD.Text = "Bắt Dầu";
            this.btnBD.UseVisualStyleBackColor = true;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập Thông Tin:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 246);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1186, 295);
            this.gridControl1.TabIndex = 4;
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
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
            this.MASV.Name = "MASV";
            this.MASV.OptionsColumn.AllowEdit = false;
            this.MASV.OptionsColumn.ReadOnly = true;
            this.MASV.Visible = true;
            this.MASV.VisibleIndex = 0;
            // 
            // HOTEN
            // 
            this.HOTEN.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HOTEN.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.HOTEN.AppearanceHeader.Options.UseBackColor = true;
            this.HOTEN.AppearanceHeader.Options.UseForeColor = true;
            this.HOTEN.Caption = "Họ Tên Sinh Viên";
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.OptionsColumn.AllowEdit = false;
            this.HOTEN.OptionsColumn.ReadOnly = true;
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEM_CK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEM_CK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEM_CK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEM_CK.Caption = "Điểm Cuối Kì";
            this.DIEM_CK.FieldName = "DIEM_CK";
            this.DIEM_CK.Name = "DIEM_CK";
            this.DIEM_CK.Visible = true;
            this.DIEM_CK.VisibleIndex = 4;
            // 
            // DIEMTK
            // 
            this.DIEMTK.AppearanceHeader.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DIEMTK.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DIEMTK.AppearanceHeader.Options.UseBackColor = true;
            this.DIEMTK.AppearanceHeader.Options.UseForeColor = true;
            this.DIEMTK.Caption = "Điểm Tổng Kết";
            this.DIEMTK.FieldName = "gridColumn4";
            this.DIEMTK.MinWidth = 21;
            this.DIEMTK.Name = "DIEMTK";
            this.DIEMTK.OptionsColumn.AllowEdit = false;
            this.DIEMTK.OptionsColumn.ReadOnly = true;
            this.DIEMTK.UnboundExpression = "Round([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6, 1)";
            this.DIEMTK.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.DIEMTK.Visible = true;
            this.DIEMTK.VisibleIndex = 5;
            this.DIEMTK.Width = 81;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMAMH;
        private System.Windows.Forms.ComboBox cbNHOM;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CK;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn MASV;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTK;
    }
}