using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace AccessDAL
{
    public class OleDbHelper
    {
        private static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + ConfigurationManager.AppSettings["DbPath"];

        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }

        public static DataTable ExecuteDataTable(string commandText, OleDbParameter[] parameters)
        {
            DataTable data = new DataTable(); //实例化DataTable，用于装载查询结果集
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (OleDbParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    //通过包含查询SQL的OleDbCommand实例来实例化OleDbDataAdapter
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(data); //填充DataTable
                }            
            }
            return data;
        }

        //重载ExecuteDataTable方法
        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText, null);
        }

        public static OleDbDataReader ExecuteReader(string commandText, OleDbParameter[] parameters)
        {
            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(commandText, connection);

            //如果同时传入了参数，则添加这些参数
            if (parameters != null)
            {
                foreach (OleDbParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            connection.Open();

            //CommandBehavior.CloseConnection参数指示关闭Reader对象时关闭与其关联的Connection对象
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        //重载ExecuteReader方法
        public static OleDbDataReader ExecuteReader(string commandText)
        {
            return ExecuteReader(commandText, null);
        }

        public static Object ExecuteScalar(string commandText, OleDbParameter[] parameters)
        {
            object result = null;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using (OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        foreach (OleDbParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }
                    connection.Open(); //打开数据库连接
                    result = command.ExecuteScalar();
                }
            }
            return result; //返回查询结果的第1行第1列，忽略其他行和列
        }

        //重载ExecuteScalar方法
        public static Object ExecuteScalar(string commandText)
        {
            return ExecuteScalar(commandText, null);
        }

        public static int ExecuteNonQuery(string commandText, OleDbParameter[] parameters)
        {
            int count = 0;
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                using(OleDbCommand command = new OleDbCommand(commandText, connection))
                {
                    //如果同时传入了参数，则添加这些参数
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++ )
                        {
                            command.Parameters.Add(parameters[i]);
                        }
                    }
                    connection.Open(); //打开数据库连接
                    count = command.ExecuteNonQuery();
                }
            }
            return count; //返回执行增、删、改操作之后，数据库中受影响的行数
        }

        //重载ExecuteNonQuery方法
        public static int ExecuteNonQuery(string commandText)
        {
            return ExecuteNonQuery(commandText, null);
        }
    }
}
