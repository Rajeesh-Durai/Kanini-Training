using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class AdminStaff:Clg
    {
        int eid;
        string name;
        double salary; 
        public AdminStaff(string collegename,string address, int pin, int eid, string name, double salary):base(collegename,address,pin)
        {
            this.Eid = eid;
            this.Name = name;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calcsalary()
        {
            double da = 0.3;
            double hra = 0.15;
            double allowance = (salary * da) + (salary * hra);
            double pf = 0.20;
            double deduction = salary * pf;
            double netsal = salary + allowance - deduction;
            return netsal;
        }
    }
}
