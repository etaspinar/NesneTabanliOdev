using StudentsManager;

Student student1 = new Student(1, "Hasan", "Taş", "Biyomedical Engineering");
Student student2 = new Student(2, "Mesut", "Karkı", "Software Engineering");
Student student3 = new Student(3, "Yaman", "Irmak", "Machine Engineering");
Student student4 = new Student(4,"Can","Var","Meteorology Engineering");

StudentManager studentManager = new StudentManager();
studentManager.Add(student1);
studentManager.Add(student2);
studentManager.Add(student3);
studentManager.Add(student4);

studentManager.Read();
studentManager.Update(4,"Hasan","Bilir","Software Engineering");
studentManager.Remove(student3);

Console.WriteLine("\n");
studentManager.Read();
studentManager.Add(student3);

Console.WriteLine("\n");
studentManager.Read();

