namespace Programm
{
    class Class1
    {
        public static void Main(string[] args)
        {
            Pet cat = new Pet("Ginger", "cat", 8);
            Pet dog = new Pet("Mira", "dog", 2);
            Pet parrot = new Pet("Petya", "parrot", 3);

            Pet[] pets = {cat, dog, parrot};

            foreach (Pet pet in pets)
            {
                Console.WriteLine($"Vārds: {pet.Name}");
                Console.WriteLine($"Suga: {pet.Species}");
                Console.WriteLine($"Vecums: {pet.Age}\n");
            }

            Console.WriteLine($"Kopā reģistrēti {Pet.ObjectCreated} mājdzīvnieki");
        }
    }

    class Pet
    {
        public static int ObjectCreated {get; set;} = 0;
        public string Name {get; set;}
        public string Species {get; set;}
        public int Age {get; set;}

        public Pet(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;

            ObjectCreated++;
        }
    }
}