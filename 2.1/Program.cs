using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student student = new Student();
            Student student1 = new Student();
            Console.WriteLine($"ID: {student.Id}, FirstName: {student.FirstName}, LastName: {student.LastName}, Age: {student.Age}, Group: {student.Group}, Grade: {student.Grade}");
            Console.Write("Enter grade which you want change : ");
            int n = int.Parse(Console.ReadLine());
            student1.SetExamResult(n);
            Console.WriteLine($"ID: {student1.Id}, FirstName: {student1.FirstName}, LastName: {student1.LastName}, Age: {student1.Age}, Group: {student1.Group}, Grade: {student1.Grade}");
            Console.WriteLine("====================================================");
            Main(args);



            /*  student1.Id = 17;
              student1.FirstName = "John";
              student1.LastName = "Johnson";
              student1.Age = 30;
              student1.Group = 17;
              student1.Grade = 7;
              Console.WriteLine("=============================");
              Console.WriteLine(student.Id);
              Console.WriteLine(student.FirstName);
              Console.WriteLine(student.LastName);
              Console.WriteLine(student.Age);
              Console.WriteLine(student.Group);
              Console.WriteLine(student.Grade);
              Console.WriteLine("==============================");
              Console.WriteLine(studentt.Id);
              Console.WriteLine(studentt.FirstName);
              Console.WriteLine(studentt.LastName);
              Console.WriteLine(studentt.Age);
              Console.WriteLine(studentt.Group);
              Console.WriteLine(studentt.Grade);
              Console.WriteLine("===============================");
              Console.WriteLine(student1.Id);
              Console.WriteLine(student1.FirstName);
              Console.WriteLine(student1.LastName);
              Console.WriteLine(student1.Age);
              Console.WriteLine(student1.Group);
              Console.WriteLine(student1.Grade);*/

        }
    }
}