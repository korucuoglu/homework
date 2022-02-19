using System;

namespace homework1.Dersler
{
    public static class ders7
    {
        public static void Run()
        {

            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat");
                    break;
                case 3:
                    System.Console.WriteLine("Mart");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan");
                    break;
                case 5:
                    System.Console.WriteLine("Mayıs");
                    break;
                case 6:
                    System.Console.WriteLine("Haziran");
                    break;
                case 7:
                    System.Console.WriteLine("Temmuz");
                    break;
                case 8:
                    System.Console.WriteLine("Ağustos");
                    break;
                case 9:
                    System.Console.WriteLine("Eylül");
                    break;
                case 10:
                    System.Console.WriteLine("Ekim");
                    break;
                case 11:
                    System.Console.WriteLine("Kasım");
                    break;
                case 12:
                    System.Console.WriteLine("Aralık");
                    break;
            }

        }


    }


}