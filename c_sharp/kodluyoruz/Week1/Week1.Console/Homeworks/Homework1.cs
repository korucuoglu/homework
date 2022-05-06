namespace Week1.Console.Homeworks;
using System;

public static class Homework1
{
    public static void Run()
    {
        /*
         * Ödev-1
            Console üzerinden girilen ilk sayının istenilen yüzdesini bulmayı sağlayan algoritma
                1. Sayı = 100
                2. Yüzde = %20
                Sonuç = 20

         */

        Console.WriteLine("İlk sayıyı giriniz: ");
        int firstNumber = Convert.ToInt32(System.Console.ReadLine());


        Console.WriteLine("Yüzdeyi giriniz: ");
        int yüzde = Convert.ToInt32(Console.ReadLine());

        var sonuc = (yüzde * 100) / firstNumber;

        Console.WriteLine($"Sonuç: {sonuc}");
        Console.ReadLine();








    }

