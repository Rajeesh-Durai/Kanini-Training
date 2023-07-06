using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDetails
{
    internal abstract class Bank
    {
        private int acc_no;
        private string name;
        private double balance;
        private double interest;
       public Bank(int acc_no, string name, double balance, double interest) { 
            this.Acc_no = acc_no;
            this.Name = name;
            this.Balance = balance;
            this.Interest = interest;
        }

        public int Acc_no { get => acc_no; set => acc_no = value; }
        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interest { get => interest; set => interest = value; }


        public abstract double Calcinterest();
    }
}
