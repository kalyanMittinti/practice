using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace practice
{
    class Program
    {
      public static void Main()
        {
            Console.WriteLine("enter your eno");
            string eno = Console.ReadLine();
           
     
            Console.WriteLine("enter your ename");
            string ename = Console.ReadLine();

            Console.WriteLine("enter your salary");
            string salary = Console.ReadLine();

            Console.WriteLine("enter your phonenumber");
            string phonenumber = Console.ReadLine();

            
            Console.WriteLine("enter your city");
            string city = Console.ReadLine();

        
            

            Console.WriteLine("hello"+ eno+ename+salary+phonenumber+city);

            Program.m1();

        }
        public static void m1(database d )
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=KALYAN\SQLEXPRESS;Initial Catalog=csharp;User ID=sa;Password=abc");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tab values('" + d.eno + "','" + d.ename + "','" + d.salary + "','" + d.phonenumber + "','" + d.city + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}
