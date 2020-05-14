using Moody;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mentals
{
    public partial class MainForm : Form
    {
        LoginForm loginForm = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCekKondisi_Click(object sender, EventArgs e)
        {
            Kuisioner kuisioner = new Kuisioner();
            kuisioner.ShowDialog();
            lblSkor.Text = Convert.ToString(kuisioner.totalSkor);

            Mentals mentals = new Mentals();
            mentals.Solusi(Convert.ToInt32(kuisioner.totalSkor));
            lblKeterangan.Text = mentals.hasil;
            lblSaran.Text = mentals.saran;
            btnSimpan.Enabled = true;

        }

        private void btnPsikolog_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Psikolog telah dihubungi");
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new AkunModel())
            {
                var query = from akun in db.Akun where akun.Username == lblUsername.Text select akun;
                foreach (var item in query)
                {
                    DaftarAkunForm daftarAkunForm = new DaftarAkunForm(item.Username, item.Umur, item.Password, item.Gender);
                    daftarAkunForm.ShowDialog();

                    lblUsername.Text = daftarAkunForm.tbNama.Text;
                    lblUmur.Text = daftarAkunForm.tbUmur.Text + " tahun";
                    if (daftarAkunForm.rbLaki.Checked)
                        lblGender.Text = "Laki-laki";
                    else
                        lblGender.Text = "Perempuan";
                    btnCekKondisi.Enabled = true;
                }
            }
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new AkunModel())
            {
                db.Akun.RemoveRange(db.Akun.Where(item => item.Username == lblUsername.Text));
                db.SaveChanges();
                lblUsername.Text = "(UserName)";
                lblGender.Text = "-";
                lblUmur.Text = "-";
                btnCekKondisi.Enabled = false;
                btnPsikolog.Enabled = false;
                btnLogin.Visible = true;
                lblLogin.Visible = true;
            }
            loginForm.isCorrect = false;
            MessageBox.Show("Akun Telah Dihapus");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Metals by Dikas Dendew Dori\nCopyleft 2020");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            using (var db = new AkunModel())
            {
                var result = db.Akun.SingleOrDefault(a => a.Username == lblUsername.Text);
                if (result != null)
                {
                    result.Poin = int.Parse(lblSkor.Text);
                    result.Kondisi = lblKeterangan.Text;
                    db.SaveChanges();
                    MessageBox.Show("Data tersimpan!");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();
            using (var db = new AkunModel())
            {
                var result = db.Akun.SingleOrDefault(a => a.Username == loginForm.tbNama.Text);
                if (loginForm.isCorrect)
                {
                    lblUsername.Text = result.Username;
                    lblUmur.Text = result.Umur + " tahun";
                    lblGender.Text = result.Gender;
                    btnCekKondisi.Enabled = true;
                    lblLogin.Visible = false;
                    btnLogin.Visible = false;
                }
            }
        }

        private void viewAccountProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new AkunModel())
            {
                var result = db.Akun.SingleOrDefault(a => a.Username == lblUsername.Text);
                if (result != null)
                {
                    ProfilAkun profilAkun = new ProfilAkun(result.Username, result.Umur, result.Gender, result.Kondisi);
                    profilAkun.ShowDialog();
                }
            }
        }
    }
}