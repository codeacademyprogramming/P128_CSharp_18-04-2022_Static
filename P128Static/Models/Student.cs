using System;
using System.Collections.Generic;
using System.Text;

namespace P128Static.Models
{
    
    class Student
    {
        //Static - Non Access Modifier
        //Static Field
        //public static string Name = "Hamid";
        //Non-Static Field
        //public string name;

        private static int Id;

        public static int TotalCount { get; private set; }

        //Instance Memmbers
        public readonly string No;
        public string Name;
        public string SurName { get; set; }
        public int Age;

        //Yalniz Ilk Instance Zamani Ise Dusur Ve Bir Defe Isdiyir
        //Hec Vaxt Hec Bir Yerden Cagrila Bilmir
        //Overload Olmur Cunku Parametr Qebul Etmir
        //Yaratmadigmiz Teqdirde Movcud Olmur
        static Student()
        {
            Console.WriteLine($"Ilk Instance Yarandı Tarix: {DateTime.Now.ToString("dddd-MMMM-yyyy HH:mm:ss:ffff")}");
            Id = 100;
        }


        public Student(string name, string surName)
        {
            Name = name;
            SurName = surName;
            No = $"{Name[0]}{SurName[0]}{Id}";
            Id++;
            TotalCount++;
            Console.WriteLine($"Instance Yarandı Tarix: {DateTime.Now.ToString("dddd-MMMM-yyyy HH:mm:ss:ffff")}");
        }

        //Static Method
        //Can't use non static member inside of static method
        public static void Test()
        {
            Console.WriteLine($"{TotalCount}");
        }

        //Non Static Method
        //Butun Nov Memberler(Uzvleri) Adi Methodun Daxilinde Isdifede Ede Bilirik
        public void Info()
        {
            Console.WriteLine($"{TotalCount} {Id} {Name}");
            Test();
        }

    }
}
