using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    abstract class Account
    {
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }
        public double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account()
        {

        }
        public Account(string accNo, string accName, double minimalbalance)
        {
            this.accNo = accNo;
            this.accName = accName;
            this.balance = minimalbalance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public abstract void Withdraw(double amount);

        virtual public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + accName);
            Console.WriteLine("Acc No: " + accNo);
            Console.WriteLine("Balance: " + balance);
        }
    }


}
