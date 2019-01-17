using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayıBulmacaOyunu163301012
{
    class Sayıİşlemleri
    {


        public static List<int> RastgeleSayiUret(bool tekrarli,int basamak_Sayisi)
        {
            int rakam;
            List<int> sayilar = new List<int>();

            Random rn = new Random();
            if (!tekrarli)
            {
                for(int i = 1; i <= basamak_Sayisi; i++)
                {
         
                    if (i == basamak_Sayisi)
                    {
                        rakam = rn.Next(1, 10);
                        if (sayilar.Contains(rakam))
                        {
                            i--;
                            continue;
                        }
                        sayilar.Add(rakam);

                    }
                    else
                    {
                        rakam = rn.Next(0, 10);
                        if (sayilar.Contains(rakam))
                        {
                            i--;
                            continue;
                        }
                        sayilar.Add(rakam);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= basamak_Sayisi; i++)
                {
           
                    if (i == basamak_Sayisi)
                    {
                        rakam = rn.Next(1, 10);
                        sayilar.Add(rakam);
                    }
                    else
                    {
                        rakam = rn.Next(0, 10);                       
                        sayilar.Add(rakam);
                    }
                }             
            }
            return sayilar;


        }



    }
}
