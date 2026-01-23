namespace ConsoleApp2;

public class Library
{
    public List<Book> Books { get; set; }
    
    public Library()
    {
        Books = new List<Book>();
    }
    
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Книга '{book.Title}' добавлена в библиотеку.");
    }
    
    public List<Book> AvailableBooks()
    {
        List<Book> availableBooks = new List<Book>();
        
        foreach (Book book in Books)
        {
            if (book.Available)
            {
                availableBooks.Add(book);
            }
        }
        
        return availableBooks;
    }
}