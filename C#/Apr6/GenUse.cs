using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apr6
{
    internal class GenUse<T>
    {
        private T[] arr;
        public GenUse( int size)
        {
           arr=new T[size];
        }
        public void setval(int index, T value)
        {
            arr[index] = value;
        }
        public T getarr(int index) 
        {
            return arr[index]; 
        }
        

        /*private T num;
        public GenUse(T num)
        {
            this.Num = num;
        }

        public T Num { get => num; set => num = value; }*/
    }

}
