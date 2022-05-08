
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
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAMHLabel;
            this.panelChooseKhoa = new DevExpress.XtraEditors.PanelControl();
            this.panelFilter = new DevExpress.XtraEditors.PanelControl();
            this.Khoa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.lOPTINCHIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTINCHITableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.hOCKYSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.nIENKHOATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nHOMSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.mAMHComboBox = new System.Windows.Forms.ComboBox();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelChooseKhoa)).BeginInit();
            this.panelChooseKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFilter)).BeginInit();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChooseKhoa
            // 
            this.panelChooseKhoa.Controls.Add(this.comboBox1);
            this.panelChooseKhoa.Controls.Add(this.Khoa);
            this.panelChooseKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChooseKhoa.Location = new System.Drawing.Point(0, 0);
            this.panelChooseKhoa.Name = "panelChooseKhoa";
            this.panelChooseKhoa.Size = new System.Drawing.Size(1013, 100);
            this.panelChooseKhoa.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(mAMHLabel);
            this.panelFilter.Controls.Add(this.mAMHComboBox);
            this.panelFilter.Controls.Add(nHOMLabel);
            this.panelFilter.Controls.Add(this.nHOMSpinEdit);
            this.panelFilter.Controls.Add(nIENKHOALabel);
            this.panelFilter.Controls.Add(this.nIENKHOATextEdit);
            this.panelFilter.Controls.Add(hOCKYLabel);
            this.panelFilter.Controls.Add(this.hOCKYSpinEdit);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 100);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1013, 142);
            this.panelFilter.TabIndex = 1;
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(260, 37);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(42, 17);
            this.Khoa.TabIndex = 0;
            this.Khoa.Text = "label1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(444, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPTINCHIBindingSource
            // 
            this.lOPTINCHIBindingSource.DataMember = "LOPTINCHI";
            this.lOPTINCHIBindingSource.DataSource = this.qLDSV_TCDataSet;
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
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Location = new System.Drawing.Point(273, 80);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(57, 17);
            hOCKYLabel.TabIndex = 0;
            hOCKYLabel.Text = "HOCKY:";
            // 
            // hOCKYSpinEdit
            // 
            this.hOCKYSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPTINCHIBindingSource, "HOCKY", true));
            this.hOCKYSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.hOCKYSpinEdit.Location = new System.Drawing.Point(336, 77);
            this.hOCKYSpinEdit.Name = "hOCKYSpinEdit";
            this.hOCKYSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hOCKYSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.hOCKYSpinEdit.TabIndex = 1;
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(220, 37);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(78, 17);
            nIENKHOALabel.TabIndex = 2;
            nIENKHOALabel.Text = "NIENKHOA:";
            // 
            // nIENKHOATextEdit
            // 
            this.nIENKHOATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPTINCHIBindingSource, "NIENKHOA", true));
            this.nIENKHOATextEdit.Location = new System.Drawing.Point(304, 34);
            this.nIENKHOATextEdit.Name = "nIENKHOATextEdit";
            this.nIENKHOATextEdit.Size = new System.Drawing.Size(125, 22);
            this.nIENKHOATextEdit.TabIndex = 3;
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(624, 50);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(51, 17);
            nHOMLabel.TabIndex = 4;
            nHOMLabel.Text = "NHOM:";
            // 
            // nHOMSpinEdit
            // 
            this.nHOMSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPTINCHIBindingSource, "NHOM", true));
            this.nHOMSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nHOMSpinEdit.Location = new System.Drawing.Point(681, 47);
            this.nHOMSpinEdit.Name = "nHOMSpinEdit";
            this.nHOMSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nHOMSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.nHOMSpinEdit.TabIndex = 5;
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(625, 100);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(50, 17);
            mAMHLabel.TabIndex = 6;
            mAMHLabel.Text = "MAMH:";
            // 
            // mAMHComboBox
            // 
            this.mAMHComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOPTINCHIBindingSource, "MAMH", true));
            this.mAMHComboBox.FormattingEnabled = true;
            this.mAMHComboBox.Location = new System.Drawing.Point(681, 97);
            this.mAMHComboBox.Name = "mAMHComboBox";
            this.mAMHComboBox.Size = new System.Drawing.Size(121, 24);
            this.mAMHComboBox.TabIndex = 7;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 528);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelChooseKhoa);
            this.Name = "frmNhapDiem";
            this.Text = "frmNhapDiem";
            this.Load += new System.EventHandler(this.frmNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChooseKhoa)).EndInit();
            this.panelChooseKhoa.ResumeLayout(false);
            this.panelChooseKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFilter)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOCKYSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIENKHOATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelChooseKhoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Khoa;
        private DevExpress.XtraEditors.PanelControl panelFilter;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPTINCHIBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mAMHComboBox;
        private DevExpress.XtraEditors.SpinEdit nHOMSpinEdit;
        private DevExpress.XtraEditors.TextEdit nIENKHOATextEdit;
        private DevExpress.XtraEditors.SpinEdit hOCKYSpinEdit;
    }
}