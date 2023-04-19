using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    internal class Student
    {

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get;private set; }
        public int Age { get; private set; }
        public int Group { get; private set; }
        public int Grade { get; private set; }


        public Student()
        {
            Id = 001;
            FirstName = "Avazbek";
            LastName = "Muqumjonov";
            Age = 17;
            Group = 2;
            Grade = 5;
        }


        public Student(int id, string firstName, string lastName, int age, int group, int grade)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Group = group;
            Grade = grade;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Group: {Group}");
        }
        public void SetExamResult(int n)
        {

                if (n > 100)
                {

                 Console.WriteLine("Enter correct grade!");

                }
                Grade = n;
            
        }
    }
}

