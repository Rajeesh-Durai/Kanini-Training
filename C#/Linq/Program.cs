using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    delegate bool EligibleCheck(People person);
    public class Program
    {
        public static void Main(string[] args)
        {
            ExampleForClassification example2 = new ExampleForClassification();
            example2.Example3();






           /*common values
            * 
            * People[] peoples =
            {
                new People(){Name="Raja", Age =48},
                new People(){Name="Mathi", Age =42},
                new People(){Name="Laxmeesh", Age =12}
            };*/



            /*Basic
             * 
             * 
             * People[] voters = new People [ peoples.Length ];
            int i = 0;
            foreach( People person in peoples )
            {
                if(person.Age>=18)
                {
                    voters[i++] = person;
                    Console.WriteLine(person.Name);
                }
            }*/



           /*Delegate method
            * 
            * List<People> voter=Votercheck.where(peoples, delegate (People people)
                {
                    return people.Age >=18;
                });*/

          /*Query Method
           * 
           * var voter= from person in peoples where person.Age>=18 select person;*/


           /*Common for all
            * 
            * foreach (People people in voter)
            {
                Console.WriteLine(people.Name);
            }*/



        }
    }
}