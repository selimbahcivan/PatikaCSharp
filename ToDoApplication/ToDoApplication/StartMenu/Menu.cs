using System;
using ToDoApplication.Controller;
using ToDoApplication.Models;

using static ToDoApplication.Program;

namespace ToDoApplication
{
    internal class Menu
    {
        public static void Selector(int input)
        {
            switch (input)
            {
                case 1:
                    DisplayList.Listele();
                    break;
                case 2:
                    AddCard.KartEkle(Board.TodoList);
                    break;
                case 3:
                    DeleteCard.KartSil(Board.DoneList);
                    break;
                case 4:
                    MoveCard.Move(Board.TodoList, Board.InProgressList, Board.DoneList);
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
