public class Library
{
    public static string LibraryName;
    public static int TotalBooks;
    public static int BorrowedBooks;

    public static void AddBooks(int amount)
    {
        TotalBooks += amount;
    }

    public static void BorrowBook()
    {
        if (TotalBooks > 0)
        {
            BorrowedBooks++;
            Console.WriteLine("Grāmata izsniegta");
        }
        else
        {
            Console.WriteLine("Nav pieejamu grāmatu");
        }
    }

    public static void ReturnBook()
    {
        if (BorrowedBooks > 0)
        {
            BorrowedBooks--;
            Console.WriteLine("Grāmata atgriezta");
        }
        else
        {
            Console.WriteLine("Nav nevienas izsniegtas grāmatas");
        }
    }

    public static void ShowStatistics()
    {
        Console.WriteLine($"Bibliotēka: {LibraryName}");
        Console.WriteLine($"Kopējais grāmatu skaits: {TotalBooks}");
        Console.WriteLine($"Izsniegtās grāmatas: {BorrowedBooks}");
        Console.WriteLine($"Pieejamās grāmatas: {TotalBooks -  BorrowedBooks}");
        Console.WriteLine($"Izsniegti {1.0 * BorrowedBooks / TotalBooks * 100}% no visām grāmatām");
    }
}