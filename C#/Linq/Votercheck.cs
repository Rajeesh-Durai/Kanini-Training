using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Votercheck
    {
        public static List<People> where(People[] people, EligibleCheck del)
        {
            List<People> voters = new List<People>();
            foreach(People p in people)
            {
                if(del(p))
                {
                    voters.Add(p);
                }
            }
            return voters;
        }
    }
}
