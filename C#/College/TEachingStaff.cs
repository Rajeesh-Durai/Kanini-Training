using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class TEachingStaff:Clg
    {
        private int eid;
        private string name, dept, favsub;
        private double salary;

        public TEachingStaff(string collegename, string address, int pin, int eid, string name,string dept,string favsub, double salary):base(collegename, address, pin)
        {
            this.Eid = eid;
            this.Name = name;
            this.Addr = dept;
            this.Favsub = favsub;
            this.Salary = salary;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Addr { get => dept; set => dept = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Salary { get => salary; set => salary = value; }

        public double calcsalary()
        {
            double da = 0.4;
            double hra = 0.2;
            double allowance=(salary*da)+(salary*hra);
            double pf = 0.25;
            double deduction=salary*pf;
            double netsal = salary + allowance - deduction;
            return netsal;
        }
    }
}
