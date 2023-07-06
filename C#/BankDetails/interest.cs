using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    internal class interest:Bank
    {
        private int intpercent;

        public interest(int intpercent, int acc_no, string name, double balance, double interest):base(acc_no, name,balance,interest)
        {
            this.Intpercent = intpercent;
        }

        public int Intpercent { get => intpercent; set => intpercent = value; }

        public override double Calcinterest()
        {
            return Balance=1*( intpercent / 100);
        }

    }
}
