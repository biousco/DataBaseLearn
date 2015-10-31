using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsConnection
{
    class WindowsConnection
    {
        static void Main(string[] args)
        {
            UserConnection.Main2();
            string connStr = "Server=.\\SQLEXPRESS;Initial Catalog=study;Integrated Security=SSPI";

            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();

                if(conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("数据库已连接！通过Windows验证！");
                    Console.WriteLine("\nDataSource: {0}", conn.DataSource);
                    Console.WriteLine("Database: {0}", conn.Database);
                    Console.WriteLine("ConnectionTimeout: {0}", conn.ConnectionTimeout);
                    conn.Close();
                }
            }catch
            {
                Console.WriteLine("数据库连接失败");
            }
            finally
            {
                conn.Dispose();
            }
            if(conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("\n数据库连接关闭");
            }
            Console.ReadLine();
        }

    }
}
