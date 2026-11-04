class PremiaCalc
{
    public static void CalcPremia()
    {
        int[] hours = { 28, 35, 42, 18, 40, 26, 50 };
        int nepSlodz = 0;
        int normSlodz = 0;
        int virsSlodz = 0;

        foreach (var employeeHours in hours)
        {
            if (employeeHours > 40)
            {
                Console.WriteLine($"{employeeHours} stundas -> Virsstundas");
                virsSlodz++;
                
            }
            else if (employeeHours >= 30)
            {
                Console.WriteLine($"{employeeHours} stundas -> Normālā slodze");
                normSlodz++;
            }
            else
            {
                Console.WriteLine($"{employeeHours} stundas -> Nepilna slodze");
                nepSlodz++;
            }
        }

        Console.WriteLine($"Darbinieki ar nepilnu slodzi: {nepSlodz}");
        Console.WriteLine($"Darbinieki ar normālu slodzi: {normSlodz}");
        Console.WriteLine($"Darbinieki ar virsstundām: {virsSlodz}");
    }
}