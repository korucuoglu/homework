using System;

namespace Kodluyoruz.Homework.Homeworks.Week1
{
    public static class Homework3
    {
        public static void Run()
        {
            /*
             * 2'den n'e kadar kaç tane asal sayının olduğunu gösteren algoritma
            */

            bool prime = true;
            Console.Write("Sayıyı Girin : ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.WriteLine("Girilen Sayı Asal");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Asal Değil");
            }
            Console.ReadLine();

        }
    }
}
