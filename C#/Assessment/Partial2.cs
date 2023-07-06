using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public partial class Calculator
    {
        public int Add()
        {
            return this.Num1+this.Num2;
        }
        public int Sub()
        {
            return (this.Num1 - this.Num2);
        }
    }
}
