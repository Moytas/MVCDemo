using EntityFrameworkDemo;

Entity studentDB = new Entity();
Student student = new Student();
student.Name = "Alex";
studentDB.Students.Add(student);
studentDB.SaveChanges();