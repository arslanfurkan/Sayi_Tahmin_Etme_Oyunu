using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulmacaOyunu163301012
{
    class Uyarilar
    {
        public static void KulAdYok()
        {
            MessageBox.Show("Lütfen bir kullanıcı adı giriniz!", "Kullanıcı adı girmedin!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void SayiGirisEksikyadaYok()
        {
            MessageBox.Show("Lütfen sayınızı dogru giriniz.", "Eksik giriş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void TekrarsizveRakam()
        {
            MessageBox.Show("Tekrarsız seçeneğinde Basamak Sayisi 9 dan büyük olamaz.", "Bir sıkıntı oluşur.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static DialogResult HakBitti(string kulAdi,int skor,int [] uretilenSayi)
        {
            string sayi = String.Join("", uretilenSayi);
            return MessageBox.Show("Malesef bilemediniz! Sayi " + sayi + " olmalıydı :(\nSkorunuz : "+skor.ToString()+" PUAN\nDevam etmek için Evet'i,Çıkmak için Hayır'ı tıklayınız.", "Sevgili "+kulAdi+",", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static void DosyaBulunamadi()
        {
            MessageBox.Show("Aranan dosya bulunamadi.", "Hay Aksi!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void KaydedilmisSkorYok()
        {
            MessageBox.Show("Henüz kaydedilmiş bir skor bulunamadi!", "Kayıtlı skor yok!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static DialogResult TebriklerKazandin(string kulAdi,int skor)
        {
            return MessageBox.Show("Tebrikler kazandınız!\nSkorunuz : " + skor.ToString() + " PUAN\nEn başa dönmek için Evet'i oyundan çıkmak için Hayır'ı seçiniz!", "Sevgili " + kulAdi + ",", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }


    }
}
