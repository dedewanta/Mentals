using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentals
{
    class Mentals
    {
        public string hasil, saran;
        public void Solusi(int skor)
        {
            if (skor <= 5)
            {
                hasil = "Cemas atau Gelisah Ringan";
                saran = "Perbanyak Istirahat\nRajin Olahraga";
            }
            else if (skor <= 10)
            {
                hasil = "Gangguan Kecemasan Sedang";
                saran = "Atur Jam TIdur\nMakan Makanan Bergizi";
            }
            else if (skor <= 16)
            {
                hasil = "Cemas/Gelisah Berlebih atau Depresi Ringan";
                saran = "Kurangi Aktivitas Berat\nJaga Pola Makan\nPerbanyak Aktivitas Positif";
            }
            else if (skor <= 22)
            {
                hasil = "Gangguan Kecemasan Akut atau Depresi Sedang";
                saran = "Konsultasi ke Psikolog\nKurangi Beban Pikiran";
            }
            else
            {
                hasil = "Depresi berat";
                saran = "Segera konsultasi ke psikolog";
            }
        }
    }
}
