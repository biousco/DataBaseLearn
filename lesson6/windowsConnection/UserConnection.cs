using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsConnection
{
    class UserConnection
    {
        public static void Main2()
        {
            string connStr = "Server=.\\SQLEXPRESS;database=study;User ID=ml;Password=111;Trusted_Connection=False";
            SqlConnection conn;
            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("数据库已连接!通过Sql用户名");
                    Console.WriteLine("\nDataSource:{0}", conn.DataSource);
                    Console.WriteLine("Database:{0}", conn.Database);
                    Console.WriteLine("ConnectionTimeOut:{0}", conn.ConnectionTimeout);
                }
            }
            if (conn.State == ConnectionState.Closed)
            {
                Console.WriteLine("\n数据库连接已关闭!");
            }
        }
    }
}
