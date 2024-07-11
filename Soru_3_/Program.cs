using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı gireceksiniz? ");
            int adet = int.Parse(Console.ReadLine());
            int[] sayilar = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                int girilenSayi;
                bool tekrarlandiMi;

                do
                {
                    Console.Write((i + 1) + ". sayıyı girin: ");
                    girilenSayi = int.Parse(Console.ReadLine());

                    tekrarlandiMi = false;
                    for (int j = 0; j < i; j++) // Girilen sayıyı önceki sayılarla karşılaştır
                    {
                        if (sayilar[j] == girilenSayi)
                        {
                            tekrarlandiMi = true;
                            Console.WriteLine("Bu sayıyı daha önce girdiniz, lütfen başka bir sayı giriniz.");
                            break; // Tekrar bulunduğunda döngüden çık
                        }
                    }
                } while (tekrarlandiMi); // Tekrar eden sayı girildiği sürece döngü devam etsin

                sayilar[i] = girilenSayi;
            }

            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            double ortalama = (double)toplam / adet;

            Console.WriteLine("Sayıların toplamı: " + toplam);
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadKey();
        }
    }
}
