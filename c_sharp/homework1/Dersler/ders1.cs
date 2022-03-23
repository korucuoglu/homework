using System;

namespace homework1.Dersler
{
    public static class ders1
    {
        public static void Run()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsim Gir!");
            string name = Console.ReadLine();
            System.Console.WriteLine("Soyadınızı Girin");
            string surname = Console.ReadLine();

            System.Console.WriteLine($"Merhaba {name} {surname}");

        }


    }


}