using System;
using System.Collections.Generic;
using System.Linq;
using patika.Homeworks.Homework4.Entity;

namespace patika.Homeworks.Homework4.Controller
{
    public class KartSil
    {
        public static void Delete(List<Card> listToDelete)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");

            string cardTitle = Convert.ToString(Console.ReadLine());


            Console.WriteLine();
            if (listToDelete.Where(ct => ct.Baslık == cardTitle).Count() == 1)
            {
                listToDelete.Remove(listToDelete.Where(ct => ct.Baslık == cardTitle).First());
                Console.WriteLine("Kart başarıyla silindi.");
            }
            else
            {
                Console.WriteLine("Kart bulunamadı.");
                Console.WriteLine("Yeni Girişyapmak istiyor musunuz? (y/n)");
                if (Convert.ToString(Console.ReadLine()) == "y")
                {
                    Delete(listToDelete);
                }
                else
                {
                    Console.WriteLine("Kart silme işlemi iptal edildi!");
                }

            }
        }
    }
}