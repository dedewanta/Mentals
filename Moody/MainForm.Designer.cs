namespace Mentals
{
    partial class MainForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUmur = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCekKondisi = new System.Windows.Forms.Button();
            this.lblSaran = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblKet2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hapusAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPsikolog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(87, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 26);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "(UserName)";
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmur.Location = new System.Drawing.Point(34, 164);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(44, 15);
            this.lblUmur.TabIndex = 2;
            this.lblUmur.Text = "(umur)";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(33, 205);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 15);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "(gender)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasil Diagnosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Umur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Jenis Kelamin :";
            // 
            // btnCekKondisi
            // 
            this.btnCekKondisi.Enabled = false;
            this.btnCekKondisi.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCekKondisi.Location = new System.Drawing.Point(35, 235);
            this.btnCekKondisi.Name = "btnCekKondisi";
            this.btnCekKondisi.Size = new System.Drawing.Size(170, 29);
            this.btnCekKondisi.TabIndex = 9;
            this.btnCekKondisi.Text = "Cek Kondisi";
            this.btnCekKondisi.UseVisualStyleBackColor = true;
            this.btnCekKondisi.Click += new System.EventHandler(this.btnCekKondisi_Click);
            // 
            // lblSaran
            // 
            this.lblSaran.AutoSize = true;
            this.lblSaran.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblSaran.Location = new System.Drawing.Point(246, 206);
            this.lblSaran.Name = "lblSaran";
            this.lblSaran.Size = new System.Drawing.Size(11, 15);
            this.lblSaran.TabIndex = 18;
            this.lblSaran.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(246, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Saran:";
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.Location = new System.Drawing.Point(295, 156);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(11, 15);
            this.lblKeterangan.TabIndex = 16;
            this.lblKeterangan.Text = "-";
            // 
            // lblKet2
            // 
            this.lblKet2.AutoSize = true;
            this.lblKet2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblKet2.Location = new System.Drawing.Point(246, 136);
            this.lblKet2.Name = "lblKet2";
            this.lblKet2.Size = new System.Drawing.Size(35, 15);
            this.lblKet2.TabIndex = 15;
            this.lblKet2.Text = "Skor:";
            this.lblKet2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.akunToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountProfileToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.hapusAccountToolStripMenuItem});
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.akunToolStripMenuItem.Text = "Account";
            // 
            // viewAccountProfileToolStripMenuItem
            // 
            this.viewAccountProfileToolStripMenuItem.Name = "viewAccountProfileToolStripMenuItem";
            this.viewAccountProfileToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewAccountProfileToolStripMenuItem.Text = "View Account Profile";
            this.viewAccountProfileToolStripMenuItem.Click += new System.EventHandler(this.viewAccountProfileToolStripMenuItem_Click);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editAccountToolStripMenuItem.Text = "Edit Account";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // hapusAccountToolStripMenuItem
            // 
            this.hapusAccountToolStripMenuItem.Name = "hapusAccountToolStripMenuItem";
            this.hapusAccountToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.hapusAccountToolStripMenuItem.Text = "Delete Account";
            this.hapusAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // btnPsikolog
            // 
            this.btnPsikolog.Enabled = false;
            this.btnPsikolog.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPsikolog.Location = new System.Drawing.Point(35, 295);
            this.btnPsikolog.Name = "btnPsikolog";
            this.btnPsikolog.Size = new System.Drawing.Size(170, 23);
            this.btnPsikolog.TabIndex = 22;
            this.btnPsikolog.Text = "Hubungi Psikolog";
            this.btnPsikolog.UseVisualStyleBackColor = true;
            this.btnPsikolog.Click += new System.EventHandler(this.btnPsikolog_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Butuh Psikolog?";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(63, 121);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(10, 13);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "-";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(249, 295);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(227, 23);
            this.btnSimpan.TabIndex = 25;
            this.btnSimpan.Text = "Simpan Hasil";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 51);
            this.label2.TabIndex = 27;
            this.label2.Text = "Mentals";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(344, 39);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(150, 38);
            this.lblLogin.TabIndex = 28;
            this.lblLogin.Text = "Welcome to Mentals\r\nPlease";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(419, 59);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 29;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 30;
            this.label8.Text = "Halo, ";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkor.Location = new System.Drawing.Point(247, 156);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(14, 19);
            this.lblSkor.TabIndex = 31;
            this.lblSkor.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(520, 339);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPsikolog);
            this.Controls.Add(this.lblSaran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblKet2);
            this.Controls.Add(this.btnCekKondisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblUmur);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Moody";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCekKondisi;
        private System.Windows.Forms.Label lblSaran;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblKet2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hapusAccountToolStripMenuItem;
        private System.Windows.Forms.Button btnPsikolog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Button btnSimpan;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Label lblUmur;
        public System.Windows.Forms.Label lblGender;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem viewAccountProfileToolStripMenuItem;
        public System.Windows.Forms.Label lblSkor;
    }
}