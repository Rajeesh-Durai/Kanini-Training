using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Mar26
{
    class A
    {
        public virtual void show()
        {
            Console.WriteLine("Hello: Base Class!");
            Console.ReadLine();
        }
    }

    // Derived Class  
    class B : A
    {
        public override void show()
        {
            Console.WriteLine("Hello: Derived Class!");
            Console.ReadLine();
        }
    }
    internal class Practice
    {
        public static void Main(string[] args)
        {
                    /* Console.WriteLine("Enter a Sentence");
                     string sentence = Console.ReadLine();
                     if ((sentence.Length % 2) != 0)
                     {
                         Oddnum odd = new Oddnum();
                         char ans1 = odd.elem1(sentence);
                         Console.WriteLine(ans1);
                     }
                     else
                     {
                         Evennum even = new Evennum();
                         char ans2 = even.elem2(sentence);
                         char ans3 = even.elem3(sentence);
                         Console.Write(ans3);
                         Console.Write(ans2);

                     }
                     Console.ReadKey();*/






            /*  ExcepHandling excepHandling = new ExcepHandling(10,0,1);
              excepHandling.div();*/


            /* File file = new File();*/

            /*  ListElement Listt=new ListElement();
              Listt.ListElem();*/


            /* int[][] jagged_arr = new int[4][]
                 {
                    new int[] {1, 2, 3, 4},
                    new int[] {11, 34, 67},
                    new int[] {89, 23},
                    new int[] {0, 45, 78, 53, 99}
                 };

            foreach (int[] arr in jagged_arr)
            {
                Console.WriteLine(arr);
            }*/


            /* List<int> num = new List<int>() { 1, 2, 3, 4, 5 };
             List<int> evennum = num.FindAll(x => (x % 2) == 0);

             foreach (int arr1 in evennum)
             {
                 Console.WriteLine(arr1);
             }*/

          
        // Derived Class  
           
           A obj = new A();
            obj.show();
        }
    }

}





/*namespace Assign1
{
    internal class Oddnum
    {
        public char elem1(string sentence)
        {
            int div = sentence.Length / 2;

            return sentence[div];
        }
    }
    internal class Evennum
    {
        public char elem3(string sentence)
        {
            int count3 = (sentence.Length / 2) - 1;
            char ans1 = sentence[count3];
            return ans1;
        }

        public char elem2(string sentence)
        {
            int count2 = (sentence.Length / 2);
            char ans = sentence[count2];
            return ans;
        }

    }*/




