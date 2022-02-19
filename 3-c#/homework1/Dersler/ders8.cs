using System;

namespace homework1.Dersler
{
    public static class ders8
    {
        public static void Run()
        {

            System.Console.WriteLine("Sayı Giriniz:");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"Sayı: {n * i}");
            }
        }
    }
}