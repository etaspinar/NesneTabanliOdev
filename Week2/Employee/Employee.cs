using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_odev
{
    public class Employee: IComparable<Employee>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }      

        public Employee(int ıd, string firstName, string lastName, int age)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int CompareTo(Employee? other)
        {
            return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} {Age}";
        }
    }
}