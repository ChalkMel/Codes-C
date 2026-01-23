namespace ConsoleApp2;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }
    
    public Book(string title, string author, bool available)
    {
        Title = title;
        Author = author;
        Available = available;
    }

    public string Info()
    {
        string status = Available ? "доступна" : "недоступна";
        return $"Название: {Title},\n Автор: {Author},\n Доступна: {Available}\n";
    }
}