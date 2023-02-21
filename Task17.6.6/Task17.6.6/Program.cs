using System;
using Task17._6._6;

internal class Program
{
    private static void Main(string[] args)
    {
        var calc = new CalculateAccount();

        Account Custom = new Account("Обычный", 2323232323);
        calc.Calculate(new CalculateCustom());
        Console.WriteLine();


        Account Salary = new Account("Зарплатный", 5657675645);
        calc.Calculate(new CalculateSalary());
        Console.WriteLine();
    }
}