using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Tasks
{
    class Solutions
    {
        class Module1
        {
            public static void RepeatWordMultipleTimes ()
            {
                Console.Write("Enter a word:\t");
                string word = Console.ReadLine();

                for (int i = 0; i < word.Length; i++)
                {
                    Console.WriteLine(word);
                }
            }

            public static void SumOfNumbers ()
            {
                int sum = 0;

                while(true)
                {
                    Console.Write("Give a number:\t");
                    int number = Convert.ToInt32(Console.ReadLine());

                    if (number == 0)
                    {
                        Console.WriteLine($"Sum of the numbers: {sum}");
                        break;
                    }

                    sum += number;
                }
            }

            
        }

        class Module2
        {
            public static void UzminiSkaitli()
            {
                // Set up the game

                int maxGuesses = 5;
                int guessCount = 1;
                bool hasWon = false;

                Console.WriteLine("I'm thinking of a number between 1 and 20.");
                Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");

                int secretNumber = new Random().Next(1, 21);

                while (!hasWon && guessCount <= maxGuesses)
                {
                    // Ask the player to guess

                    Console.Write($"Guess #{guessCount}: ");
                    int guess = Convert.ToInt32(Console.ReadLine());

                    // Check the guess and give feedback

                    if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high.\n");
                    }
                    else if (guess < secretNumber) {
                        Console.WriteLine("Too low.\n");
                    }
                    else
                    {
                        hasWon = true;
                        break;
                    }

                    guessCount++;
                }

                // Announce the result

                if (hasWon)
                {
                    Console.WriteLine($"Correct! You got it in {guessCount} guesses");
                }
                else
                {
                    Console.WriteLine($"Out of guesses! The number was {secretNumber}");
                }
            }

            public static void SkolasKafejnicasIenemmuAnalize()
            {
                int[] purchases = new int[30];

                purchases = purchases.Select(purch => new Random().Next(1, 11)).ToArray();

                Console.WriteLine("Pirkumi:");

                int maziePirkumi = 0;
                int videjiePirkumi = 0;
                int lieliePirkumi = 0;

                foreach (var purchase in purchases)
                {
                    Console.Write(purchase + " ");

                    if (purchase >= 8)
                    {
                        lieliePirkumi++;
                    }
                    else if (purchase >= 4)
                    {
                        videjiePirkumi++;
                    }
                    else
                    {
                        maziePirkumi++;
                    }
                }

                int sum = purchases.Sum();
                Console.WriteLine($"\n\nKopējie ieņēmumi: {sum}$");

                int biggest = purchases.Max();
                Console.WriteLine($"Lielākais pirkums: {biggest}");

                int smallest = purchases.Min();
                Console.WriteLine($"Mazākais pirkums: {smallest}");

                float average = sum / purchases.Length;
                Console.WriteLine($"Vidējais pirkums: {average}");

                int purchasesAboveAverage = 0;
                foreach (var purchase in purchases)
                {
                    if (purchase > average)
                    {
                        purchasesAboveAverage++;
                    }
                }

                Console.WriteLine($"Pirkumi virs vidējā: {purchasesAboveAverage}\n");

                Console.WriteLine($"Mazie pirkumi: {maziePirkumi}");
                Console.WriteLine($"Vidējie pirkumi: {videjiePirkumi}");
                Console.WriteLine($"Lielie pirkumi: {lieliePirkumi}");
            }

            public static void KlasesSkolenuSaraksts()
            {
                List<string> skoleni = new List<string>();

                void izvaditSarakstu()
                {
                    foreach (var skolens in skoleni)
                    {
                        Console.WriteLine(skolens);
                    }
                }

                skoleni.Add("Janis");
                skoleni.Add("Vsevolods");
                skoleni.Add("Sofa");
                skoleni.Add("Aleks");
                skoleni.Add("Emils");

                bool active = true;

                while (active)
                {
                    Console.WriteLine("1 - Pievienot skolēnu");
                    Console.WriteLine("2 - Dzēst skolēnu");
                    Console.WriteLine("3 - Parādīt visus skolēnus");
                    Console.WriteLine("4 - Parādīt skolēnu skaitu");
                    Console.WriteLine("0 - Iziet");

                    int taskNumber = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch (taskNumber)
                    {
                        case 1:
                            Console.Write("Uzraksti skolēna vārdu pievienošanai: ");
                            skoleni.Add(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("Uzraksti skolēna vārdu dzēšanai:");
                            skoleni.Remove(Console.ReadLine());
                            break;
                        case 3:
                            izvaditSarakstu();
                            break;
                        case 4:
                            Console.WriteLine($"Skolēnu skaits sarakstā: {skoleni.Count}");
                            break;
                        case 0:
                            active = false;
                            break;
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }

                    Console.WriteLine("\n\n");
                }
            }

            public static void KonsolesSaturaRaditajs()
            {
                void izvaditSaturaRaditaju(string nosaukums, string numurs)
                {
                    Console.WriteLine(nosaukums + new string('.', 40 - nosaukums.Length - numurs.Length) + numurs);
                }

                var saturs = new List<Dictionary<string, string>>();

                for (int i = 0; i < 3; i++)
                {
                    Console.Write("Ievadiet nodaļas nosaukumu: ");
                    string nodalasNosaukums = Console.ReadLine();

                    Console.Write("Ievadiet lapas numuru: ");
                    string lapasNumurs = Console.ReadLine();

                    saturs.Add(new Dictionary<string, string>
                    {
                        ["nodaļas nosaukums"] = nodalasNosaukums,
                        ["lapas numurs"] = lapasNumurs
                    });
                }

                foreach (var rinda in saturs)
                {
                    izvaditSaturaRaditaju(rinda["nodaļas nosaukums"], rinda["lapas numurs"]);
                }
            }

            public static void PrintStars(int count)
            {
                Console.WriteLine(new string('*', count));
            }

            public static void PrintSquare(int size)
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine(new string('*', size));
                }
            }

            public static void PrintRectangle(int width, int height)
            {
                for (int i = 0; i < height; i++)
                {
                    Console.WriteLine(new string('*', width));
                }
            }

            public static void PrintTriangle(int size)
            {
                for (int i = 1; i <= size; i++)
                {
                    PrintStars(i);
                }
            }

            public static void PrintPyramid(int height)
            {
                for (int i = 0; i < height; i++)
                {
                    Console.Write(new string(' ', height - 2 - i));
                    Console.WriteLine(new string('*', i) + '*' + new string('*', i));
                }
            }
        }
    }
}