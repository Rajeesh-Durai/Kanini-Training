using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Program
    {

        static void Main(string[] args)
        {
           int switchbtn=Convert.ToInt32(Console.ReadLine());
            BtnPair btnPair=new BtnPair(switchbtn);
            Console.WriteLine(btnPair.Output());

        }
    }
}



