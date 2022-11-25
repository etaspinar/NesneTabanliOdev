using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }

        public Student(int ıd, string firstName, string lastName, string departman)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Departman = departman;
        }

        public override string? ToString()
        {
            return $"{Id} {FirstName} {LastName} {Departman}" ;
        }
    }


}
