using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    class SpecialSavings : Account
    {
        private int transactionNo;

        public int TransactionNo
        {
            get { return transactionNo; }
            set { transactionNo = value; }
        }

        private int transLimit;

        public int TransLimit
        {
            get { return transLimit; }
            set { transLimit = value; }
        }

        private double openingBalance;

        public double OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }

        private int depositeCount;

        public int DepositeCount
        {
            get { return depositeCount; }
            set { depositeCount = value; }
        }


        public SpecialSavings()
        {

        }

        public SpecialSavings(string accName, string accNo, double balance, int transactionNo) : base(accName, accNo, balance)
        {
            this.transactionNo = transactionNo;
        }
           

        public override void Withdraw(double amount)
        {
           
            if ((transLimit <= transactionNo) && (Balance - amount >= (OpeningBalance / 10)))
            {
                Balance -= amount;
                Console.WriteLine("Special Savings Account Transaction Successfull");
            }
           

                else
                    Console.WriteLine("Minimal number of transaction reached.");
            }

        }

    }

