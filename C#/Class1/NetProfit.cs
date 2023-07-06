using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class NetProfit
    {
        private double prob, prize, pay;

        public double Prob { get => prob; set => prob = value; }
        public double Prize { get => prize; set => prize = value; }
        public double Pay { get => pay; set => pay = value; }
        public NetProfit(double prob,double prize,double pay) 
        {
            this.prob = prob;
            this.prize = prize;
            this.pay = pay;
        }
        public double output()
        {
            return (this.prob*this.prize-this.pay);
        }
    }
}
