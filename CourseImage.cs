// See https://aka.ms/new-console-template for more information

public class CourseImage
{

    public int Id { get; set; }
    public byte[] Image { get; set; }
    public string Caption { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}
