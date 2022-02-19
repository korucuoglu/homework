using System;

namespace homework1.Dersler
{
    public static class ders10
    {
        public static void Run()
        {
            int[] sayilar = new int[10];
            sayilar[2] = 12;

            string[] renkler = { "Mavi", "Kırmızı", "Sarı", "Yeşil" };

            int[] sayiDizisi = new int[20];
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                Console.Write("Lütfen {0}. sayıyı girin:", i + 1);
                sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
                toplam += sayiDizisi[i];
            }
            double ortalama = toplam / 20;
            Console.WriteLine("Sayıların ortalaması: " + ortalama);
            Console.ReadLine();

        }
    }
}