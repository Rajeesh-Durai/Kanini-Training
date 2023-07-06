using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
   
    internal class Program
    {
        public static void Main(string[] args)
        {
            SmartPhone ph = new SmartPhone();
            double balance = 1;

            if (balance <= 0)
            {
                try
                {
                    Console.WriteLine("Not enough balance");
                }
                catch (NotFiniteNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                ph.CallLog();
            }
        }

    }

}
