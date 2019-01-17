using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SayıBulmacaOyunu163301012
{
    class Skorİşlemleri
    {
        public static void DosyayaYaz(Kullanici kullanici)
        {
            FileStream file = new FileStream(@"skorlar.txt", FileMode.Append, FileAccess.Write);
            StreamWriter yaz = new StreamWriter(file, Encoding.GetEncoding("iso-8859-9"));

            yaz.WriteLine(kullanici.Kullanici_Adi + "-" + kullanici.Skor.ToString());

            yaz.Close();
            file.Close();


        }



        public static Kullanici[] DosyayadanOku()
        {
            if (File.Exists(@"skorlar.txt"))
            {
                Kullanici [] kullanicilar = null;
                int kullaniciAdeti = 0;

                FileStream dosya = new FileStream(@"skorlar.txt", FileMode.Open, FileAccess.Read);
                StreamReader oku = new StreamReader(dosya, Encoding.GetEncoding("iso-8859-9"));

                var pos = dosya.Position;


                while (oku.ReadLine() != null)
                {
                    kullaniciAdeti++;
                }
                dosya.Seek(pos, SeekOrigin.Begin);

                kullanicilar = new Kullanici[kullaniciAdeti];

                int i = 0;
                while (i < kullaniciAdeti)
                {
                    String[] tut = oku.ReadLine().Split('-');

                    kullanicilar[i] = new Kullanici(tut[0],int.Parse(tut[1]) ) ;

                    i++;
                }
                dosya.Close();
                oku.Close();
                return kullanicilar;
            }
            else
            {
                Uyarilar.DosyaBulunamadi();
                return null;
            }

        }


        public static List<Kullanici> SkorSırayalıpGetir()
        {
            List<Kullanici> oyuncularListe = new List<Kullanici>();
            Kullanici[] oyuncular = DosyayadanOku();

            if (oyuncular != null)
            {
                for (int i = 0; i < oyuncular.Length; i++)
                {
                    oyuncularListe.Add(oyuncular[i]);
                }

                oyuncularListe = oyuncularListe.OrderByDescending(x => x.Skor).ToList();

            }



            return oyuncularListe;
        }

    }
}
