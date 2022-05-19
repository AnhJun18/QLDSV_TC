
namespace QLDSV_TC.views
{
    partial class frmClass
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
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label kHOAHOCLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClass));
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnPH = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.lOPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHOAHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.txtKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtKhoaHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtTenLop = new DevExpress.XtraEditors.TextEdit();
            this.txtMALOP = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelFormSV = new DevExpress.XtraEditors.PanelControl();
            this.gridControlsv = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDANGHIHOC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelbarSV = new System.Windows.Forms.Panel();
            this.btnEditSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnUndoSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSV = new DevExpress.XtraEditors.SimpleButton();
            this.btnADDSV = new DevExpress.XtraEditors.SimpleButton();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem2 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barLargeButtonItem3 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            mAKHOALabel = new System.Windows.Forms.Label();
            kHOAHOCLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormSV)).BeginInit();
            this.panelFormSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panelbarSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAKHOALabel.Location = new System.Drawing.Point(187, 67);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(50, 21);
            mAKHOALabel.TabIndex = 7;
            mAKHOALabel.Text = "Khoa";
            // 
            // kHOAHOCLabel
            // 
            kHOAHOCLabel.AutoSize = true;
            kHOAHOCLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kHOAHOCLabel.Location = new System.Drawing.Point(177, 213);
            kHOAHOCLabel.Name = "kHOAHOCLabel";
            kHOAHOCLabel.Size = new System.Drawing.Size(87, 21);
            kHOAHOCLabel.TabIndex = 5;
            kHOAHOCLabel.Text = "Khóa Học";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.Location = new System.Drawing.Point(177, 165);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(75, 21);
            tENLOPLabel.TabIndex = 3;
            tENLOPLabel.Text = "Tên Lớp";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(177, 118);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(70, 21);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "Mã Lớp";
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.qLDSV_TCDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnPH,
            this.btnGhi,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(293, 146);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPH),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MinHeight = 30;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSua.Enabled = false;
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLargeButtonSua_ItemClick);
            // 
            // btnPH
            // 
            this.btnPH.Caption = "Phục Hồi";
            this.btnPH.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnPH.Enabled = false;
            this.btnPH.Id = 3;
            this.btnPH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPH.ImageOptions.SvgImage")));
            this.btnPH.Name = "btnPH";
            this.btnPH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPH_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1749, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 685);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1749, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 635);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1749, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 635);
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.Controls.Add(this.cbKhoa);
            this.panelChonKhoa.Controls.Add(this.label1);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Enabled = false;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 50);
            this.panelChonKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(1749, 54);
            this.panelChonKhoa.TabIndex = 25;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(630, 16);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(392, 29);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPGridControl
            // 
            this.lOPGridControl.DataSource = this.bdsLOP;
            this.lOPGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lOPGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lOPGridControl.Location = new System.Drawing.Point(0, 104);
            this.lOPGridControl.MainView = this.gridViewLop;
            this.lOPGridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lOPGridControl.MenuManager = this.barManager1;
            this.lOPGridControl.Name = "lOPGridControl";
            this.lOPGridControl.Size = new System.Drawing.Size(1749, 317);
            this.lOPGridControl.TabIndex = 34;
            this.lOPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            // 
            // gridViewLop
            // 
            this.gridViewLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP,
            this.colTENLOP,
            this.colKHOAHOC,
            this.colMAKHOA});
            this.gridViewLop.DetailHeight = 431;
            this.gridViewLop.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewLop.GridControl = this.lOPGridControl;
            this.gridViewLop.Name = "gridViewLop";
            this.gridViewLop.OptionsBehavior.ReadOnly = true;
            this.gridViewLop.RowCountChanged += new System.EventHandler(this.gridViewLop_RowCountChanged);
            // 
            // colMALOP
            // 
            this.colMALOP.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colMALOP.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colMALOP.AppearanceCell.BorderColor = System.Drawing.Color.White;
            this.colMALOP.AppearanceCell.Options.UseBackColor = true;
            this.colMALOP.AppearanceCell.Options.UseBorderColor = true;
            this.colMALOP.AppearanceHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.colMALOP.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP.Caption = "Mã Lớp";
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.MinWidth = 23;
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.OptionsColumn.AllowEdit = false;
            this.colMALOP.OptionsColumn.AllowFocus = false;
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 0;
            this.colMALOP.Width = 87;
            // 
            // colTENLOP
            // 
            this.colTENLOP.AppearanceHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.colTENLOP.AppearanceHeader.Options.UseBackColor = true;
            this.colTENLOP.Caption = "Tên Lớp";
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.MinWidth = 23;
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.OptionsColumn.AllowEdit = false;
            this.colTENLOP.OptionsColumn.AllowFocus = false;
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            this.colTENLOP.Width = 87;
            // 
            // colKHOAHOC
            // 
            this.colKHOAHOC.AppearanceHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.colKHOAHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colKHOAHOC.Caption = "Khóa Học";
            this.colKHOAHOC.FieldName = "KHOAHOC";
            this.colKHOAHOC.MinWidth = 23;
            this.colKHOAHOC.Name = "colKHOAHOC";
            this.colKHOAHOC.OptionsColumn.AllowEdit = false;
            this.colKHOAHOC.OptionsColumn.AllowFocus = false;
            this.colKHOAHOC.Visible = true;
            this.colKHOAHOC.VisibleIndex = 2;
            this.colKHOAHOC.Width = 87;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.AppearanceHeader.BackColor = System.Drawing.Color.MediumTurquoise;
            this.colMAKHOA.AppearanceHeader.Options.UseBackColor = true;
            this.colMAKHOA.Caption = "Khoa";
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 23;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.OptionsColumn.AllowEdit = false;
            this.colMAKHOA.OptionsColumn.AllowFocus = false;
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 3;
            this.colMAKHOA.Width = 87;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(mAKHOALabel);
            this.panelNhapLieu.Controls.Add(this.txtKhoa);
            this.panelNhapLieu.Controls.Add(kHOAHOCLabel);
            this.panelNhapLieu.Controls.Add(this.txtKhoaHoc);
            this.panelNhapLieu.Controls.Add(tENLOPLabel);
            this.panelNhapLieu.Controls.Add(this.txtTenLop);
            this.panelNhapLieu.Controls.Add(mALOPLabel);
            this.panelNhapLieu.Controls.Add(this.txtMALOP);
            this.panelNhapLieu.Controls.Add(this.label2);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieu.Enabled = false;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 421);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(873, 264);
            this.panelNhapLieu.TabIndex = 56;
            // 
            // txtKhoa
            // 
            this.txtKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MAKHOA", true));
            this.txtKhoa.EditValue = "";
            this.txtKhoa.Enabled = false;
            this.txtKhoa.Location = new System.Drawing.Point(285, 63);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhoa.MenuManager = this.barManager1;
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoa.Properties.Appearance.Options.UseFont = true;
            this.txtKhoa.Size = new System.Drawing.Size(288, 28);
            this.txtKhoa.TabIndex = 8;
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "KHOAHOC", true));
            this.txtKhoaHoc.Location = new System.Drawing.Point(285, 209);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKhoaHoc.MenuManager = this.barManager1;
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoaHoc.Properties.Appearance.Options.UseFont = true;
            this.txtKhoaHoc.Properties.Mask.EditMask = "[0-9 -]{9}";
            this.txtKhoaHoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtKhoaHoc.Properties.MaxLength = 9;
            this.txtKhoaHoc.Size = new System.Drawing.Size(288, 28);
            this.txtKhoaHoc.TabIndex = 6;
            // 
            // txtTenLop
            // 
            this.txtTenLop.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "TENLOP", true));
            this.txtTenLop.Location = new System.Drawing.Point(285, 162);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLop.MenuManager = this.barManager1;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLop.Properties.Appearance.Options.UseFont = true;
            this.txtTenLop.Properties.MaxLength = 50;
            this.txtTenLop.Size = new System.Drawing.Size(288, 28);
            this.txtTenLop.TabIndex = 4;
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLOP, "MALOP", true));
            this.txtMALOP.EditValue = "";
            this.txtMALOP.Location = new System.Drawing.Point(285, 109);
            this.txtMALOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMALOP.MenuManager = this.barManager1;
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALOP.Properties.Appearance.Options.UseFont = true;
            this.txtMALOP.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMALOP.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtMALOP.Properties.Mask.BeepOnError = true;
            this.txtMALOP.Properties.Mask.EditMask = "[A-Z0-9 -]{1,10}";
            this.txtMALOP.Properties.Mask.IgnoreMaskBlank = false;
            this.txtMALOP.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMALOP.Properties.Mask.ShowPlaceHolders = false;
            this.txtMALOP.Properties.MaxLength = 10;
            this.txtMALOP.Size = new System.Drawing.Size(288, 28);
            this.txtMALOP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÔNG TIN LỚP HỌC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(721, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 64);
            this.panel1.TabIndex = 12;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(82, 12);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Nam";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chú Thích";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(82, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Nữ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelFormSV
            // 
            this.panelFormSV.Controls.Add(this.gridControlsv);
            this.panelFormSV.Controls.Add(this.panelbarSV);
            this.panelFormSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormSV.Enabled = false;
            this.panelFormSV.Location = new System.Drawing.Point(873, 421);
            this.panelFormSV.Name = "panelFormSV";
            this.panelFormSV.Size = new System.Drawing.Size(876, 264);
            this.panelFormSV.TabIndex = 61;
            // 
            // gridControlsv
            // 
            this.gridControlsv.DataSource = this.bdsSV;
            this.gridControlsv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlsv.Location = new System.Drawing.Point(2, 66);
            this.gridControlsv.MainView = this.gridView2;
            this.gridControlsv.MenuManager = this.barManager1;
            this.gridControlsv.Name = "gridControlsv";
            this.gridControlsv.Size = new System.Drawing.Size(872, 196);
            this.gridControlsv.TabIndex = 58;
            this.gridControlsv.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colMALOP1,
            this.colDANGHIHOC});
            this.gridView2.GridControl = this.gridControlsv;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView2_ShowingEditor);
            this.gridView2.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView2_ValidatingEditor);
            this.gridView2.RowCountChanged += new System.EventHandler(this.gridView2_RowCountChanged);
            // 
            // colMASV
            // 
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 87;
            // 
            // colHO
            // 
            this.colHO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colHO.AppearanceHeader.Options.UseBackColor = true;
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 50;
            // 
            // colTEN
            // 
            this.colTEN.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colTEN.AppearanceHeader.Options.UseBackColor = true;
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 50;
            // 
            // colPHAI
            // 
            this.colPHAI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colPHAI.AppearanceHeader.Options.UseBackColor = true;
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            this.colPHAI.Width = 50;
            // 
            // colDIACHI
            // 
            this.colDIACHI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colDIACHI.AppearanceHeader.Options.UseBackColor = true;
            this.colDIACHI.Caption = "Địa Chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 50;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colNGAYSINH.AppearanceHeader.Options.UseBackColor = true;
            this.colNGAYSINH.Caption = "Ngày Sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 51;
            // 
            // colMALOP1
            // 
            this.colMALOP1.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colMALOP1.AppearanceHeader.Options.UseBackColor = true;
            this.colMALOP1.Caption = "Mã Lớp";
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.MinWidth = 25;
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            this.colMALOP1.Width = 40;
            // 
            // colDANGHIHOC
            // 
            this.colDANGHIHOC.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.colDANGHIHOC.AppearanceHeader.Options.UseBackColor = true;
            this.colDANGHIHOC.Caption = "Nghỉ Học";
            this.colDANGHIHOC.FieldName = "DANGHIHOC";
            this.colDANGHIHOC.MinWidth = 25;
            this.colDANGHIHOC.Name = "colDANGHIHOC";
            this.colDANGHIHOC.Visible = true;
            this.colDANGHIHOC.VisibleIndex = 7;
            this.colDANGHIHOC.Width = 25;
            // 
            // panelbarSV
            // 
            this.panelbarSV.Controls.Add(this.panel1);
            this.panelbarSV.Controls.Add(this.btnEditSV);
            this.panelbarSV.Controls.Add(this.btnUndoSV);
            this.panelbarSV.Controls.Add(this.btnSaveSV);
            this.panelbarSV.Controls.Add(this.btnDeleteSV);
            this.panelbarSV.Controls.Add(this.btnADDSV);
            this.panelbarSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelbarSV.Location = new System.Drawing.Point(2, 2);
            this.panelbarSV.Name = "panelbarSV";
            this.panelbarSV.Size = new System.Drawing.Size(872, 64);
            this.panelbarSV.TabIndex = 0;
            // 
            // btnEditSV
            // 
            this.btnEditSV.Enabled = false;
            this.btnEditSV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditSV.ImageOptions.Image")));
            this.btnEditSV.Location = new System.Drawing.Point(183, 10);
            this.btnEditSV.Name = "btnEditSV";
            this.btnEditSV.Size = new System.Drawing.Size(94, 43);
            this.btnEditSV.TabIndex = 64;
            this.btnEditSV.Text = "Sửa";
            this.btnEditSV.Click += new System.EventHandler(this.btnEditSV_Click);
            // 
            // btnUndoSV
            // 
            this.btnUndoSV.Enabled = false;
            this.btnUndoSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoSV.ImageOptions.SvgImage")));
            this.btnUndoSV.Location = new System.Drawing.Point(430, 12);
            this.btnUndoSV.Name = "btnUndoSV";
            this.btnUndoSV.Size = new System.Drawing.Size(98, 43);
            this.btnUndoSV.TabIndex = 63;
            this.btnUndoSV.Text = "Undo";
            this.btnUndoSV.Click += new System.EventHandler(this.btnUndoSV_Click);
            // 
            // btnSaveSV
            // 
            this.btnSaveSV.Enabled = false;
            this.btnSaveSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveSV.ImageOptions.SvgImage")));
            this.btnSaveSV.Location = new System.Drawing.Point(551, 10);
            this.btnSaveSV.Name = "btnSaveSV";
            this.btnSaveSV.Size = new System.Drawing.Size(94, 43);
            this.btnSaveSV.TabIndex = 62;
            this.btnSaveSV.Text = "Lưu";
            this.btnSaveSV.Click += new System.EventHandler(this.bntSaveSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.Enabled = false;
            this.btnDeleteSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteSV.ImageOptions.SvgImage")));
            this.btnDeleteSV.Location = new System.Drawing.Point(306, 12);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Size = new System.Drawing.Size(94, 43);
            this.btnDeleteSV.TabIndex = 61;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnADDSV
            // 
            this.btnADDSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnADDSV.ImageOptions.SvgImage")));
            this.btnADDSV.Location = new System.Drawing.Point(69, 8);
            this.btnADDSV.Name = "btnADDSV";
            this.btnADDSV.Size = new System.Drawing.Size(94, 47);
            this.btnADDSV.TabIndex = 60;
            this.btnADDSV.Text = "Thêm";
            this.btnADDSV.Click += new System.EventHandler(this.btnADDSV_Click);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Thêm";
            this.barLargeButtonItem1.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barLargeButtonItem1.Id = 0;
            this.barLargeButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonItem1.ImageOptions.SvgImage")));
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barLargeButtonItem2
            // 
            this.barLargeButtonItem2.Caption = "Thêm";
            this.barLargeButtonItem2.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barLargeButtonItem2.Id = 0;
            this.barLargeButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonItem2.ImageOptions.SvgImage")));
            this.barLargeButtonItem2.Name = "barLargeButtonItem2";
            // 
            // barLargeButtonItem3
            // 
            this.barLargeButtonItem3.Caption = "Thêm";
            this.barLargeButtonItem3.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.barLargeButtonItem3.Id = 0;
            this.barLargeButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barLargeButtonItem3.ImageOptions.SvgImage")));
            this.barLargeButtonItem3.Name = "barLargeButtonItem3";
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_CTLTC_SINHVIEN";
            this.bdsDangKy.DataSource = this.bdsSV;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmClass
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1749, 685);
            this.Controls.Add(this.panelFormSV);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.lOPGridControl);
            this.Controls.Add(this.panelChonKhoa);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmClass";
            this.Text = "Lớp Học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKhoaHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALOP.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFormSV)).EndInit();
            this.panelFormSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panelbarSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsLOP;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private QLDSV_TCDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarLargeButtonItem btnThem;
        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarLargeButtonItem btnPH;
        private DevExpress.XtraBars.BarLargeButtonItem btnGhi;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsSV;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colKHOAHOC;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraEditors.PanelControl panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtKhoa;
        private DevExpress.XtraEditors.TextEdit txtKhoaHoc;
        private DevExpress.XtraEditors.TextEdit txtTenLop;
        private DevExpress.XtraEditors.TextEdit txtMALOP;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelFormSV;
        private DevExpress.XtraGrid.GridControl gridControlsv;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colDANGHIHOC;
        private System.Windows.Forms.Panel panelbarSV;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem3;
        private DevExpress.XtraEditors.SimpleButton btnUndoSV;
        private DevExpress.XtraEditors.SimpleButton btnSaveSV;
        private DevExpress.XtraEditors.SimpleButton btnDeleteSV;
        private DevExpress.XtraEditors.SimpleButton btnADDSV;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnEditSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}