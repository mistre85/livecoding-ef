// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

public class Student
{
  
    public int Id { get; set; }

    public string Name { get; set; }
    public string Surname { get; set; }

    public string Email { get; set; }

    public List<Review> Reviews { get; set; }

    public List<Course> Courses { get; set; }
}
