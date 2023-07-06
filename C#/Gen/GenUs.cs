using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen
{
    internal class GenUs<T> where T : class
    {
        private T excepobj;
        public GenUs(T excepobj) { this.Excepobj = excepobj; }

        public T Excepobj { get => excepobj; set => excepobj = value; }

        public T Dis()
        {
            return Excepobj;
        }


    }
}
