using BookLib;

class Program
{
    static void Main()
    {
        Book.AddBook("Война и мир", "Л. Толстой", 1869, 3);
        Book.AddBook("Преступление и наказание", "Ф. Достоевский", 1866, 5);

        Book.ShowBooks();
    }
}