using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2_odev
{
    internal class EmployeeManager
    {
        List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employees.Add(employee);    
        }

        public void GetAll()
        {
            employees.Sort();
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        public void Remove(int id)
        {
            int count = employees.Count;
            for (int i = 0; i <employees.Count; i++)
            {
                if (employees[i].Id == id)
                {
                    employees.RemoveAt(i);
                }
            }
            if(count == employees.Count)
            {
                throw new Exception("Bu id'ye ait kişi bulunamadı");
            }
        }
 
    }
}
