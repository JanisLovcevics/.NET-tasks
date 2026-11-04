class AutoPark
{
    public static void AutoParking()
    {
        string[] parkingSpaces = new string[10];
        List<string> parkingHistory = new List<string>();
        List<string> vipCars = new List<string> {"aa1234", "bb4321"};

        bool active = true;

        while (active)
        {
            Console.WriteLine("1 - Novietot automašīnu");
            Console.WriteLine("2 - Izņemt automašīnu");
            Console.WriteLine("3 - Parādīt visas stāvvietas");
            Console.WriteLine("4 - Meklēt automašīnu");
            Console.WriteLine("5 - Parādīt vēsturi");
            Console.WriteLine("6 - Parādīt aizņemtības statistiku");
            Console.WriteLine("0 - Iziet\n");

            Console.Write("Izvēlaties darbību: ");
            int activity = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int parkingIndex = 0;
            string numuraZime = null;


            switch (activity)
            {
                case 1:
                    Console.Write("Ievadiet numura zīmi: ");
                    if (parkingSpaces.Contains(null))
                    {
                        parkingIndex = Array.FindIndex(parkingSpaces, x => x == null);
                        numuraZime = Console.ReadLine();
                        if (numuraZime != null && numuraZime.Length >= 5)
                        {
                            parkingSpaces[parkingIndex] = numuraZime;
                            parkingHistory.Add(numuraZime);
                            if (vipCars.Contains(numuraZime))
                            {
                                Console.WriteLine("VIP automašīna ieradusies!");
                            }
                            Console.WriteLine($"Auto novietots vietā Nr. {parkingIndex + 1}"); 
                        }
                        else
                        {
                            Console.WriteLine("Nederīga numura zīme");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nav brīvu stāvvietu");
                    }
                    break;
                case 2:
                    Console.Write("Ievadiet numura zīmi: ");
                    numuraZime = Console.ReadLine();
                    parkingIndex = Array.FindIndex(parkingSpaces, x => x == numuraZime);
                    if (parkingIndex >= 0)
                    {
                        parkingSpaces[parkingIndex] = null;
                        Console.WriteLine($"Auto izbrauca no vietas Nr. {parkingIndex}");
                    }
                    else
                    {
                        Console.WriteLine("Auto nav atrasts");
                    }
                    break;
                case 3:
                    for (int i = 0; i < parkingSpaces.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. vieta - {(parkingSpaces[i] == null ? "tukša" : parkingSpaces[i])}");
                    }
                    break;
                case 4:
                    Console.Write("Ievadiet numura zīmi: ");
                    numuraZime = Console.ReadLine();

                    foreach (string nZime in parkingSpaces.Select(x => x.Contains(numuraZime) ? x : null)) {
                        Console.WriteLine(nZime);
                    }

                    // if (parkingIndex >= 0)
                    // {
                    //     Console.WriteLine($"Auto atrodas vietā Nr. {parkingIndex+1}");
                    // }
                    // else
                    // {
                    //     Console.WriteLine("Auto nav atrasts");
                    // }
                    break;
                case 5:
                    for (int i = 0; i < parkingHistory.Count; i++)
                    {
                        Console.WriteLine(parkingHistory[0]);
                    }
                    break;
                case 6:
                    int emptySpaces = parkingSpaces.Count(x => x == null);
                    Console.WriteLine($"Brīvas vietas: {emptySpaces}");
                    int fullSpaces = parkingSpaces.Length - emptySpaces;
                    Console.WriteLine($"Aizņemtas vietas: {fullSpaces}");
                    Console.WriteLine($"Noslodze: {1.0 * fullSpaces / parkingSpaces.Length * 100}%");
                    break;
                case 0:
                    active = false;
                    break;
            }

            Console.WriteLine("\n\n");
        }
    }
}