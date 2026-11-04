class DiscountAppeal
{
    public static void Execute()
    {
        int[] prices = {25, 40, 15, 60, 30};
        int[] discountedPrices = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] > 30)
            {
                discountedPrices[i] = prices[i] / 10 * 9;
            }
            else
            {
                discountedPrices[i] = prices[i];
            }
        }

        Console.WriteLine("Oriģinālās cenas:");
        Console.WriteLine(string.Join(" ", prices));
        Console.WriteLine("Apstrādātās cenas:");
        Console.WriteLine(string.Join(" ", discountedPrices) + "\n");
        Console.WriteLine("Oriģinālo cenu summa: " + prices.Sum());
        Console.WriteLine("Apstrādāto cenu summa: " + discountedPrices.Sum());
        Console.WriteLine("Kopējais ietaupījums: " + (prices.Sum() - discountedPrices.Sum()));
    }
}