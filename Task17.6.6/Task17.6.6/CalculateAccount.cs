namespace Task17._6._6
{
    public class CalculateAccount
    {
        
        public void Calculate(ICalculateAccount calculateaccount)
        {
            calculateaccount.Execute();
        }
    }
}