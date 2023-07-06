using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class ExampleForClassification
    {
        public void Example() 
        {
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "AAA", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "BBB",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "CCC",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "DDD" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "EEE" , Age = 15 }
               };
            //query syntax
            var filter = from s in studentList where s.Age> 12 && s.Age<20 select s;
            

            foreach( var student in filter )
            {
                Console.WriteLine( student.StudentName);
            }




            /*List<string> courses = new List<string>();
            courses.Add("C++ Tutorials");
            courses.Add("C# Tutorials");
            courses.Add("Learn sql");
            courses.Add("ADO.NET");*/

            /*var tut= from c in courses where c.Contains("Tutorials") select c;*/
            /*var tut = courses.Where(c => c.Contains("Tutorials"));
            foreach (var c in tut)
            {
                Console.WriteLine(c);
            }*/
        }

        public void Example2()
        {
            IList elements = new ArrayList();
            elements.Add(1);
            elements.Add(2);
            elements.Add("Three");
            elements.Add( 4 );
            elements.Add( "Five" );
            var strings = from e in elements.OfType<string>() select e;
            var integers=from e in elements.OfType<int>() select e; 
            foreach(string s in strings)
            {
                Console.WriteLine( s );
            }
            foreach(int  i in integers)
            {
                Console.WriteLine( i );
            }
        }

        public void Example3()
        {
            IList<Student> studentz = new List<Student>()
            {
                new Student(){StudentID=1,StudentName="Mathi",Age=18 },new Student(){StudentID=2,StudentName="Mathi",Age=15 },new Student(){StudentID=3,StudentName="Laxmeesh",Age=12 }
            };

            //query syntax
            //  var res = from s in studentz orderby s.StudentName select s;
            var res = from s in studentz group s by s.StudentName;
            foreach(var ans in res)
            {
                Console.WriteLine( ans.Key);
            }
        }
   

    }
}
