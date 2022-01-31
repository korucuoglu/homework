using System;

namespace homework1.Dersler
{
    public static class ders3
    {
        public static void Run()
        {

            int a = 5;
            int b = 10;

            if (b > a)
            {
                System.Console.WriteLine($"{b} sayısı {a} sayısından büyük");
            }

            if (b % 5 == 0)
            {
                System.Console.WriteLine($"{b} sayısı {5} sayısına tam olarak bölünebiliyor.");
            }

            System.Console.WriteLine($"{b} sayısı ile {a} sayısının çarpımı {a * b} etmektedir.");
            System.Console.WriteLine($"{b} sayısının {a} sayısına bölümü {b / a} etmektedir.");


        }


    }


}