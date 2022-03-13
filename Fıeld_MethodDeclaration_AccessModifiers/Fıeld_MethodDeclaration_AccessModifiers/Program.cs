using System;

namespace Fıeld_MethodDeclaration_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personal personal1 = new Personal();
            personal1.name = "Selim";
            personal1.surname = "Bahcıvan";
            personal1.age = 24;
            personal1.department = "Engineer";
            personal1.PersonalInfo();
        }
    }
    class Personal
    {
        public string name;
        public string surname;
        public int age;
        public string department;

        public void PersonalInfo()
        {
            Console.WriteLine("Name : " +name);
            Console.WriteLine("Surname : " + surname);
            Console.WriteLine("Age : " +age);
            Console.WriteLine("Department : " + department);
        }
    }
}
