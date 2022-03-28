using System;

namespace homework1.Dersler
{
    public static class ders9
    {
        public static void Run()
        {
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in sayiDizisi)
            {
                toplam += i;
            }

            System.Console.WriteLine($"toplam sayo {toplam}");

        }
    }
}