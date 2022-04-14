using System;

namespace patika.Homeworks.Homework4.Menu
{
    internal class StartMenu
    {
        public static void List()
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            Console.WriteLine("(5) Çıkış Yapmak");
        }
    }
}