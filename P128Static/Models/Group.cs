using System;
using System.Collections.Generic;
using System.Text;

namespace P128Static.Models
{
    class Group
    {
        public string No { get; set; }

        public int Limit { get; set; }
        private Student[] _students;

        public Group()
        {
            _students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            if (_students.Length < Limit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
                return;
            }
            Console.WriteLine("Qrup Doludur!!!");
        }

        public Student[] GetStudnets() => _students;
        //{
        //    return Students;
        //}
    }
}
