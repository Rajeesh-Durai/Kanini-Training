using System;
namespace InterfaceClass
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter UI to see UI status or Enter DB to see DB Design Status: ");
            string status=Console.ReadLine();
            if(status =="UI")
            {
                UI uI = new UI();
               Console.WriteLine(uI.Progress());
            }
            if(status =="DB")
            {
                DBdesign dbdesign = new DBdesign();
                Console.WriteLine(dbdesign.Progress());
            }
        }
    }
}
