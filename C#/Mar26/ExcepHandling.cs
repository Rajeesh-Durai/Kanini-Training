using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar26
{
    internal class ExcepHandling
    {
        int n1, n2, ans;
        public ExcepHandling(int n1, int n2, int ans)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.ans = ans;
        }
        public void add()
        {
          this.ans=this.n1+this.n2;
        }
        public void sub()
        {
            this.ans = this.n1 - this.n2;
        }
        public void mul()
        {
            this.ans = this.n1 * this.n2;
        }
        public void div()
        {
            try
            {
                this.ans = this.n1 / this.n2;
                Console.WriteLine(ans); 
            }
            catch(DivideByZeroException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
