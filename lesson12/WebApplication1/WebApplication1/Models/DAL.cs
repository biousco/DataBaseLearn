using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class DAL
    {
        //数据访问层只负责与数据库的交互
        /// <summary>
        /// 执行操作(DAL类)
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        // 返回数据库连接字符串
        private static SqlConnection con()
        {
            return new SqlConnection("Data Source=BIOUSCO\\SQLEXPRESS;Initial Catalog=study;Integrated Security=True");
        }

        //调用存储过程进行登录数据的判断的方法
        public string ExecuteScalar(string str, SqlParameter[] sql)  //这是自己定义的ExecuteScalar方法
        {
            SqlConnection con = DAL.con();  //获得连接字符串
            try
            {
                con.Open();
                SqlCommand com = new SqlCommand(str, con);
                com.CommandType = CommandType.StoredProcedure;  //使用存储过程
                com.Parameters.AddRange(sql);  //传入参数
                //注意这里的com.ExecuteScalar()方法是系统的的ExecuteScalar方法
                return Convert.ToString((com.ExecuteScalar())); //返回受影响的行数(例如影响的行数为1，那么返回数值1到BLL层,然后BLL层将数值1返回到UI层)
            }
            catch (Exception Error)
            {
                throw Error;
            }
            finally
            {
                con.Close();
            }
        }
    }
}