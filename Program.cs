// See https://aka.ms/new-console-template for more information



using Microsoft.EntityFrameworkCore;

SchoolDbContext db = new SchoolDbContext();


//Student paolo;

//IQueryable<Student> query = db.Students.Where(student => student.Id == 1);

//Student value = query.Include(student => student.Reviews).First();

Course corso = db.Courses.Include("Students.Reviews").First();

//Review review = paolo.Reviews.First();

//Console.WriteLine(review.Title);

return;

//Student paolo = new Student();

//paolo.Name = "Paolo";
//paolo.Surname = "Mistretta";
//paolo.Email = "paolo@mistre.it";

//Review r = new Review();

//r.Title = "Bellissimo esame";
//r.Text = "bene ma non benissimo";

//paolo.Reviews = new List<Review>();
//paolo.Reviews.Add(r);

//db.Students.Add(paolo);

//db.SaveChanges();

//Student marco = new Student() { Name = "Marco", Surname = "Mistretta", Email = "marco@mistre.it" };

//db.Students.Add(paolo);
//db.Students.Add(marco);

//db.SaveChanges();   

//select * from students
//List<Student> students = db.Students.ToList<Student>();


//Console.WriteLine("Cerca studente dal nome: ");
//string nome = Console.ReadLine();



////
//Student studenteFrancescoQ =
//                  (from s in db.Students
//                   where s.Name == nome
//                   select s).First<Student>();

//List<Student> studenti = new List<Student>();

//studenti.Where(s => s.Name == nome);

return;
//update
//students[0].Name = "Francesco";
//db.SaveChanges();

//stampa dei risultati
//foreach (Student student in students)
//{
//    Console.WriteLine("{0} {1}", student.Name, student.Surname);
//}



//db.SaveChanges();