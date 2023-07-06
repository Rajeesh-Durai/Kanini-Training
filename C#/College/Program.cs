using College;
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter College Name: " +"addr, pin");
        string collegename=Console.ReadLine();
        string address=Console.ReadLine();
        int pin=Convert.ToInt32(Console.ReadLine());    

        Console.WriteLine("EID, name, dept, favsub, " + "sal TS");
        int eid=Convert.ToInt32(Console.ReadLine());
        string name=Console.ReadLine();
        string dept=Console.ReadLine();
        string favsub=Console.ReadLine();
        double salary=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Admin staff-EID, name, sal");
        int aeid = Convert.ToInt32(Console.ReadLine());
        string aname = Console.ReadLine();
        double asalary = Convert.ToDouble(Console.ReadLine());

        TEachingStaff teachstaff = new TEachingStaff(collegename, address, pin, eid, name,dept, favsub, salary);
        AdminStaff adminstaff=new AdminStaff(collegename,address,pin,aeid,aname,asalary);

      double tsal= teachstaff.calcsalary();
      double asal= adminstaff.calcsalary();
        Console.WriteLine("College Name" + teachstaff.Collegename+
            "Tname: "+teachstaff.Name+
          "Tsalary: "+tsal+
          "Aname: "+adminstaff.Name+
          "Asalary: "+asal);
    }
}