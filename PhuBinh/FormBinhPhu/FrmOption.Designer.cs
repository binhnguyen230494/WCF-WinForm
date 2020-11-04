namespace FormBinhPhu
{
    partial class FrmOption
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
            this.BtnAccount = new System.Windows.Forms.Button();
            this.BtnOption = new System.Windows.Forms.Button();
            this.BtnVote = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnThoat = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtrole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAccount
            // 
            this.BtnAccount.Location = new System.Drawing.Point(14, 13);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(100, 32);
            this.BtnAccount.TabIndex = 11;
            this.BtnAccount.Text = "Account";
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // BtnOption
            // 
            this.BtnOption.Location = new System.Drawing.Point(141, 12);
            this.BtnOption.Name = "BtnOption";
            this.BtnOption.Size = new System.Drawing.Size(100, 32);
            this.BtnOption.TabIndex = 12;
            this.BtnOption.Text = "Option";
            this.BtnOption.UseVisualStyleBackColor = true;
            this.BtnOption.Click += new System.EventHandler(this.BtnOption_Click);
            // 
            // BtnVote
            // 
            this.BtnVote.Location = new System.Drawing.Point(263, 13);
            this.BtnVote.Name = "BtnVote";
            this.BtnVote.Size = new System.Drawing.Size(100, 32);
            this.BtnVote.TabIndex = 13;
            this.BtnVote.Text = "Vote";
            this.BtnVote.UseVisualStyleBackColor = true;
            this.BtnVote.Click += new System.EventHandler(this.BtnVote_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(426, 62);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(75, 23);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "Add";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(426, 124);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(75, 23);
            this.BtnSua.TabIndex = 4;
            this.BtnSua.Text = "Edit";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(426, 181);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(75, 23);
            this.BtnXoa.TabIndex = 5;
            this.BtnXoa.Text = "Delete";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 344);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(426, 287);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 6;
            this.BtnThoat.Text = "Exit";
            this.BtnThoat.UseVisualStyleBackColor = true;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(301, 69);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(70, 117);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(70, 69);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            // 
            // txtrole
            // 
            this.txtrole.Location = new System.Drawing.Point(301, 116);
            this.txtrole.Name = "txtrole";
            this.txtrole.Size = new System.Drawing.Size(100, 20);
            this.txtrole.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Id  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pass  :";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(206, 72);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(0, 13);
            this.LblCode.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Role  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name   :";
            // 
            // FrmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrole);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnVote);
            this.Controls.Add(this.BtnOption);
            this.Controls.Add(this.BtnAccount);
            this.Name = "FrmOption";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOption_FormClosed);
            this.Load += new System.EventHandler(this.FrmOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Button BtnOption;
        private System.Windows.Forms.Button BtnVote;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnThoat;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtrole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}