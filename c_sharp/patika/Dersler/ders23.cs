using System;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders22
    {
        public static void Run()
        {

            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 3;
            dikdortgen.uzunKenar = 4;
            Console.WriteLine("Class Dikdörtgen Alanı {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_Struct = new Dikdortgen_Struct();
            dikdortgen_Struct.kisaKenar = 3;
            dikdortgen_Struct.uzunKenar = 4;
            Console.WriteLine("Struct Dikdörtgen Alanı {0}", dikdortgen_Struct.AlanHesapla());
        }


    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen_Struct(int KisaKenar, int UzunKenar)
        {
            uzunKenar = UzunKenar;
            kisaKenar = KisaKenar;
        }
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }


}