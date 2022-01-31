using System;

namespace homework1.Dersler
{
    public static class ders2
    {
        public static void Run()
        {
            var sayi1 = "20";
            var sayi2 = "30";

            var stringToplam = sayi1 + sayi2;

            var intToplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);

            System.Console.WriteLine(intToplam);


        }


    }


}