using System;

namespace homework1.Dersler
{
    public static class ders4
    {
        public static void Run()
        {

            // Implicit Conversion

            float a;
            int b = 25;
            a = b;

            System.Console.WriteLine(a); // burada biz çapa harcamadan otomatik olarak dönüşüm gerçekleşti. Çünkü float, integeri kapsamaktadır. 

            // Explicit Conversion

            var StringSayi = "15";

            var integerSayi = Convert.ToInt32(StringSayi);

            System.Console.WriteLine($"string formatından dönüştürülmüş sayı: {integerSayi}");


        }


    }


}