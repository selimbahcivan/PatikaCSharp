
using ToDoApplication.Controller;
using ToDoApplication.Models;
using static ToDoApplication.Program;
namespace ToDoApplication
{
    internal partial class Program
    {
        public class DisplayList
        {
            public static void Listele()
            {
                ListerExtension.ListeleExt(Board.TodoList, "ToDo List");
                ListerExtension.ListeleExt(Board.InProgressList, "In Progress List");
                ListerExtension.ListeleExt(Board.DoneList, "Done List");
            }

        }
    }
}
