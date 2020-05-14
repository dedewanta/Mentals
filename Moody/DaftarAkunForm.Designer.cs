namespace Mentals
{
    partial class DaftarAkunForm
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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUmur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.tbKonfirmasiPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(128, 170);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(149, 20);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(128, 90);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(149, 20);
            this.tbNama.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password                  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username                 :";
            // 
            // tbUmur
            // 
            this.tbUmur.Location = new System.Drawing.Point(128, 116);
            this.tbUmur.Name = "tbUmur";
            this.tbUmur.Size = new System.Drawing.Size(149, 20);
            this.tbUmur.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Jenis Kelamin            :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Umur                         :";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Checked = true;
            this.rbLaki.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbLaki.Location = new System.Drawing.Point(128, 147);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(64, 17);
            this.rbLaki.TabIndex = 11;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(198, 147);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(79, 17);
            this.rbPerempuan.TabIndex = 12;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnDaftar
            // 
            this.btnDaftar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(52, 236);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(75, 23);
            this.btnDaftar.TabIndex = 13;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(161, 236);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // tbKonfirmasiPass
            // 
            this.tbKonfirmasiPass.Location = new System.Drawing.Point(128, 196);
            this.tbKonfirmasiPass.Name = "tbKonfirmasiPass";
            this.tbKonfirmasiPass.Size = new System.Drawing.Size(149, 20);
            this.tbKonfirmasiPass.TabIndex = 16;
            this.tbKonfirmasiPass.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Konfirmasi Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Welcome to Mentals | Mentals";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 51);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mentals";
            // 
            // DaftarAkunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(293, 288);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbKonfirmasiPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.rbPerempuan);
            this.Controls.Add(this.rbLaki);
            this.Controls.Add(this.tbUmur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DaftarAkunForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbPassword;
        public System.Windows.Forms.TextBox tbNama;
        public System.Windows.Forms.TextBox tbUmur;
        public System.Windows.Forms.TextBox tbKonfirmasiPass;
        public System.Windows.Forms.RadioButton rbLaki;
        public System.Windows.Forms.RadioButton rbPerempuan;
    }
}