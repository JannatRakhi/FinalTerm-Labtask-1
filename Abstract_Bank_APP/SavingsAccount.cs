using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    class SavingsAccount : Account

    {
        private int transactionNo;
        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transactionlimit;

        public int Transactionlimit
        {

            get { return transactionlimit; }
            set { transactionlimit = value; }
        }
        public SavingsAccount() { }
        public SavingsAccount(string accNo, string accName, double balance, int transactionNo) : base(accNo, accName, balance)
        {
            this.transactionNo = transactionNo;



        }
        

    
        public override void Withdraw(double amount)
        {
            if (transactionlimit > transactionNo && balance > 500)
            {
                balance = balance - amount;

                Console.WriteLine("Saving Account transaction successfull");

            }
            else
            {
                Console.WriteLine("Insufficient Minimum Balance ");
            }
        }

    }
}