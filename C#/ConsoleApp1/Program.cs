using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*double a, b, c;
            a =Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();*/


            /*  int[]a=new int[3] {1,2,3};
              foreach(int i in a) { Console.Write(i+"  "); }
              Console.WriteLine();
              Console.WriteLine("Enter the new size");
              int n=Convert.ToInt32(Console.ReadLine());
              Array.Resize(ref a, n);
              foreach(int i in a) { Console.Write(i + "  "); }*/

            B1 obj= new B1();
            obj.getdata1();
            obj.getdata2();
            obj.display1();
            obj.display2();
        
           /* 
            int i,j, n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (i=0;i<n;i++) 
            {
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
            Console.WriteLine(String.Join(",",a));
            char x;
            x=Convert.ToChar(Console.ReadLine());
            if(x=='A')
            {
                for (i = 0; i < n; i++)
                {
                    for (j = i + 1; j < n; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
                Console.WriteLine(String.Join(",",a));
            }
            else
            {
                for(i=0;i<n;i++)
                {
                    for(j=i+1;j<n;j++)
                    {
                        if (a[i] < a[j])
                        {
                            int t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                        }
                    }
                }
                Console.WriteLine(String.Join(",", a));
            }
           */
            Console.Read();
        }
    }
}
