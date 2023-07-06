using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mar26
{
    internal class ListElement
    {
        public void ListElem()
        {
            List<int> number = new List<int>();
            number.Add(10);
            number.Add(20);
            number.Add(30);

            foreach (int i in number)
            {
                Console.WriteLine(i);
            }
        }
    }
}
