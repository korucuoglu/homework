using System;

namespace homework1.Dersler
{
    public static class ders6
    {
        public static void Run()
        {

            System.Console.WriteLine("Lütfen yaşınızı giriniz.");
            int yas = int.Parse(Console.ReadLine());

            string sonuc = yas >= 18 ? "Ehliyet Alabilirsiniz" : "Ehliyet alamazsınız";

            System.Console.WriteLine(sonuc);
            System.Console.ReadLine();

        }


    }


}