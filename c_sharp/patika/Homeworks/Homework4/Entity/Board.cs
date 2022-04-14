using System.Collections.Generic;

namespace patika.Homeworks.Homework4.Entity
{
    public class Board
    {
        private static List<Card> todoList = new();

        private static List<Card> doneList = new();

        private static List<Card> inProgressList = new();

        public static List<Card> TodoList { get => todoList; set => todoList = value; }
        public static List<Card> InProgressList { get => inProgressList; set => inProgressList = value; }
        public static List<Card> DoneList { get => doneList; set => doneList = value; }



    }
}