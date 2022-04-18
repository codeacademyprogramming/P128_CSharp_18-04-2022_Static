using P128Static.Extensions;
using P128Static.Models;
using System;

namespace P128Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Metin","Nejefov");

            //Student student2 = new Student("Vasif","Haciyev");

            //Student student3 = new Student("Seid", "Zahidov");

            //Student student4 = new Student("Surxay","Shxiyev");

            //Student student5 = new Student("Nicat", "Muxtarov");

            //Group group = new Group { No = "P128", Limit = 12 };
            //group.AddStudent(student1);
            //group.AddStudent(student2);
            //group.AddStudent(student3);
            //group.AddStudent(student4);
            //group.AddStudent(student5);

            //foreach (Student item in group.GetStudnets())
            //{
            //    Console.WriteLine($"Ad: {item.Name} SoyAd: {item.SurName} {item.No}");
            //}

            //Console.WriteLine(Student.TotalCount);

            //Student.Test();

            int a = CustomMath.Sum(5, 8);

            bool check = a.IsOdd();

            Console.WriteLine(check);

            string word = "Hello World P128 Code";

            bool checkStr = word.ChekcStringLength();
            bool checkChr = word.ChekcChar('h');

            Console.WriteLine(checkStr);
            Console.WriteLine(checkChr);
        }
    }
}
