using System;
using System.Collections;
using System.Collections.Generic;

namespace homework1.Dersler
{
    public class ders20
    {
        public static void Run()
        {
            Console.WriteLine("********* Calisan 1**********");

            Employee calisan1 = new Employee("Serkan", "Özsöz", 2345678, "Developer");
            calisan1.CalisanBilgileri();

            Console.WriteLine("********* Calisan 2**********");

            Employee calisan2 = new Employee();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2345677;
            calisan2.Departman = "Insan Kaynaklari";

            calisan2.CalisanBilgileri();

            Console.WriteLine("********* Calisan 3**********");
            Employee calisan3 = new Employee("Serkan", "Ozsoz");
            calisan3.CalisanBilgileri();

        }
    }

    class Employee
    {
        //Calisani tanimlayanlara propertyler deniliyor.
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Employee(string ad, string soyad, int no, string departman)
        {
            //overload edilebilir.
            //class ismiyle aynı olmalı.(constructor)
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Employee() { }

        public Employee(string ad, string soyad)
        {
            //overload edilebilir.
            //class ismiyle aynı olmalı.(constructor)
            this.Ad = ad;
            this.Soyad = soyad;  //diğer propları 0 olarak atar.

        }

        //parametre almayan constructor.

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisan Adi: {0}", Ad);
            Console.WriteLine("Calisan Soyadi: {0}", Soyad);
            Console.WriteLine("Calisan Numarasi: {0}", No);
            Console.WriteLine("Calisan Departmani: {0}", Departman);

        }
    }


}