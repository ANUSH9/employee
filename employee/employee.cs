using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace employee
{
    public class employee
    {
        public static string sqlConnect = @"Data Source=DESKTOP-F0DS2US\SQLEXPRESS;Initial Catalog = Employee; Integrated Security = True";
        

        public string Insertemp()
        {
            Console.Write("Enter Employee Id: ");
            int empID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter Employee email: ");
            string Email = Console.ReadLine();

            Console.Write("Enter Employee Mobile: ");
            int Mobile = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee address: ");
            string empAddress = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnect);
            SqlCommand obj1 = new SqlCommand("insert into Employee values(" + empID + ",'" + empName + "','" + Email + "'," + Mobile + ",'" + empAddress + "')", sqlConnection);
            sqlConnection.Open();
            obj1.ExecuteNonQuery();
            sqlConnection.Close();
            return "Inserted";
        }
        

    }
    
}
