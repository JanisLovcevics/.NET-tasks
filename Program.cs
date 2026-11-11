namespace Programm
{
    class Class1
    {
        public static void Main(string[] args)
        {
            Console.Write("Ievadiet bibliotēkas nosaukumu: ");
            Library.LibraryName = Console.ReadLine();

            while(true)
            {
                Console.WriteLine("1 - Pievienot grāmatas");
                Console.WriteLine("2 - Izsniegt grāmatu");
                Console.WriteLine("3 - Atgriezt grāmatu");
                Console.WriteLine("4 - Parādīt statistiku");
                Console.WriteLine("0 - Iziet");

                if(int.TryParse(Console.ReadLine(), out int activity))
                {
                    Console.Clear();

                    if (activity == 1)
                    {
                        Console.Write("Ievadiet grāmatu skaitu: ");
                        Library.AddBooks(int.Parse(Console.ReadLine()));
                    }
                    else if (activity == 2)
                    {
                        Library.BorrowBook();
                    }
                    else if (activity == 3)
                    {
                        Library.ReturnBook();
                    }
                    else if (activity == 4)
                    {
                        Library.ShowStatistics();
                    }
                    else if (activity == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong action");
                    }

                    Console.WriteLine("\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("This is not a number");
                }                
            }
        }
    }
}