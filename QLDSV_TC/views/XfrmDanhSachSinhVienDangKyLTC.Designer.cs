
namespace QLDSV_TC.views
{
    partial class XfrmDanhSachSinhVienDangKyLTC
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
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label mAMHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XfrmDanhSachSinhVienDangKyLTC));
            this.cbNHOM = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.cbMAMH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            nHOMLabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nHOMLabel.Location = new System.Drawing.Point(475, 146);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(56, 21);
            nHOMLabel.TabIndex = 28;
            nHOMLabel.Text = "Nhóm";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(477, 96);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(69, 21);
            hOCKYLabel.TabIndex = 26;
            hOCKYLabel.Text = "Học Kỳ";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(77, 96);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(89, 21);
            nIENKHOALabel.TabIndex = 24;
            nIENKHOALabel.Text = "Niên Khóa";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(77, 146);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(82, 21);
            mAMHLabel.TabIndex = 23;
            mAMHLabel.Text = "Môn Học";
            // 
            // cbNHOM
            // 
            this.cbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNHOM.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNHOM.FormattingEnabled = true;
            this.cbNHOM.Location = new System.Drawing.Point(565, 142);
            this.cbNHOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNHOM.Name = "cbNHOM";
            this.cbNHOM.Size = new System.Drawing.Size(233, 29);
            this.cbNHOM.TabIndex = 30;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHOCKY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.FormattingEnabled = true;
            this.cbHOCKY.Location = new System.Drawing.Point(565, 94);
            this.cbHOCKY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(233, 29);
            this.cbHOCKY.TabIndex = 29;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.Location = new System.Drawing.Point(190, 90);
            this.cbNIENKHOA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(233, 29);
            this.cbNIENKHOA.TabIndex = 27;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged);
            // 
            // cbMAMH
            // 
            this.cbMAMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMAMH.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMAMH.FormattingEnabled = true;
            this.cbMAMH.Location = new System.Drawing.Point(190, 142);
            this.cbMAMH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMAMH.Name = "cbMAMH";
            this.cbMAMH.Size = new System.Drawing.Size(233, 29);
            this.cbMAMH.TabIndex = 25;
            this.cbMAMH.SelectedIndexChanged += new System.EventHandler(this.cbMAMH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "KHOA";
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(334, 28);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(273, 29);
            this.cbKhoa.TabIndex = 33;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.simpleButton4.Location = new System.Drawing.Point(329, 204);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(94, 42);
            this.simpleButton4.TabIndex = 59;
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
            this.simpleButton2.Location = new System.Drawing.Point(456, 204);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 42);
            this.simpleButton2.TabIndex = 58;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // XfrmDanhSachSinhVienDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 260);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(nHOMLabel);
            this.Controls.Add(this.cbNHOM);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(mAMHLabel);
            this.Controls.Add(this.cbMAMH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XfrmDanhSachSinhVienDangKyLTC";
            this.Text = "DSSV Theo Lớp Tín Chỉ";
            this.Load += new System.EventHandler(this.XfrmDanhSachSinhVienDangKyLTC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNHOM;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private System.Windows.Forms.ComboBox cbMAMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKhoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}