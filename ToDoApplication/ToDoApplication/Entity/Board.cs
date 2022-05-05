using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.Models
{
    internal class Board
    {
        private static List<Card> todoList = new();

        private static List<Card> inProgressList = new();

        private static List<Card> doneList = new();

        public static List<Card> TodoList { get => todoList; set => todoList = value; }  
        public static List<Card> InProgressList { get => inProgressList; set => inProgressList = value; }
        public static List<Card> DoneList { get => doneList; set => doneList = value; }
    }
}
