using System;
using ToDoApplication.Models;

namespace ToDoApplication
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            SampleData.Add(Board.TodoList);

            var input = 0;
            while (input != 5)
            {
                StartMenu.List();
                input = TryStringToByte.StringToByte(Console.ReadLine());

                Menu.Selector(input);
            }

            
        }
    }
}
