namespace Classes
{
    public class PaymentCard
    {
        private double Balance {get
            {
                return field;
            } 
            set
            {
                if (value < 0)
                {
                    return;
                }
                if (value > 150)
                {
                    field = 150;
                    return;
                }
                field = value;
            }
        }

        public PaymentCard (double balance)
        {
            Balance = balance;
        }

        public override string ToString()
        {
            return $"The card has a balance of {Balance:F2} euros";
        }

        public void EatAffordably()
        {
            Balance -= 2.60;
        }

        public void EatHeartily()
        {
            Balance -= 4.60;
        }

        public void AddMoney(double amount)
        {
            if (amount < 0)
            {
                return;
            }
            Balance += amount;
        }
    }
}