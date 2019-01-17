using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulmacaOyunu163301012
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        Kullanici kullanici;
        List<int> rastgeleSayi;
        

        private void buttonKaydetVeOyna_Click(object sender, EventArgs e)
        {
            if (KayıtInputKontrol() && TekrarsizVeUzunlukKontrol())
            {
                kullanici = new Kullanici(textBoxKullaniciAdi.Text, (radioButtonTekrarli.Checked) ? true : false, (int)numericUpDownHakSayisi.Value, (int)numericUpDownBasamakSayisi.Value);

                panelKayit.Hide();
                panelOyun.Show();
                panelBilgilendirme.Show();
                SayıKutulariGizle(kullanici.Basamak_Sayisi, true);
                rastgeleSayi = Sayıİşlemleri.RastgeleSayiUret(kullanici.Tekrarli, kullanici.Basamak_Sayisi);
                timer1.Enabled = true;
                timer1.Start();
               
            }

        }
        //Oyun Click Events
        private void buttonTahminEt_Click(object sender, EventArgs e)
        {
            if (OyunTBKontrol())
            {              
                Karşılastır(rastgeleSayi,kullanici.Basamak_Sayisi);
            }
        }







        // Kontrol Eventleri
        private void textBox_KeyPress_onlyLetters(object sender, KeyPressEventArgs e)
        {

            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void textBox1_KeyPress_onlyNumbers(object sender, KeyPressEventArgs e)
        {
                          e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);         
          
        }
        private void checkBoxSkorlariGoster_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                comboBoxSkorlar.Show();
            
                List<Kullanici> liste = Skorİşlemleri.SkorSırayalıpGetir();
                if (liste.Count != 0)
                {
                    
                    for (int i = 0; i < liste.Count; i++)
                    {
                        comboBoxSkorlar.Items.Add((i + 1) + ". " + liste[i].Kullanici_Adi + "-" + liste[i].Skor + " PUAN");

                    }
                    comboBoxSkorlar.SelectedIndex = 0;
                }
                else
                {
                    Uyarilar.KaydedilmisSkorYok();
                }
            }
            else
            {
                comboBoxSkorlar.Items.Clear();
                comboBoxSkorlar.Hide();
            }
        }


        //Giriş Kontroller
        public bool KayıtInputKontrol()
        {
            if (textBoxKullaniciAdi.Text.Trim() == "")
            {
                Uyarilar.KulAdYok();
                return false;
            }
            return true;
        }

        public bool OyunTBKontrol()
        {
            for (int i = 0; i < kullanici.Basamak_Sayisi; i++)
            {
                TextBox tb = (TextBox)panelOyun.Controls["textBox" + i];

                if (tb.Text.Trim() == "")
                {
                    Uyarilar.SayiGirisEksikyadaYok();
                    return false;
                                    
                }
            }
          return true;
       
        }

        public bool TekrarsizVeUzunlukKontrol()
        {
            if ((int)numericUpDownBasamakSayisi.Value > 9 && radioButtonTekrarsiz.Checked)
            {
                Uyarilar.TekrarsizveRakam();
                return false;
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            labelKalanHak.Text ="Kalan Hakkınız : "+ kullanici.Hak_Sayisi;
            labelKalanSure.Text = "Kalan Süre : " +kullanici.Süre;
            

            if (kullanici.Süre == 0)
            {
                kullanici.Süre = 20;
                kullanici.Hak_Sayisi += -1;
            }
            kullanici.Süre += -1;
            if (kullanici.Hak_Sayisi == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                int[] uretilenSayi = rastgeleSayi.ToArray();
                Array.Reverse(uretilenSayi);
                //tekrarlı daha zor oldugu icin puan getirisi 10x
                kullanici.Skor =  kullanici.Basamak_Sayisi * 10 * (kullanici.Tekrarli ? 10 : 5)-3*kullanici.Toplam_Hak_Sayisi;
                Skorİşlemleri.DosyayaYaz(kullanici);
                DialogResult result = Uyarilar.HakBitti(kullanici.Kullanici_Adi,kullanici.Skor,uretilenSayi);
                if (result == DialogResult.Yes)
                {
                   
                    AyarlariSıfırla();
                }
                else
                {
                    this.Close();

                }
               
            }
           

        }


        //Karşılaştırma Metotları
        public void Karşılastır(List<int> Liste,int basamak)
        {
            bool[] bilinenIndexler = new bool[basamak];
          


            for(int i = 0; i < basamak; i++)
            {
                TextBox ctrlTB = (TextBox)panelOyun.Controls["textBox" + i];

                if (Liste[i] == int.Parse(ctrlTB.Text))
                {
                    ctrlTB.BackColor = Color.Blue;
                    bilinenIndexler[i] = true;
                }
                else
                {
                    if (Liste.Contains(int.Parse(ctrlTB.Text) ))
                    {
                        ctrlTB.BackColor = Color.Red;
                    
                    }
                    else
                    {
                        ctrlTB.BackColor = Color.Yellow;
                    }                  
                }
            }

            KazanmaKontrol(bilinenIndexler);


        }
        public void KazanmaKontrol(bool [] indexler)
        {
            bool kazandi = true;
            for (int i = 0; i < indexler.Length; i++)
            {
                if (indexler[i] == false)
                {
                    kazandi = false;
                }
            }

            if (kazandi)
            {
                timer1.Stop();
                timer1.Enabled = false;
                //tekrarlı daha zor oldugu icin puan getirisi 10x
                kullanici.Skor =  kullanici.Basamak_Sayisi * 10 * (kullanici.Tekrarli?10:5) - 3*kullanici.Toplam_Hak_Sayisi;

                Skorİşlemleri.DosyayaYaz(kullanici);
                DialogResult result = Uyarilar.TebriklerKazandin(kullanici.Kullanici_Adi, kullanici.Skor);
                if (result == DialogResult.Yes)
                {
                    
                    AyarlariSıfırla();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                kullanici.Hak_Sayisi += -1;
                kullanici.Süre = 20;
               
            }

        }



        //Arayüz Düzenlenme
        public void SayıKutulariGizle(int basamak, bool started)
        {
          if(started)
            {
                for (int i = 0; i < basamak; i++)
                {
                    TextBox tb = (TextBox)panelOyun.Controls["textBox" + i];
                    tb.Show();
                }

            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    TextBox tb = (TextBox)panelOyun.Controls["textBox" + i];
                    tb.Hide();
                }
            }
           
        }
       

        public void AyarlariSıfırla()
        {
            SayıKutulariGizle(0, false);
            textBoxKullaniciAdi.Clear();
            panelKayit.Show();
            panelOyun.Hide();
            panelBilgilendirme.Hide();
            kullanici = null;
            rastgeleSayi=null;

        }
    }
}
