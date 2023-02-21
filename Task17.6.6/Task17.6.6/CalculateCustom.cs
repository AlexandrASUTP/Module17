using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._6._6
{
    internal class CalculateCustom: ICalculateAccount
    {
        public void Execute(Account account)
        {
         
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.5;

            if (account.Balance < 1000)
            {
            Console.WriteLine(account.Interest -= account.Balance * 0.2);
            }

             if (account.Balance < 50000)
             account.Interest -= account.Balance * 0.4;

        }
    }
}
