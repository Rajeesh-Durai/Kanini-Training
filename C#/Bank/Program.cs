using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the data source and initial catalog to connect with database");
            StringBuilder connection = new StringBuilder();
            connection.Append("data source=");
            connection.Append(Console.ReadLine());
            connection.Append(";Initial catalog=");
            connection.Append(Console.ReadLine());
            connection.Append(";Integrated security=SSPI;");
            DBCon connect = new DBCon();
            connect.OpenCon(connection.ToString());
            /*connect.CreateTable();
            connect.InsertValue();
            connect.query1();
            connect.query2();
            connect.query3();*/
            //connect.query4();
            connect.query5();
        }
    }
}