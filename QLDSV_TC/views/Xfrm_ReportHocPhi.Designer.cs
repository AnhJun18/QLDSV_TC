
namespace QLDSV_TC.views
{
    partial class Xfrm_ReportHocPhi
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
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xfrm_ReportHocPhi));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.qLDSV_TCDataSet1 = new QLDSV_TC.QLDSV_TCDataSet1();
            this.tbMaLop = new DevExpress.XtraEditors.TextEdit();
            this.cbNIENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.cbHOCKY = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNIENKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(168, 191);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(93, 21);
            nIENKHOALabel.TabIndex = 39;
            nIENKHOALabel.Text = "Niên Khóa:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(168, 135);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(74, 21);
            mALOPLabel.TabIndex = 40;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(495, 191);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(73, 21);
            hOCKYLabel.TabIndex = 41;
            hOCKYLabel.Text = "Học Kỳ:";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1035, 66);
            this.panelControl1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nhập Thông Tin Lớp Học:";
            // 
            // qLDSV_TCDataSet1
            // 
            this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet1";
            this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMaLop
            // 
            this.tbMaLop.Location = new System.Drawing.Point(281, 132);
            this.tbMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Properties.Appearance.Options.UseFont = true;
            this.tbMaLop.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMaLop.Properties.Mask.EditMask = "[A-Z 0-9 -]{0,10}";
            this.tbMaLop.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbMaLop.Properties.Mask.ShowPlaceHolders = false;
            this.tbMaLop.Size = new System.Drawing.Size(467, 28);
            this.tbMaLop.TabIndex = 41;
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.Location = new System.Drawing.Point(281, 188);
            this.cbNIENKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.Properties.Appearance.Options.UseFont = true;
            this.cbNIENKHOA.Properties.Mask.EditMask = "[0-9 -]{9}";
            this.cbNIENKHOA.Properties.Mask.IgnoreMaskBlank = false;
            this.cbNIENKHOA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cbNIENKHOA.Properties.Mask.ShowPlaceHolders = false;
            this.cbNIENKHOA.Size = new System.Drawing.Size(204, 28);
            this.cbNIENKHOA.TabIndex = 43;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.Location = new System.Drawing.Point(568, 188);
            this.cbHOCKY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.Properties.Appearance.Options.UseFont = true;
            this.cbHOCKY.Properties.Mask.EditMask = "[1-4]";
            this.cbHOCKY.Properties.Mask.IgnoreMaskBlank = false;
            this.cbHOCKY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cbHOCKY.Properties.Mask.ShowPlaceHolders = false;
            this.cbHOCKY.Size = new System.Drawing.Size(180, 28);
            this.cbHOCKY.TabIndex = 44;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(391, 268);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 42);
            this.simpleButton4.TabIndex = 55;
            this.simpleButton4.Text = "In Ấn";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(568, 268);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 42);
            this.simpleButton2.TabIndex = 54;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Xfrm_ReportHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 578);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.tbMaLop);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Xfrm_ReportHocPhi";
            this.Text = "In Học Phí";
            this.Load += new System.EventHandler(this.frmReportHocPhi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNIENKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private QLDSV_TCDataSet1 qLDSV_TCDataSet1;
        private DevExpress.XtraEditors.TextEdit tbMaLop;
        private DevExpress.XtraEditors.TextEdit cbNIENKHOA;
        private DevExpress.XtraEditors.TextEdit cbHOCKY;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}