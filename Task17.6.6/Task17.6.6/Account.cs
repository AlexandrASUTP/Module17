namespace Task17._6._6
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }
        
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public Account(string type,double balance)
        {
            this.Type = type;
            this.Balance = balance;
        }
    }
}