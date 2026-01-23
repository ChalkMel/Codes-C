using ConsoleApp2;

Book CrimeAndPunishment = new Book("Преступление и наказание", " Ф.М. Достоевский", true);
Book Idiot = new Book("Идиот", "Ф.М. Достоевский", false);
Book WarAndPeace = new Book("Война и мир", "Л.Н. Толстой");
Book DeathOfOfficial = new Book("Смерть чиновника", "А.П.Чехов", false);
Book WoeFromWit = new Book("Горе от ума", "А.С. Грибоедов");

Library myLibrary = new Library();

myLibrary.AddBook(CrimeAndPunishment);
myLibrary.AddBook(Idiot);
myLibrary.AddBook(WarAndPeace);
myLibrary.AddBook(DeathOfOfficial);
myLibrary.AddBook(WoeFromWit);

List<Book> availableBooks = myLibrary.AvailableBooks();

foreach (Book book in availableBooks)
{
    Console.WriteLine(book.Info());
}


