using System;
using patika.Homeworks.Homework4.Entity;
using patika.Homeworks.Homework4.Menu;

namespace patika.Homeworks.Homework4
{
    public class Program
    {
        public static void Run()
        {
            SampleData.Add(Board.TodoList);

            var input = 0;
            while (input != 5)
            {
                StartMenu.List();
                input = TryParseIfPossible.FromStringToByte(Console.ReadLine());

                Menu.Menu.Selector(input);
            }
        }
    }
}