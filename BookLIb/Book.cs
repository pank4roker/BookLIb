namespace BookLib;

using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }      
    public string Author { get; set; }     
    public int Year { get; set; }          
    public int Copies { get; set; }        

    // Общая коллекция книг
    private static List<Book> books = new List<Book>();

    public Book(string title, string author, int year, int copies)
    {
        Title = title;
        Author = author;
        Year = year;
        Copies = copies;
    }

    public override string ToString()
    {
        return $"{Title} — {Author}, {Year} год (экземпляров: {Copies})";
    }

    // Метод добавления книги
    public static void AddBook(string title, string author, int year, int copies)
    {
        Book newBook = new Book(title, author, year, copies);
        books.Add(newBook);
        Console.WriteLine("Книга добавлена!");
    }

    // Метод отображения всех книг
    public static void ShowBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("Книг пока нет.");
            return;
        }

        Console.WriteLine("\n=== Список книг ===");
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}