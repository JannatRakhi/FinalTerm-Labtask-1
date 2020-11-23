using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    class OverdraftAccount : Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }





        public OverdraftAccount()
        {

        }

        public OverdraftAccount(string accName, string accNo, double balance, double overdraftLimit) : base(accName, accNo, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {

            if (amount <= Balance + overdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine("Overdraft Account withdraw successfull..");
            }
            else
                Console.WriteLine("Overdraft unsuccessfull");

        }

    }
}

