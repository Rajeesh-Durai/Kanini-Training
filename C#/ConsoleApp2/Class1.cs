using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {

            SqlConnection conn;


            public void OpenConn()
            {
                conn = new SqlConnection("Data source=DESKTOP-PNAFED7\\SQLEXPRESS; database = sample; integrated security = SSPI");
                try
                {
                    conn.Open();
                    Console.WriteLine("Opened");
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                    Console.WriteLine("Connection Not established");

                }
                //conn.Open();
                //Console.WriteLine(conn);
                //Console.WriteLine("opened");
            }
            public void CreateTable()
            {
                if (conn != null)
                {
                    SqlCommand cmd = new SqlCommand("create table stud_details(rno int, name nvarchar(20))", conn);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("table stud_details created");
                }
            }
            public void InsertTable()
            {
                if (conn != null)
                {
                    SqlCommand cmd = new SqlCommand("insert into stud_details values(91,'Mozhi')", conn);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("insert into stud_details values(90,'Mozhi')", conn);
                    cmd1.ExecuteNonQuery();
                    Console.WriteLine("Row Inserted");
                }
            }
            public void UpdateTable()
            {
                if (conn != null)
                {
                    SqlCommand cmd = new SqlCommand("update stud_details set rno = 58 where name = 'Abimannan'", conn);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Updated");
                }
            }
            public void DeleteTable()
            {
                if (conn != null)
                {
                    SqlCommand cmd = new SqlCommand("Delete from stud_details", conn);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Deleted");
                }
            }
            public void ReadTable()
            {
                SqlCommand cmd = new SqlCommand("select *from stud_details", conn);
                SqlDataReader sdr;
                if (conn != null)
                {
                    sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        Console.WriteLine("Table is Empty");
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            Console.WriteLine($"{sdr["rno"]} {sdr["name"]}");
                        }
                    }
                }
            }
            public void CloseConn()
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("Closed");
                }
            }


        
    }
}

