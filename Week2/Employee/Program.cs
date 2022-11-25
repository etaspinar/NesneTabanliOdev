using Hafta2_odev;

Employee employee1 = new Employee(11, "Ali", "Yılmaz",12);
Employee employee2 = new Employee(12, "Fırat", "Kurnaz",20);
Employee employee3 = new Employee(13,"Yaman","Ballı",4);

EmployeeManager employeeManager = new EmployeeManager();
employeeManager.Add(employee1);
employeeManager.Add(employee2);
employeeManager.Add(employee3);

employeeManager.GetAll();

employeeManager.Remove(11);
employeeManager.Remove(19);






