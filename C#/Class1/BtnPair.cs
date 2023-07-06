using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class BtnPair
    {
        private int noofbtn;

        public int Noofbtn { get => noofbtn; set => noofbtn = value; }
        public BtnPair(int noofbtn)
        {
            this.noofbtn = noofbtn;
        }
        public double Output()
        {
            return(Math.Pow(2, noofbtn));
        }
    }
}
