using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class Football
    {
        private int wins, draws, losses;
        public int Wins { get => wins; set => wins = value; }
        public int Draws { get => draws; set => draws = value; }
        public int Losses { get => losses; set => losses = value; }

        public Football(int wins, int draws, int losses)
        {
            this.Wins = wins;
            this.Draws = draws;
            this.Losses = losses;
         }

        public int Output()
        {
            int winpts = 3,drawpts =1,losspts = 0;
            return((winpts*this.Wins)+(drawpts*this.Draws)+(losspts*this.Losses));

        }
    }
}
