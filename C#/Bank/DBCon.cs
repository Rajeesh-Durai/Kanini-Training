using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class DBCon
    {
        SqlConnection con;
        public void OpenCon(String connection)
        {
            con = new SqlConnection(connection);
            try
            {
                con.Open();
                Console.WriteLine("Connected");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Connection not established");
            }
        }
        public void CreateTable()
        {
            SqlCommand command1 = new SqlCommand("create table Region(Region_ID int primary key, Region_Name nvarchar(25))",con);
            try
            {
                command1.ExecuteNonQuery();
                Console.WriteLine("Region table created");
            }
            catch (SqlException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Region table not created");
            }
            
            SqlCommand command2 = new SqlCommand("create table Customer_tran(Customer_ID int primary key, Deposit_amt decimal(9,4),Balance decimal(9,4),Amt_trans_date date)", con);
            try
            {
                command2.ExecuteNonQuery();
                Console.WriteLine("Customer transaction table created");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Customer transaction table not created");
            }
            SqlCommand command3 = new SqlCommand("create table Customer_nodes(Customer_ID int foreign key references Customer_tran, Node_ID int primary key, Region_ID int Foreign key references Region)", con);
            try
            {
                command3.ExecuteNonQuery();
                Console.WriteLine("Customer node table created");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Customer node table not created");
            }
        }
        public void InsertValue()
        {
            SqlCommand insertval1 = new SqlCommand("insert into Region values(101,'Chennai'),(102,'Tirunelveli'),(103,'Coimbatore'),(104,'Trichy'),(105,'Madurai')",con);
            try
            {
                insertval1.ExecuteNonQuery();
                Console.WriteLine("values inserted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("values not inserted");
            }
            SqlCommand insertval2 = new SqlCommand("insert into Customer_tran values(1,1000.0,4563.25,'2023/04/17'),(2,2500.13,7550.98,'2023/03/01'),(3,500.0,2000.12,'2023/04/06'),(4,7500.0,9205.20,'2023/03/07'),(5,600.00,6501.25,'2023/04/15')", con);
            try
            {
                insertval2.ExecuteNonQuery();
                Console.WriteLine("values inserted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("values not inserted");
            }
            SqlCommand insertval3= new SqlCommand("insert into Customer_nodes values(1,1001,101),(2,1002,102),(3,1003,103),(4,1004,104),(5,1005,105)", con);
            try
            {
                insertval3.ExecuteNonQuery();
                Console.WriteLine("values inserted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("values not inserted");
            }
        }
        public void query1()
        {
            SqlCommand cmd = new SqlCommand("select reg.Region_Name, count( distinct Node_ID) count_of_nodes from Customer_nodes node inner join Region reg on node.Region_ID=reg.Region_ID group by reg.Region_Name",con);
            SqlDataReader reader= cmd.ExecuteReader();
            while(reader.Read()) 
            {
                Console.WriteLine(reader[0] + ":" + reader[1]+" nodes");
            }
        }
        public void query2()
        {
            SqlCommand cmd = new SqlCommand("select reg.Region_Name, count( distinct node.Customer_ID) customer_counts from Customer_nodes node inner join Region reg on node.Region_ID=reg.Region_ID group by reg.Region_Name", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + ":" + reader[1] + " customers");
            }
        }
        public void query3()
        {
            SqlCommand cmd = new SqlCommand("select count(*) Total_count , AVG(Deposit_amt) Average_amount from Customer_tran", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Total count: "+reader[0]);
                Console.WriteLine("Average Amt: " + reader[1]);
            }
        }

        public void query4()
        {
            SqlCommand cmd = new SqlCommand("select Customer_ID, Deposit_amt+Balance as TOT_AMT from Customer_tran", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Customer id: "+reader[0]);
                Console.WriteLine("Total Amt: " + reader[1]);
            }
        }
        public void query5()
        {
            SqlCommand cmd = new SqlCommand("select count(Customer_ID)No_of_Customer from Customer_tran where Deposit_amt>0",con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Total no of Customers: " + reader[0]);
            }
        }

    }
}
