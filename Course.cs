// See https://aka.ms/new-console-template for more information
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }

    public CourseImage Image { get; set; }

    public List<Student> Students { get; set; }

}
