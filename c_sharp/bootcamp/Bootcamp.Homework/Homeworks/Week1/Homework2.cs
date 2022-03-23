using System;

namespace Bootcamp.Homework.Homeworks.Week1
{
    public static class Homework2
    {
        public static void Run()
        {
            int counter = 0;
            int n = 10000;

            for (int i = 2; i < n; i++)
            {
                bool prime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    counter++;
                }
            }

            Console.WriteLine($"2 ile {n} arasında {counter} adet asal sayı vardır.");
            Console.ReadLine();



            
          

        }
    }
}
