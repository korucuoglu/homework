using System;
using patika.Homeworks.Homework4.Controller;
using patika.Homeworks.Homework4.Entity;

namespace patika.Homeworks.Homework4.Menu
{
    internal class Menu
    {
        public static void Selector(int input)
        {
            switch (input)
            {
                case 1:
                    BoardListeleme.List();
                    break;
                case 2:
                    KartEkle.Add(Board.TodoList);
                    break;
                case 3:
                    KartSil.Delete(Board.DoneList);
                    break;
                case 4:
                    KartTası.Move(Board.TodoList, Board.InProgressList, Board.DoneList);
                    break;
                case 5:
                    Console.WriteLine("\nÇıkış yapıldı..");
                    break;
                default:
                    Console.WriteLine("\nYanlış Giriş!\n");
                    break;
            }
        }
    }
}