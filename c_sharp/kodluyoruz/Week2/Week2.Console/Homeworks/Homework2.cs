namespace Week2.Console.Homeworks;
using System;

public static class Homework2
{
    public static void Run()
    {

        string word = "nar";
        int deserveNumber = 5;
        char[] takePlace = new char[word.Length];
        string result = "";

        for (int i = 0; i < word.Length; i++)
        {
            takePlace[i] = '-';
            result += "-";
        }
        Console.WriteLine(result);

        while (true)
        {

            Console.WriteLine("Kalan Hak:{0}", deserveNumber);
            Console.Write("Bir harf girin   :");
            char character = Convert.ToChar(Console.ReadLine());

            bool flag = false;
            int available = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    takePlace[i] = character;
                    flag = true;
                }
                if (takePlace[i] == '-')
                {
                    available++;
                }
                Console.Write(takePlace[i]);
            }
            Console.WriteLine();

            if (available == 0)
            {
                Console.WriteLine("Tebrikler kazandınız!...");
                break;
            }

            if (flag)
            {
                deserveNumber--;
            }

            if (deserveNumber == 0)
            {
                Console.WriteLine("Üzgünüm kaybettiniz!.");
                break;
            }

            Console.WriteLine("******************");
        }

        Console.Write("Seçilen kelime:  <<{0}>>         ", (word));
        Console.ReadLine();
    }

}

