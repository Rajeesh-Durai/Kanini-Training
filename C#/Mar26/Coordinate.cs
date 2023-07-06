using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mar26
{
    internal class Coordinate
    {
        public void coordinate(int num1,int num2)
        {
           if(num1>0 && num2>0)
            {
                Console.WriteLine("The coordinate point (" + num1 + "," + num2 + ") lies in the First quadrant.");
            }
           if(num1>0 && num2<0){
                Console.WriteLine("The coordinate point (" + num1 + "," + num2 + ") lies in the Fourth quadrant.");
            }
            if(num1 < 0 && num2 < 0){
                Console.WriteLine("The coordinate point (" + num1 + "," + num2 + ") lies in the Third quadrant.");
            }
            if(num1 < 0 && num2 > 0){
                Console.WriteLine("The coordinate point (" + num1 + "," + num2 + ") lies in the Second quadrant.");
            }
           
        }
        public void student(int rollnum, int phy, int chem, int com, string name)
        {
            Console.WriteLine("Roll number: " + rollnum);
            Console.WriteLine("Name: "+name);
            int per, tot;
            string division;
            tot = phy + chem + com;
            Console.WriteLine("Total: "+tot);
            per = tot / 3;
            Console.WriteLine("Percentage: "+per+"%");
            if (per >= 80)
            {
                division = "First";
                Console.WriteLine("Division: " + division);
                return;
            }
            if (per >= 60)
            {
                division = "Second";
                Console.WriteLine("Division: " + division);
                return;
            }
            if (per >= 40)
            {
                division = "Third";
                Console.WriteLine("Division: " + division);
                return;
            }
            else {
                division = "Fail";
                Console.WriteLine("Division: " + division);
                return;
                    }

        }
        public void electricity(int custid,int unit, string name)
        {
           double bill;
            double surcharge =.15;
            Console.WriteLine("Customer ID: "+custid);
            Console.WriteLine("Name: " + name);
            if (unit <= 199)
            {
               double charge =1.20;
                bill = charge * unit;
                if (bill < 100)
                {
                    Console.WriteLine("Minimum bill should not be less than 100");
                }
                else
                {
                    Console.WriteLine("Electricity Bill: " + bill);
                }
                return;
            }
            if(unit>=200 && unit<400)
            {
              double  charge = 1.50;
                bill = charge * unit;
                if (bill < 100)
                {
                    Console.WriteLine("Minimum bill should not be less than 100");
                }
                else
                {
                    Console.WriteLine("Electricity Bill: " + bill);
                }
                return;
            }
            if(unit>=400 && unit<600)
            {
                double charge = 1.80;
                bill = charge * unit;
                double additional = bill * surcharge;
                bill+=additional;
                if (bill < 100)
                {
                    Console.WriteLine("Minimum bill should not be less than 100");
                }
                else
                {
                    Console.WriteLine("Electricity Bill: " + bill);
                }
                return;
            }
            if (unit >=  600)
            {
               double charge =2.00;
                bill = charge * unit;
                double additional = bill * surcharge;
                bill += additional;
                if (bill < 100)
                {
                    Console.WriteLine("Minimum bill should not be less than 100");
                }
                else
                {
                    Console.WriteLine("Electricity Bill: " + bill);
                }
                return;
            }
        }
        public void triangle(int num)
        {
            int value = 1;
            for(int i=0; i<num; i++)
            {
                for(int j=0;j<=i; j++)
                {
                    Console.Write(value++ +" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
                int newvalue = 1;
            for(int i=1;i<=num;i++)
            {
                for(int space=num; space>i; space--)
                {
                    Console.Write(" ");
                }
                for(int j=1;j<=i;j++)
                {
                    Console.Write(newvalue++ + " ");
                }
                Console.WriteLine();
            }
        }



    }
}
