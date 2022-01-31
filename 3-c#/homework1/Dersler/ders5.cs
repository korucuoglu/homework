using System;

namespace homework1.Dersler
{
    public static class ders5
    {
        public static void Run()
        {

            System.Console.WriteLine("Sayı giriniz");
            var stringSayi = Console.ReadLine();

            try
            {

                var integerSayi = Convert.ToInt32(stringSayi);

                System.Console.WriteLine($"Girdiğniiz sayı: {integerSayi}");

            }

            catch
            {
                System.Console.WriteLine($"Girdiğiniz değer olan {stringSayi} sayı değildir. Lütfen tekrar deneyin");
            }

            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }




        }


    }


}