using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1)连接数据库
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Server=.\\SQLEXPRESS;Initial Catalog=study;Integrated Security=SSPI";

            //(2)创建SqlCommand对象
            SqlCommand selectCMD = new SqlCommand();
            selectCMD.Connection = conn;
            selectCMD.CommandType = CommandType.Text;//该命令也可以不写，因为是默认值

            //(3)设置执行的SQL命令
            selectCMD.CommandText =
                "insert into dbo.student(s_id,s_name) values('s999','林浩笙')" +
                "UPDATE dbo.student SET s_name='林浩笙2' WHERE s_id='s999'" + 
                "delete dbo.student where s_id='s999'";
            //(4)打开连接
            conn.Open();
            //（５）执行ExecuteNonQuery（）
            int rows = selectCMD.ExecuteNonQuery();

            Console.WriteLine("{0}行被修改。", rows);
            Console.ReadLine();

            //(6)断开连接
            conn.Close();
        }
    }
}
