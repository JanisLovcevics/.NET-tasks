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

        for (int i = 0; i < discountedPrices.Length; i++)
        {
            
        }
    }
}