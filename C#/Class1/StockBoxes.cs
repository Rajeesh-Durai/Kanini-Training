using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class StockBoxes
    {
        private int noofcubes;

        public int Noofcubes { get => noofcubes; set => noofcubes = value; }
        public StockBoxes(int noofcubes) 
        { 
            this.noofcubes = noofcubes;
        }
        public int output()
        {
            return (noofcubes* noofcubes);
        }
    }
}
