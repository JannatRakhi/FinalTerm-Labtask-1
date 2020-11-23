using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Bank_APP
{
    class FixedAccount : Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int withdrawYear;

        public int WithdrawYear
        {
            get { return withdrawYear; }
            set { withdrawYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, double balance, int withdrawYear, int tenureYear) : base(accNo, accName, balance)
        {
            this.withdrawYear = withdrawYear;
            this.tenureYear = tenureYear;
        }
        override public void Withdraw(double amount)
        {
           
            if (withdrawYear >= tenureYear)
            {
                balance -= amount;
            }
            else
                Console.WriteLine("User Can't withdraw money before tenure year");
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine(" Withdraw Year: " + withdrawYear);
            Console.WriteLine(" Tenure Year: " + tenureYear);
        }

    }
}

