using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6
{
    internal class CalculateSalary: ICalculateAccount
    {
        public void Execute(Account account)
        {
            
            Console.WriteLine(account.Interest = account.Balance * 0.5);
        }
    }
}
