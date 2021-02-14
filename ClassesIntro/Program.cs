using System;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Jonathan", 1000);
            Console.WriteLine($"This account belongs to {account.Name} and it has ${account.Balance}");
        }
    }
}
