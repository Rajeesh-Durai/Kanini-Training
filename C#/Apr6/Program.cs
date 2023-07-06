using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Apr6
{
    /*class Customer
    {
        private int customerid;
        private string name;
        public string Name { get => name; set => name = value; }
        public int Customerid { get => customerid; set => customerid = value; }
        public Customer(int customerid,string name)
        {
            this.Customerid = customerid;
            this.Name = name;
        }
       virtual public void display()
        {
            Console.WriteLine("Customer ID: " + this.Customerid);
            Console.WriteLine("Customer Name: " + this.Name);
        }
    }
    class LoanAcc:Customer
    {
        private int LoanAccNo, LoanAmt, LoanTenureYrs;

        public int LoanAccNo1 { get => LoanAccNo; set => LoanAccNo = value; }
        public int LoanAmt1 { get => LoanAmt; set => LoanAmt = value; }
        public int LoanTenureYrs1 { get => LoanTenureYrs; set => LoanTenureYrs = value; }

        public LoanAcc(int loanAccNo, int loanAmt, int loanTenureYrs, int customerid, string name) :base(customerid, name)
        {
            this.LoanAccNo = loanAccNo;
            this.LoanAmt = loanAmt;
            this.LoanTenureYrs = loanTenureYrs;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Loan Account Number : "+this.LoanAccNo);
            Console.WriteLine("loan amount: " + this.LoanAmt);
            Console.WriteLine("loan tenure Years: " + this.LoanTenureYrs);
        }
    }

    class SavingsAcc:Customer
    {
        private int AccNo, Amount, IFSC;
        private string BranchName;

        public int AccNo1 { get => AccNo; set => AccNo = value; }
        public int Amount1 { get => Amount; set => Amount = value; }
        public int IFSC1 { get => IFSC; set => IFSC = value; }
        public string BranchName1 { get => BranchName; set => BranchName = value; }
        public SavingsAcc(int accNo, int amount, int iFSC, string branchName, int customerid, string name) :base(customerid, name)
        {
            this.AccNo = accNo;
            this.Amount = amount;
            this.IFSC = iFSC;
            this.BranchName = branchName;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Account No :"+this.AccNo);
            Console.WriteLine("Amount :"+this.Amount);
            Console.WriteLine("IFSC Code: " + this.IFSC);
            Console.WriteLine("Branch Name:"+this.BranchName);
        }
    }*/

    public class program
    {
        static void Main(string[] args)
        {
            /*int customerid = Convert.ToInt32(Console.ReadLine());
            int LoanAccNo=Convert.ToInt32(Console.ReadLine());
            int LoanAmt = Convert.ToInt32(Console.ReadLine());
            int LoanTenureYrs = Convert.ToInt32(Console.ReadLine());
            int AccNo = Convert.ToInt32(Console.ReadLine());
            int Amount = Convert.ToInt32(Console.ReadLine());
            int IFSC = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string BranchName= Console.ReadLine();
            Console.Write("Enter L for Loan Details or S for Saving Details: ");
            string option = Console.ReadLine();
            if (option == "L" || option == "l")
            {
                LoanAcc loan = new LoanAcc(LoanAccNo, LoanAmt, LoanTenureYrs, customerid, name);
                loan.display();
            }
            else if (option == "s" || option == "S")
            {
                SavingsAcc save = new SavingsAcc(AccNo, Amount, IFSC, BranchName, customerid, name);
                save.display();
            }
            else
            {
                Console.WriteLine("Enter a valid letter.....");
            }*/

            /* GenUse<int> guint = new GenUse<int>(10);
             GenUse<double> gudb = new GenUse<double>(1063.6252);
             GenUse<string> gustr = new GenUse<string>("Raja");
             Console.WriteLine(guint);
             Console.WriteLine(gudb);
             Console.WriteLine(gustr);*/
            GenUse<int> intarr = new GenUse<int>(5);
            for(int i = 0;i<5;i++)
            {
                intarr.setval(i, i*10);
            }
            for(int i = 0;i<5; i++)
            {
                intarr.getarr(i);
            }

        }

    }
}