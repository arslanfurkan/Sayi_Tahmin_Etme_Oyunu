using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıBulmacaOyunu163301012
{
    class Kullanici
    {
        public string Kullanici_Adi { get; set; }
        public bool Tekrarli { get; set; }
        public int Hak_Sayisi { get; set; }
        public int Toplam_Hak_Sayisi { get; set; }
        public int Basamak_Sayisi  { get; set; }
        public int Süre { get; set; }
        public int Skor { get; set; }

        public Kullanici(string kullanici_Adi, bool tekrarli, int hak_Sayisi, int basamak_Sayisi)
        {
            Kullanici_Adi = kullanici_Adi;
            Tekrarli = tekrarli;
            Hak_Sayisi = hak_Sayisi;
            Toplam_Hak_Sayisi = hak_Sayisi;
            Basamak_Sayisi = basamak_Sayisi;
            Süre = 20;
        }
        public Kullanici(string kullanici_Adi, int skor)
        {
            Kullanici_Adi = kullanici_Adi;
            Skor = skor;
        }



    }
}
