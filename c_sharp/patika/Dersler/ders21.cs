using System;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders21
    {
        public static void Run()
        {

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Ad = "Serkan";
            ogrenci.Soyad = "Özsöz";
            ogrenci.OgrenciNo = 12345;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();

        }


    }

    class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int sinif;

        public string Ad
        {
            get => ad; //get {return ad;}
            set => ad = value; //set{ ad = value;}
        }
        public string Soyad { get => soyad; set => soyad = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sinif En Az 1 Olmalı!");
                    sinif = 1;
                }
                else
                    sinif = value;
            }
        }

        public Ogrenci(string ad, string soyad, int ogrenciNo, int sinif)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci()
        {

        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("**** Ogrenci Bilgileri ****");
            Console.WriteLine("Ogrenci Adi     : {0}", this.Ad);
            Console.WriteLine("Ogrenci Soyadi     : {0}", this.Soyad);
            Console.WriteLine("Ogrenci Ogrenci No     : {0}", this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi     : {0}", this.Sinif);

        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }

    }
}