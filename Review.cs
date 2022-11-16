// See https://aka.ms/new-console-template for more information

public class Review
{

    public int Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }
}
