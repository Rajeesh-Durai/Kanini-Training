using System;
namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.OpenConn();
            class1.CreateTable();
            class1.InsertTable();
            class1.UpdateTable();
            class1.CloseConn();
        }
    }
}