using System;

public class Reader
{
    public string Name { get; set; }
    public string LibraryCardNumber { get; set; }

    // Пока книг как класса нет, используем список строк (названия или ID книг)
    public List<string> BorrowedBooks { get; set; } = new List<string>();

    public Reader(string name, string libraryCardNumber)
    {
        Name = name;
        LibraryCardNumber = libraryCardNumber;
    }

    // Метод для добавления книги
    public void BorrowBook(string bookTitle)
    {
        BorrowedBooks.Add(bookTitle);
        Console.WriteLine($"Читателю {Name} выдана книга: {bookTitle}");
    }

    // Метод для отображения информации о читателе
    public void ShowInfo()
    {
        Console.WriteLine($"Читатель: {Name}, Билет: {LibraryCardNumber}");
        Console.WriteLine("Взятые книги:");
        if (BorrowedBooks.Count == 0)
            Console.WriteLine(" - Нет книг");
        else
            foreach (var book in BorrowedBooks)
                Console.WriteLine(" - " + book);
    }
}
