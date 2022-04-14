using System;
using System.Collections.Generic;
using System.Linq;
using patika.Homeworks.Homework4.Entity;
using patika.Homeworks.Homework4.Menu;

namespace patika.Homeworks.Homework4.Controller
{
    public class KartEkle
    {
        public static void Add(List<Card> listToAdd)
        {
            Console.WriteLine("Eklemek istediğiniz kartın bilgilerini giriniz:");

            Console.Write("Başlık       : ");
            string baslik = Convert.ToString(Console.ReadLine());

            Console.Write("İçerik       : ");
            string icerik = Convert.ToString(Console.ReadLine());

            Console.Write("Atanan Kişi->Charles(1), Carlos(2), Max(3), Lewis(4), Daniel(5)  : ");
            int atananKisiId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Büyüklük Seçiniz->XS(1), S(2), M(3), L(4), XL(5) :");
            Büyüklük secilenBüyüklük = 0;
            //secilenBüyüklük = (Büyüklük)(Convert.ToByte(Console.ReadLine()));
            secilenBüyüklük = (Büyüklük)TryParseIfPossible.FromStringToByte(Console.ReadLine());


            //Kart Ekle
            listToAdd.Add(new Card() { Baslık = baslik, Icerik = icerik, Atanan = AtananKisi.Kisi[atananKisiId], BüyüklükKodu = secilenBüyüklük });

            //Card Check
            Console.WriteLine();
            if (listToAdd.Where(item => item.Baslık == baslik && item.Icerik == icerik).Count() == 1)
            {
                Console.WriteLine("Kart eklendi!");
            }
            else
            {
                Console.WriteLine("Kart Başlığı zaten mevcut!");
                Console.WriteLine("Yeni Kart Eklemek istiyor musunuz? (y/n)");
                if (Convert.ToString(Console.ReadLine()) == "y")
                {
                    Add(listToAdd);
                }
                else
                {
                    Console.WriteLine("Kart ekleme işlemi iptal edildi!");
                }
            }

        }
    }
}