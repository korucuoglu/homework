using System;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders16
    {
        public static void Run()
        {
            //List<T> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);

            //foreach ve List.ForEach ile ekranlara erişim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));


            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içerisinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu!");
            }

            //Eleman ile index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List'e çevirme

            string[] hayvanlar = { "kedi", "köpek", "kuş" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //listeyi nasıl temizleriz

            hayvanListesi.Clear();

            //List içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Serkan";
            kullanıcı1.Soyisim = "Özsöz";
            kullanıcı1.Yas = 27;

            kullanıcıListesi.Add(kullanıcı1);

            Kullanıcılar kullanıcı2 = new Kullanıcılar();

            kullanıcı2.Isim = "Mert";
            kullanıcı2.Soyisim = "Akçay";
            kullanıcı2.Yas = 22;

            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24

            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanici Adi: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yasi: " + kullanıcı.Yas);
            }

            yeniListe.Clear();


        }

    }

    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }


    }


}