using System;

namespace StaticClassesAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı : {0}", Employee.EmployeeNumber);

            Employee employee1 = new Employee("Ayşe","Yılmaz","İK");
            Console.WriteLine("Çalışan sayısı : {0}", Employee.EmployeeNumber);
            Employee employee2 = new Employee("Ömer", "Faruk", "İK");
            Employee employee3 = new Employee("Yavuz", "Selim", "İK");
            Console.WriteLine("Çalışan sayısı : {0}", Employee.EmployeeNumber);



            // STATIC CLASS'ta sadece static üyeler bulunabilir !! 
            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(11, 22));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Çıkar(11, 10));
            Islemler.Çıkar(11, 22);



        }
    }
    class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; }

        private string Name;

        private string Surname;

        private string Department;

        // STATIC METHOD 1 kere çalışır bir daha çalışmaz CLASS'a aittir NESNE'ye değil ! 
        static Employee()
        {
            employeeNumber = 0;
        }

        public Employee(string name, string surname,string department)
        {
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            employeeNumber++;
        }  
    }
    static class Islemler
    {
        public static long Topla (int sayı1,int sayı2)
        {
            return sayı1 + sayı2;
        }
        public static long Çıkar (int sayı1, int sayı2)
        {
            return sayı1 - sayı2;
        }
    }
}
