using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class B
    {
        public int id;
        public string name;
        public void getdata1()
            {
                id= Convert.ToInt32(Console.ReadLine()); ;
                name= Console.ReadLine();

            }
        public void display1()
        {
            Console.WriteLine("ID :" + id);
            Console.WriteLine("NAME :" + name);
        }
    }
    public class B1 : B
    {
        public int salary;
        public int yoj;
        public void getdata2()
        {
            salary = Convert.ToInt32(Console.ReadLine());
            yoj= Convert.ToInt32(Console.ReadLine());
        }
        public void display2()
        {
            Console.WriteLine(salary+ " " + yoj);
        }
    }
}
