using System;

namespace Fıeld_MethodDeclaration_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*********Çalışan 1 *************");
            Employee employee1 = new Employee("Selim", "Bahcıvan", 24, "Engineer");
            employee1.EmployeeInfo();

            Console.WriteLine("*********Çalışan 2 *************");
            Employee employee2 = new Employee("Yavuz", "Bahcıvan");
            employee2.EmployeeInfo();

            
        }
    }       
    class Employee
    {
        public string name;
        public string surname;
        public int age;
        public string department;

        public Employee(string name, string surname, int age, string department )
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.department = department;
        }
        // Constructor Overloading
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public void EmployeeInfo()
        {
            Console.WriteLine("Name : " +name);
            Console.WriteLine("Surname : " + surname);
            Console.WriteLine("Age : " +age);
            Console.WriteLine("Department : " + department);
        }
    }
}
