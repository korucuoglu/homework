namespace Week2.Console.Homeworks;
using System;

public static class Homework1
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 1, 2, 4, 3, 8, 1, 2, 3, 1, 2, 4, 4, 5, 4, 1, 5, 6, 7, 8, 1 };
        List<int> distinctNumbers = new List<int>();
        foreach (var number in numbers)
        {
            if (!distinctNumbers.Contains(number))
            {
                distinctNumbers.Add(number);
            }
        }

        foreach (var number in distinctNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

