using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace homework1.Homeworks
{
    public class homework3
    {
        public static void Run()
        {
            List<Kisi> KisiListesi = new List<Kisi>()
            {
                new Kisi(){Isim="burak",Soyisim="şentürk",TelefonNo="5356214553"},
                new Kisi(){Isim="selen",Soyisim="yüntem",TelefonNo="5401234567"},
                new Kisi(){Isim="bilal",Soyisim="yılmaz",TelefonNo="5381233885"},
                new Kisi(){Isim="yavuz",Soyisim="yılmaz",TelefonNo="712345678"},
                new Kisi(){Isim="çağla",Soyisim="şentürk",TelefonNo="987654332"},

            };

            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz ");
            System.Console.WriteLine("**************************************** ");

            System.Console.WriteLine("(1) Yeni Numara Kaydetmek ");
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            System.Console.WriteLine("(4) Rehberi Listelemekk");
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");

            Console.Write("işlem yapacağınız sıra:"); int deger = int.Parse(Console.ReadLine());
            switch (deger)
            {

                case 1:
                    TelefonRehberi.NumaraKaydetmek(KisiListesi);
                    break;

                case 2:
                    TelefonRehberi.NumaraSilmek(KisiListesi);
                    break;

                case 3:
                    TelefonRehberi.NumaraGüncelleme(KisiListesi);
                    break;

                case 4:
                    TelefonRehberi.RehberListeleme(KisiListesi);
                    break;

                case 5:
                    TelefonRehberi.RehberdeArama(KisiListesi);
                    break;


            }

            System.Console.WriteLine("Gerçekleştirdiğiniz işlem başarıyla tamamlanmıştır..");
        }

    }

    public class Kisi
    {

        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TelefonNo { get; set; }

    }

    public class TelefonRehberi
    {
        //1)
        public static void NumaraKaydetmek(List<Kisi> KisiListesi)
        {

            System.Console.WriteLine("Lütfen isim giriniz : ");
            string Isim = Console.ReadLine();
            System.Console.WriteLine("Lütfen soyisim giriniz : ");
            string Soyisim = Console.ReadLine();
            System.Console.WriteLine("Lütfen telefon numarası giriniz : ");
            string TelefonNo = Console.ReadLine();
            KisiListesi.Add(new Kisi() { Isim = Isim, Soyisim = Soyisim, TelefonNo = TelefonNo });

            TestDisplay(KisiListesi);
        }


        //2)
        public static void NumaraSilmek(List<Kisi> KisiListesi)
        {
            System.Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string girdi = Console.ReadLine();
            bool KisiKontrol = false;

            foreach (var item in KisiListesi.ToList())
            {
                KisiKontrol = true;
                if (item.Isim == girdi || item.Soyisim == girdi)
                {
                    System.Console.WriteLine("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", item);
                    string YesNo = Console.ReadLine().ToLower();
                    if (YesNo == "y")
                        KisiListesi.Remove(item);
                    else if (YesNo == "n")
                    {
                        System.Console.WriteLine("silme işlemi iptal edildi..");
                        break;
                    }
                    break;

                }
            }
            if (!KisiKontrol)
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                int giren = int.Parse(Console.ReadLine());
                if (giren == 2)
                {
                    NumaraSilmek(KisiListesi);
                }
                if (giren == 1)
                {
                    System.Console.WriteLine("silme işlemi sonlandırılıyor..");

                }

            }

            TestDisplay(KisiListesi);
        }


        //3)
        public static void NumaraGüncelleme(List<Kisi> KisiListesi)
        {
            System.Console.WriteLine("Lütfen numarasını değiştirmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string girdi = Console.ReadLine();
            bool Kisivarmı = false;
            foreach (var item in KisiListesi.ToList())
            {
                if (item.Isim == girdi || item.Soyisim == girdi)
                {
                    Kisivarmı = true;
                    System.Console.WriteLine("{0} isimli kişinin numarası güncellenmek üzere, onaylıyor musunuz ?(y/n)", item.Isim);
                    string YesNo = Console.ReadLine().ToLower();
                    if (YesNo == "y")
                    {
                        System.Console.WriteLine("yeni numarayı giriniz:");
                        string YeniNumara = Console.ReadLine();
                        item.TelefonNo = YeniNumara;
                    }
                    else if (YesNo == "n")
                    {
                        System.Console.WriteLine("güncelleme işlemi iptal edildi..");
                        break;
                    }
                    break;
                }
            }
            if (!Kisivarmı)
            {
                System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                System.Console.WriteLine("* güncellemeyi sonlandırmak için : (1)");
                System.Console.WriteLine("* Yeniden denemek için      : (2)");

                string input = Console.ReadLine();
                if (input == "2")
                {
                    NumaraGüncelleme(KisiListesi);
                }
                if (input == "1")
                {
                    System.Console.WriteLine("Güncelleme işlemi sonlandırılıyor..");

                }
            }
            TestDisplay(KisiListesi);
        }


        //4)
        public static void RehberListeleme(List<Kisi> KisiListesi)
        {
            System.Console.WriteLine("Rehberi A-Z Şeklinde sıralamak istiyorsanız (1)");
            System.Console.WriteLine("Rehberi Z-A Şeklinde sıralamak istiyorsanız (2)");
            string girdi = Console.ReadLine();
            if (girdi == "1")
            {
                System.Console.WriteLine("Telefon Rehberi (A-Z)");
                System.Console.WriteLine("**********************************************");
                var SiraliRehberListesi = KisiListesi.OrderBy(Kisi => Kisi.Isim);
                //                           from Kisi in KisiListesi
                //                           orderby Kisi.Isim
                //                           select Kisi;
                foreach (var Kisi in SiraliRehberListesi)
                {
                    Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon no = {2} \n     - ", Kisi.Isim, Kisi.Soyisim, Kisi.TelefonNo);
                    System.Console.WriteLine(".\n.");
                }
            }
            if (girdi == "2")
            {
                System.Console.WriteLine("Telefon Rehberi (Z-A)");
                System.Console.WriteLine("**********************************************");
                var SiraliRehberListesi = from Kisi in KisiListesi
                                          orderby Kisi.Isim descending
                                          select Kisi;
                foreach (var Kisi in SiraliRehberListesi)
                {

                    Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon no = {2} \n     - ", Kisi.Isim, Kisi.Soyisim, Kisi.TelefonNo);
                    System.Console.WriteLine(".\n.");
                }
            }

        }
        //5)
        public static void RehberdeArama(List<Kisi> KisiListesi)
        {

            System.Console.WriteLine("arama yapmak istediğiniz tipi seçiniz");
            System.Console.WriteLine("**********************************************");
            System.Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine("Telefon numarasına göre arama yapmak için: (2) ");

            int Secsayı = int.Parse(Console.ReadLine());
            if (Secsayı == 1)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait isim veya soyisim giriniz");
                string girilen = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (item.Isim.ToLower() == girilen.ToLower() || item.Soyisim.ToLower() == girilen.ToLower())
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                    }

                }

            }
            else if (Secsayı == 2)
            {
                System.Console.WriteLine("Lütfen Aramak istediğiniz kişiye ait telefon numarası giriniz ");
                string girilenNo = Console.ReadLine();
                foreach (var item in KisiListesi)
                {
                    if (girilenNo == item.TelefonNo)
                    {
                        System.Console.WriteLine("isim: {0}", item.Isim);
                        System.Console.WriteLine("Soyisim: {0}", item.Soyisim);
                        System.Console.WriteLine("Telefon Numarası: {0}", item.TelefonNo);
                        System.Console.WriteLine("    -    ");
                        System.Console.WriteLine(".\n.");

                    }
                }
            }
            else
            {
                System.Console.WriteLine("hatalı seçim..");
            }


        }

        public static void TestDisplay(List<Kisi> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine(" isim= {0} \n soyisim = {1} \n telefon numarası = {2}", item.Isim, item.Soyisim, item.TelefonNo);
            }
        }


    }
}


