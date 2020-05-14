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
    public partial class Kuisioner : Form
    {
        public string hasil, saran;
        public int totalSkor;
        public Kuisioner()
        {
            InitializeComponent();
        }

        public void Deteksi()
        {
            int Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9;
            Q1 = int.Parse(tbD1.Text);
            Q2 = int.Parse(tbD2.Text);
            Q3 = int.Parse(tbD3.Text);
            Q4 = int.Parse(tbD4.Text);
            Q5 = int.Parse(tbD5.Text);
            Q6 = int.Parse(tbD6.Text);
            Q7 = int.Parse(tbD7.Text);
            Q8 = int.Parse(tbD8.Text);
            Q9 = int.Parse(tbD9.Text);
            totalSkor = Q1 + Q2 + Q3 + Q4 + Q5 + Q6 + Q7 + Q8 + Q9;

            if (totalSkor < 0 || totalSkor > 27)
                MessageBox.Show("Pastikan Anda mengikuti petunjuk dengaan mengisi angka 0-3.");
            else
                MessageBox.Show("Selesai!");
        }

        private void tbDeteksi_Click(object sender, EventArgs e)
        {
            Deteksi();
        }
    }
}
