using System;
using System.Collections.Generic;
using System.Linq;
using patika.Homeworks.Homework4.Entity;

namespace patika.Homeworks.Homework4.Controller
{
    public class KartTası
    {
        public static void Move(List<Card> listToMoveTodo, List<Card> listToMoveInProg, List<Card> listToMoveDone)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");

            string cardTitle = Convert.ToString(Console.ReadLine());


            Console.WriteLine();
            if (listToMoveTodo.Where(ct => ct.Baslık == cardTitle).Count() != 1
                    && listToMoveInProg.Where(ct => ct.Baslık == cardTitle).Count() != 1
                    && listToMoveDone.Where(ct => ct.Baslık == cardTitle).Count() != 1)
            {
                Console.WriteLine("Kart bulunamadı.");
                Console.WriteLine("Yeni Girişyapmak istiyor musunuz? (y/n)");
                if (Convert.ToString(Console.ReadLine()) == "y")
                {
                    Move(listToMoveTodo, listToMoveInProg, listToMoveDone);
                }
                else
                {
                    Console.WriteLine("Kart taşıma işlemi iptal edildi!");
                }
            }
            else
            {
                var bufferCard = new Card();
                var movedFrom = "";

                if (listToMoveTodo.Where(ct => ct.Baslık == cardTitle).Count() == 1)
                {
                    movedFrom = "Todo";
                    TasınacakKart.Kart(listToMoveTodo, cardTitle);

                    bufferCard = new Card()
                    {
                        Baslık = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Baslık,
                        Icerik = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Icerik,
                        Atanan = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Atanan,
                        BüyüklükKodu = listToMoveTodo.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().BüyüklükKodu
                    };

                }
                else if (listToMoveInProg.Where(ct => ct.Baslık == cardTitle).Count() == 1)
                {
                    movedFrom = "InProg";
                    TasınacakKart.Kart(listToMoveInProg, cardTitle);

                    bufferCard = new Card()
                    {
                        Baslık = listToMoveInProg.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Baslık,
                        Icerik = listToMoveInProg.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Icerik,
                        Atanan = listToMoveInProg.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Atanan,
                        BüyüklükKodu = listToMoveInProg.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().BüyüklükKodu
                    };

                }
                else if (listToMoveDone.Where(ct => ct.Baslık == cardTitle).Count() == 1)
                {
                    movedFrom = "Done";
                    TasınacakKart.Kart(listToMoveDone, cardTitle);

                    bufferCard = new Card()
                    {
                        Baslık = listToMoveDone.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Baslık,
                        Icerik = listToMoveDone.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Icerik,
                        Atanan = listToMoveDone.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().Atanan,
                        BüyüklükKodu = listToMoveDone.Where(ct => ct.Baslık == cardTitle).FirstOrDefault().BüyüklükKodu
                    };

                }




                Console.WriteLine("Lütfen Kartı taşımak istediğiniz Line'ı seçiniz:");
                Console.Write("TodoLine(1), InProgressLine(2), DoneLine(3): ");
                int selectedList = Convert.ToInt32(Console.ReadLine());


                switch (selectedList)
                {
                    case 1:
                        Console.WriteLine("Kartınız todo listesine taşınıyor.");
                        if (movedFrom == "InProg")
                            listToMoveInProg.Remove(listToMoveInProg.Where(ct => ct.Baslık == cardTitle).First());
                        if (movedFrom == "Done")
                            listToMoveDone.Remove(listToMoveDone.Where(ct => ct.Baslık == cardTitle).First());
                        listToMoveTodo.Add(bufferCard);

                        break;
                    case 2:
                        Console.WriteLine("Kartınız in progress listesine taşınıyor.");
                        if (movedFrom == "Todo")
                            listToMoveTodo.Remove(listToMoveTodo.Where(ct => ct.Baslık == cardTitle).First());
                        if (movedFrom == "Done")
                            listToMoveDone.Remove(listToMoveDone.Where(ct => ct.Baslık == cardTitle).First());
                        listToMoveInProg.Add(bufferCard);
                        break;
                    case 3:
                        Console.WriteLine("Kartınız done listesine taşınıyor.");
                        if (movedFrom == "InProg")
                            listToMoveInProg.Remove(listToMoveInProg.Where(ct => ct.Baslık == cardTitle).First());
                        if (movedFrom == "Todo")
                            listToMoveTodo.Remove(listToMoveTodo.Where(ct => ct.Baslık == cardTitle).First());
                        listToMoveDone.Add(bufferCard);
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir değer girdiniz.");
                        break;
                }



            }
        }

    }
}