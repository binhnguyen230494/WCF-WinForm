namespace FormBinhPhu
{
    partial class FrmDangNhap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.TxtMatKhau = new System.Windows.Forms.TextBox();
            this.TxtDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnThoat);
            this.groupBox1.Controls.Add(this.BtnDangNhap);
            this.groupBox1.Controls.Add(this.TxtMatKhau);
            this.groupBox1.Controls.Add(this.TxtDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dang Nhap";
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(178, 173);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 3;
            this.BtnThoat.Text = "Thoat";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(41, 173);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.BtnDangNhap.TabIndex = 2;
            this.BtnDangNhap.Text = "Dang Nhap";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // TxtMatKhau
            // 
            this.TxtMatKhau.Location = new System.Drawing.Point(107, 104);
            this.TxtMatKhau.Name = "TxtMatKhau";
            this.TxtMatKhau.PasswordChar = '*';
            this.TxtMatKhau.Size = new System.Drawing.Size(137, 20);
            this.TxtMatKhau.TabIndex = 1;
            // 
            // TxtDangNhap
            // 
            this.TxtDangNhap.Location = new System.Drawing.Point(107, 51);
            this.TxtDangNhap.Name = "TxtDangNhap";
            this.TxtDangNhap.Size = new System.Drawing.Size(137, 20);
            this.TxtDangNhap.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mat khau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten dang nhap";
            // 
            // FrmDangNhap
            // 
            this.AcceptButton = this.BtnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 239);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmDangNhap";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.TextBox TxtMatKhau;
        private System.Windows.Forms.TextBox TxtDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}