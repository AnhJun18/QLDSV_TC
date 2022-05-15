
namespace QLDSV_TC.views
{
    partial class frmReportHocPhi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInAn = new System.Windows.Forms.Button();
            this.qLDSV_TCDataSet1 = new QLDSV_TC.QLDSV_TCDataSet1();
            this.tbMaLop = new DevExpress.XtraEditors.TextEdit();
            this.cbNIENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.cbHOCKY = new DevExpress.XtraEditors.TextEdit();
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
            nIENKHOALabel.Location = new System.Drawing.Point(144, 155);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(75, 17);
            nIENKHOALabel.TabIndex = 39;
            nIENKHOALabel.Text = "Niên Khóa:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(144, 110);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(59, 17);
            mALOPLabel.TabIndex = 40;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(424, 155);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(58, 17);
            hOCKYLabel.TabIndex = 41;
            hOCKYLabel.Text = "Học Kỳ:";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(887, 54);
            this.panelControl1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nhập Thông Tin Lớp Học:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(406, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInAn
            // 
            this.btnInAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInAn.Location = new System.Drawing.Point(297, 198);
            this.btnInAn.Name = "btnInAn";
            this.btnInAn.Size = new System.Drawing.Size(75, 34);
            this.btnInAn.TabIndex = 35;
            this.btnInAn.Text = "In Ấn";
            this.btnInAn.UseVisualStyleBackColor = false;
            this.btnInAn.Click += new System.EventHandler(this.btnInAn_Click);
            // 
            // qLDSV_TCDataSet1
            // 
            this.qLDSV_TCDataSet1.DataSetName = "QLDSV_TCDataSet1";
            this.qLDSV_TCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbMaLop
            // 
            this.tbMaLop.Location = new System.Drawing.Point(241, 107);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Properties.Appearance.Options.UseFont = true;
            this.tbMaLop.Size = new System.Drawing.Size(400, 24);
            this.tbMaLop.TabIndex = 41;
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.Location = new System.Drawing.Point(241, 153);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.Properties.Appearance.Options.UseFont = true;
            this.cbNIENKHOA.Size = new System.Drawing.Size(175, 24);
            this.cbNIENKHOA.TabIndex = 43;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.Location = new System.Drawing.Point(487, 153);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.Properties.Appearance.Options.UseFont = true;
            this.cbHOCKY.Size = new System.Drawing.Size(154, 24);
            this.cbHOCKY.TabIndex = 44;
            // 
            // frmReportHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 470);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.tbMaLop);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnInAn);
            this.Name = "frmReportHocPhi";
            this.Text = "frmReportHocPhi";
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
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInAn;
        private QLDSV_TCDataSet1 qLDSV_TCDataSet1;
        private DevExpress.XtraEditors.TextEdit tbMaLop;
        private DevExpress.XtraEditors.TextEdit cbNIENKHOA;
        private DevExpress.XtraEditors.TextEdit cbHOCKY;
    }
}