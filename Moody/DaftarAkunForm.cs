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
    public partial class DaftarAkunForm : Form
    {
        Akun akun;
        public enum Mode { Insert, Edit }
        Mode mode;
        public DaftarAkunForm()
        {
            InitializeComponent();
            mode = Mode.Insert;
            btnDaftar.Text = "Daftar";
        }

        public DaftarAkunForm(string nama, int umur, string password, string gender)
        {
            InitializeComponent();
            mode = Mode.Edit;
            akun = new Akun
            {
                Username = nama,
                Umur = umur,
                Password = password,
                Gender = gender,
            };

            tbNama.Text = nama;
            tbUmur.Text = Convert.ToString(umur);

            if (gender == "Laki-laki")
                rbLaki.Checked = true;
            else
                rbPerempuan.Checked = true;

            tbPassword.Text = password;
            tbKonfirmasiPass.Text = password;
            btnDaftar.Text = "Perbarui";
        }

        private void DaftarAkun()
        {
            if (tbNama.Text != "" && tbUmur.Text != "" && tbPassword.Text != "" && tbKonfirmasiPass.Text != "")
            {
                if (tbPassword.Text.Length > 8)
                {
                    if (tbPassword.Text == tbKonfirmasiPass.Text)
                    {
                        using (var db = new AkunModel())
                        {
                            string jenisKelamin;
                            if (rbLaki.Checked)
                                jenisKelamin = "Laki-laki";
                            else
                                jenisKelamin = "Perempuan";

                            Akun newAkun = new Akun
                            {
                                Username = tbNama.Text,
                                Umur = Convert.ToInt32(tbUmur.Text),
                                Gender = jenisKelamin,
                                Password = tbPassword.Text,
                            };
                            db.Akun.Add(newAkun);
                            db.SaveChanges();
                            MessageBox.Show("Akun terdaftar");
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("Password tidak sama");
                }
                else
                    MessageBox.Show("Password harus lebih dari 8 karalter");               
            }
            else
                MessageBox.Show("Data harus diisi lengkap!");
        }

        private void EditAkun()
        {
            using (var db = new AkunModel())
            {
                var result = db.Akun.SingleOrDefault(a => a.Username == akun.Username);
                if (result != null)
                {
                    if (tbNama.Text != "" && tbUmur.Text != "" && tbPassword.Text != "" && tbKonfirmasiPass.Text != "")
                    {
                        if (PasswordCheck(tbPassword.Text, tbKonfirmasiPass.Text))
                        {
                            result.Username = tbNama.Text;
                            result.Umur = Convert.ToInt32(tbUmur.Text);
                            result.Password = tbPassword.Text;

                            if (rbLaki.Checked)
                                result.Gender = "Laki-laki";
                            else
                                result.Gender = "Perempuan";

                            db.SaveChanges();
                            MessageBox.Show("Kontak berhasil diperbarui");
                            Close();
                        }
                    }
                    else
                        MessageBox.Show("Nama, Alamat, dan Nomor Telepon harus diisi");
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool PasswordCheck(string pass1, string pass2)
        {
            if (pass1 == pass2)
                return true;
            else
                return false;
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            if (mode == Mode.Insert)
                DaftarAkun();
            else if (mode == Mode.Edit)
                EditAkun();
        }
    }
}
