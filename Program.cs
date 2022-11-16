// See https://aka.ms/new-console-template for more information



SchoolDbContext db = new SchoolDbContext();

//Student paolo = new Student();

//paolo.Name = "Paolo";
//paolo.Surname = "Mistretta";
//paolo.Email = "paolo@mistre.it";

//Student marco = new Student() { Name = "Marco", Surname = "Mistretta", Email = "marco@mistre.it" };

//db.Students.Add(paolo);
//db.Students.Add(marco);

//db.SaveChanges();   

//select * from students
List<Student> students = db.Students.ToList<Student>();

//update
//students[0].Name = "Francesco";
//db.SaveChanges();

//stampa dei risultati
foreach (Student student in students)
{
    Console.WriteLine("{0} {1}", student.Name, student.Surname);
}



//db.SaveChanges();