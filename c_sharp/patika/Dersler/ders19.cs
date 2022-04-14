using System;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders19
    {
        public static void Run()
        {
            //Söz Dizimi
            //class SinifAdi
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erişim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
            //     {
            //         Metot Komutlari
            //     }
            //}

            //Erisim Belirleyiciler
            // * Public
            // * Private : Sadece tanimlandigi sinif icerisinde erisilebilen (Propertyler)
            // * Internal : Sadece kendi bulundugu proje icerisinde degiskenlere(propertylere) ve siniflara
            // * Protected : Sadece tanimlandigi sinifta veya o siniftan kalitim alan siniflarda

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Serkan";
            calisan1.Soyad = "Özsöz";
            calisan1.No = 2345678;
            calisan1.Departman = "Developer";

            Console.WriteLine("********************");

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2345677;
            calisan2.Departman = "Insan Kaynaklari";

            calisan2.CalisanBilgileri();
        }

    }

    class Calisan
    {
        //Calisani tanimlayanlara propertyler deniliyor.
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}", Ad);
            Console.WriteLine("Calisan Soyadi: {0}", Soyad);
            Console.WriteLine("Calisan Numarasi: {0}", No);
            Console.WriteLine("Calisan Departmani: {0}", Departman);

        }
    }


}