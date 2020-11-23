using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Abstract_Bank_Account");
            Console.WriteLine("");

            Account account1 = new FixedAccount("001", "rakhi12", 10000.00, 2020, 10);
            Account account2 = new SavingsAccount("002", "rakhi123", 8000.00, 10);
            Account account3 = new SpecialSavings("003", "rakhi1234", 70000.00, 5);
            Account account4 = new OverdraftAccount("004", "rakhi111", 5000.00, 4000.00);

            
            account1.Withdraw(500);
            account2.Withdraw(500);
            
           
            account3.Withdraw(500);
           
            account4.Withdraw(500);
            Console.WriteLine("");



        }
    }
}
