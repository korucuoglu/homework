using System;

namespace homework1.Dersler
{
    public static class ders8
    {
        public static void Run()
        {

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }

        }
    }
}