using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class CoffeeCups
    {
        private int cups;

        public int Cups { get => cups; set => cups = value; }
        public CoffeeCups(int cups) 
        {
            this.Cups = cups;
        }
        public int Output()
        {
            return ((this.Cups / 6) + this.Cups);
        }
    }
}
