using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;
using System.Data.OleDb;
using System.Configuration;


namespace AccessDAL
{
  public class OleDbHelper
    {
        ///<summary>
        ///针对Access 数据库操作的通用类
        ///</summary>
        ///
      private static string connString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source= "
                             + ConfigurationManager.AppSettings["DbPath"];
      
      //private static string connString = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\AddressList.mdb";
      
    

      ///<summary>
        ///设置数据库连接字符串；
        ///</summary>
      
        public static string ConnectionString
        {
            get { return connString; }
            set { connString = value; }
        }

       //对数据库进行非连接的查询操作方法，获得多条查询记录 
        public static DataTable ExecuteDataTable(string commandText, OleDbParameter[] parameters)
        {
            DataTable data = new DataTable();//实例化DataTable，用于装载查询结果集
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
                    //通过包含查询OleDb的OleDbCommand实例来实例化OleDbDataAdapter
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    adapter.Fill(data);//填充DataTable
                }
            }
            return data;
        }
       /// <summary>
       /// /
       /// </summary>
       /// <param name="commandText"></param>
       /// <returns></returns>
        public static DataTable ExecuteDataTable(string commandText)
        {
            return ExecuteDataTable(commandText,  null);
        }
       

        //编写ExecuteReader方法对数据库连接式操作，获取多条记录
        public static OleDbDataReader ExecuteReader(string commandText,
               OleDbParameter[] parameters)
         {
             OleDbConnection connection = new OleDbConnection(connString);
             OleDbCommand command = new OleDbCommand(commandText, connection);
             
             if (parameters != null)
             {
                 foreach (OleDbParameter parameter in parameters)
                 {
                     command.Parameters.Add(parameter);
                 }
             }
             connection.Open();
             return command.ExecuteReader(CommandBehavior.CloseConnection);
         }

        public static OleDbDataReader ExecuteReader(string commandText)
         {
             return  ExecuteReader(commandText, null);
         }
        

        /////编写ExecuteScalar

         public static Object ExecuteScalar(string commandText, OleDbParameter[] parameters)
         {
             Object result = null;
             using (OleDbConnection connection = new OleDbConnection(connString))
             {
                 using (OleDbCommand command = new OleDbCommand(commandText, connection))
                 {
                     //设置command的CommandType为指定的CommandType
                    
                     //如果同时传入了参数，则添加这些参数
                     if (parameters != null)
                     {
                         foreach (OleDbParameter parameter in parameters)
                         {
                             command.Parameters.Add(parameter);
                         }
                     }
                     connection.Open();
                    
                     result = command.ExecuteScalar();
                 }
             }
             return result;
         }
            

         public static object  ExecuteScalar(string commandText)
         {
             return ExecuteScalar(commandText,  null);
         }
        

        ///////////////////编写ExecuteNonQuery

         public static int ExecuteNonQuery(string commandText, OleDbParameter[] parameters)
         {
             int count =0;
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
                     connection.Open();
                     count = command.ExecuteNonQuery();
                 }
             }
             return count;
         }


         public static int ExecuteNonQuery(string commandText)
         {
             return ExecuteNonQuery(commandText, null);
         }
       
    }
    }

