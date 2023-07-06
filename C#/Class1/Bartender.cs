using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Bartender
    {
        private int age;
        private string onbreak;

        public int Age { get => age; set => age = value; }
        public string Onbreak { get => onbreak; set => onbreak = value; }

        public Bartender(int age, string onbreak)
        {
            this.Age = age;
            this.Onbreak = onbreak;
        }
        public bool Output()
        {
            if (this.Age >= 18 && this.Onbreak == "false" || this.Onbreak == "FALSE")
            {
                return true;
            }
            else { return false; }  
        }
    }
}
