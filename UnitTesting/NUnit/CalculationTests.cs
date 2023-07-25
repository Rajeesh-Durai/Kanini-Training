using Calculations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestings
{
    [TestFixture]
    public class CalculationTests
    {
        Calculator cal;
        [SetUp]
        public void SetUp()
        {
            cal = new Calculator(100, 100, 0);
            Console.WriteLine("SetUp");
            
        }



        [Test]
        [Order(3)]
        public void AddTest()
        {
            Console.WriteLine("Add");
            int res = cal.Add();
            Assert.AreEqual(200,res);
        }

        [TestCase(Author ="Boopathiraja Kannan",Description ="Testing For Add Method")]
        [Order(1)]
        public void SubTest()
        {
            Console.WriteLine("Sub");
            int res = cal.Sub();
            Assert.AreEqual(0, res);
        }



        [Test]
        [Order(2)]
      //  [Ignore("In Progress",Until ="2023-07-12")]
        public void MulTest()
        {
            Console.WriteLine("Mul");
            int res = cal.Mul();
            Assert.AreEqual(10000, res);
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
            cal = null;
        }



    }
}