using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    internal class MainCls
    {
        public static void Main(string[] args,ArithmeticException arithmeticException)
        {
            GenUs<ArithmeticException> ae = new GenUs<ArithmeticException>(arithmeticException);
            Console.WriteLine(ae.Dis().Message);
        }
    }
}
