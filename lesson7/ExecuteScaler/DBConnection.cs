using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteScaler
{
    class DBConnection
    {
        static SqlConnection conn;
        static DBConnection ()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Server=.\\SQLEXPRESS;Initial Catalog=study;Integrated Security=SSPI";
            conn.Open();
        }

        public void ExecuteScaler ( String command)
        {
            SqlCommand selectCMD = new SqlCommand();
            selectCMD.Connection = conn;
            selectCMD.CommandType = CommandType.Text;//该命令也可以不写，因为是默认值

            //(3)设置执行的SQL命令
            selectCMD.CommandText = command;

            //（５）执行ExecuteNonQuery（）
            int rows = selectCMD.ExecuteNonQuery();
        }
    }
}
