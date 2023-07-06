using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Characterpattern
    {
        public Characterpattern() 
        {
            int NoofLines = Convert.ToInt32(Console.ReadLine());
            int num = 1;
            for (int i = 0; i < NoofLines; i++)
            {
                for (int space = NoofLines - 1; space >= i; space--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(num++ + "   ");
                }
                Console.WriteLine();
                num = 1;
            }
        }
    }
}
