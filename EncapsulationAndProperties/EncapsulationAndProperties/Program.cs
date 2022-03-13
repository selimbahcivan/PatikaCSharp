using System;

namespace EncapsulationAndProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Selim";
            student1.Surname = "Bahcıvan";
            student1.StudentNo = 654;
            student1.Grade = 4;
            student1.GetStudentInfo();
            student1.Upgrade();
            student1.GetStudentInfo();

            Student student2 = new Student("Yavuz","Selim",984,1);
            student2.GetStudentInfo();
            student2.Downgrade();
            student2.Downgrade();
            student2.GetStudentInfo();

        }
    }
    class Student
    {
        private string name;
        private string surname;
        private int studentNo;
        private int grade;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        

        public string Surname { get => surname; set => surname = value; }
        public int StudentNo { get => studentNo; set => studentNo = value; }
        public int Grade 
        { 
          get => grade; 
          set 
          {
                if(value < 1)
                {
                    Console.WriteLine("Grade cannot be less than one !");
                    grade=1;
                }
                else
                {
                    grade = value;
                }    
          } 
        }

        public Student(string name, string surname, int studentNo, int grade)
        {
            Name = name;
            Surname = surname;
            StudentNo = studentNo;
            Grade = grade;
        }
        public Student() { }

        public void GetStudentInfo()
        {
            Console.WriteLine("***********Student Informations**************");
            Console.WriteLine("Student Name    : {0}", this.Name);
            Console.WriteLine("Student Surname : {0}", this.Surname);
            Console.WriteLine("Student No      : {0}", this.StudentNo);
            Console.WriteLine("Student Grade   : {0}", this.Grade);
        }

        public void Upgrade()
        {
            this.Grade = this.Grade+1 ;

        }
        public void Downgrade()
        {
            this.Grade = this.Grade-1 ;

        }

    }
}
