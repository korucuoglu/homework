using System.Collections.Generic;
using patika.Homeworks.Homework4.Entity;

namespace patika.Homeworks.Homework4.Controller
{
    public class BoardListeleme
    {
        public static void List()
        {
            BoardLister.Listele(Board.TodoList, "Todo List");
            BoardLister.Listele(Board.InProgressList, "InProgress List");
            BoardLister.Listele(Board.DoneList, "Done List");
        }
    }

}