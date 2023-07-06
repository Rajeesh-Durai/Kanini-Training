using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class animals
    {
        private int chicken, cow, pig;

        public int Chicken { get => chicken; set => chicken = value; }
        public int Cow { get => cow; set => cow = value; }
        public int Pig { get => pig; set => pig = value; }

        public animals(int chicken, int cow, int pig)
        {
            this.Chicken = chicken;
            this.Cow = cow;
            this.Pig = pig;
        }
        public int output()
        {
            int noofchick = 2, noofcow = 4, noofpig = 4;
            return (noofchick * this.Chicken) + (this.Cow * noofcow) + (this.Pig * noofpig);
        }
    }
}

