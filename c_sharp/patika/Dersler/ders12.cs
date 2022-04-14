using System;

namespace homework1.Dersler
{
    public class ders12
    {
        public static void Run()
        {
            string sayi = "999";


            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                System.Console.WriteLine("Başarılı");
                System.Console.WriteLine(outSayi);
            }
            else
            {
                System.Console.WriteLine("Başarısız!");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            //Metod Aşırı Yükleme - Overloading

            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Zikriye", "Ürkmez");
        }

        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;

            }

            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }

    }


}