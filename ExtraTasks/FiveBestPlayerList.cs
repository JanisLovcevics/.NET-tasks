class FiveBestPlayerList
{
    static void Game()
    {
        // Set up game
        Random random = new Random();
        int roundsPlayed = 8;
        List<int> allScores = new List<int>();

        Console.WriteLine($"Playing {roundsPlayed} rounds...\n");

        // Simulate playing rounds and log every score
        for (int round = 1; round < roundsPlayed; round++)
        {
            int score = random.Next(0, 101);
            
        }
    }
}