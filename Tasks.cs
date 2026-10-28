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
        }
    }
}