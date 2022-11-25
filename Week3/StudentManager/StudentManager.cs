using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManager
{
    internal class StudentManager
    {
        List<Student> students = new List<Student>();

        public void Add(Student student)
        {
            students.Add(student);
        }

        public void Read()
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }

        public void Update(int id ,string firstName,string lastName, string departman)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].Id == id)
                {
                    students[i].FirstName = firstName;
                    students[i].LastName = lastName;
                    students[i].Departman = departman;
                }
                 
            }
        }

        public void Remove(Student student)
        {
            students.Remove(student);
        }

    }
}
