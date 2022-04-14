using System;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders18
    {
        public static void Run()
        {
            //array elemanlarına değer, onların indexlerine anahtar(key) gibi düşünülebilir.

            //system.collections.generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Serkan Özsöz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("**** Elemanlara Erişim ****");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count;
            Console.WriteLine(kullanicilar.Count);

            //Contains;
            Console.WriteLine("**** Contains ****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Serkan Özsöz"));

            //Remove
            Console.WriteLine("**** Remove ****");

            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);

            //Keys
            Console.WriteLine("**** Keys ****");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);

            //Values
            Console.WriteLine("**** Values ****");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);

        }

    }


}