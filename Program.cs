using Classes;

namespace Programm
{
    class Class1
    {
        static void Main(string[] args)
        {
            PaymentCard PaulCard = new PaymentCard(20);
            PaymentCard MattCard = new PaymentCard(30);

            PaulCard.EatHeartily();
            MattCard.EatAffordably();
            Console.WriteLine($"{PaulCard.ToString()}\n{MattCard.ToString()}");
            PaulCard.AddMoney(20);
            MattCard.EatHeartily();
            Console.WriteLine($"{PaulCard.ToString()}\n{MattCard.ToString()}");
            PaulCard.EatAffordably();
            PaulCard.EatAffordably();
            MattCard.AddMoney(50);
            Console.WriteLine($"{PaulCard.ToString()}\n{MattCard.ToString()}");
        }
    }
}