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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool isCorrect;
        public void Login(string _nama, string _password)
        {
            using (var db = new AkunModel())
            {
                var result = from akun in db.Akun where akun.Username == _nama select akun;
                foreach (var item in result)
                {
                    if (_nama == item.Username && _password == item.Password)
                        isCorrect = true;
                    else
                        isCorrect = false;
                }
            }
        }

        public void btnLogin_Click(object sender, EventArgs e)
        {
            Login(tbNama.Text, tbPassword.Text);
            if (isCorrect)
            {
                MessageBox.Show("Login berhasil!");
                Close();
            }
            else
                MessageBox.Show("Akun tidak ditemukan");
        }

        private void lblDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaftarAkunForm daftarAkunForm = new DaftarAkunForm();
            daftarAkunForm.ShowDialog();
        }
    }
}
