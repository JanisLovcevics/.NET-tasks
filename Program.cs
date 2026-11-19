class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Species: ");
            string species = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Pet pet = new Pet() {Name = name, Species = species, Age = age};
        }
    }
}

class Pet
{
    public string Name;
    public string Species;
    public int Age;

    public Pet()
    {
        
    }
}