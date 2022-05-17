
namespace QLDSV_TC.views
{
    partial class frmXemDiem
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NKHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1063, 152);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 152);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 392);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NKHK,
            this.MALTC,
            this.TENMH,
            this.DIEM_CC,
            this.DIEM_GK,
            this.DIEM_CK});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NKHK, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // NKHK
            // 
            this.NKHK.Caption = " ";
            this.NKHK.FieldName = "NKHK";
            this.NKHK.MinWidth = 25;
            this.NKHK.Name = "NKHK";
            this.NKHK.OptionsColumn.AllowShowHide = false;
            this.NKHK.Visible = true;
            this.NKHK.VisibleIndex = 0;
            this.NKHK.Width = 94;
            // 
            // MALTC
            // 
            this.MALTC.Caption = "Mã LTC";
            this.MALTC.FieldName = "MALTC";
            this.MALTC.MinWidth = 25;
            this.MALTC.Name = "MALTC";
            this.MALTC.Visible = true;
            this.MALTC.VisibleIndex = 0;
            this.MALTC.Width = 94;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "Tên Môn Học";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.MinWidth = 25;
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 1;
            this.TENMH.Width = 94;
            // 
            // DIEM_CC
            // 
            this.DIEM_CC.Caption = "Điểm CC";
            this.DIEM_CC.FieldName = "DIEM_CC";
            this.DIEM_CC.MinWidth = 25;
            this.DIEM_CC.Name = "DIEM_CC";
            this.DIEM_CC.Visible = true;
            this.DIEM_CC.VisibleIndex = 2;
            this.DIEM_CC.Width = 94;
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.Caption = "Điểm GK";
            this.DIEM_GK.FieldName = "DIEM_GK";
            this.DIEM_GK.MinWidth = 25;
            this.DIEM_GK.Name = "DIEM_GK";
            this.DIEM_GK.Visible = true;
            this.DIEM_GK.VisibleIndex = 3;
            this.DIEM_GK.Width = 94;
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.Caption = "Điểm CK";
            this.DIEM_CK.FieldName = "DIEM_CK";
            this.DIEM_CK.MinWidth = 25;
            this.DIEM_CK.Name = "DIEM_CK";
            this.DIEM_CK.Visible = true;
            this.DIEM_CK.VisibleIndex = 4;
            this.DIEM_CK.Width = 94;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 544);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmXemDiem";
            this.Text = "Xem Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NKHK;
        private DevExpress.XtraGrid.Columns.GridColumn MALTC;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CK;
    }
}