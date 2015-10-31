using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用ConnectionStringBuilder构建连接字符串
            SqlConnectionStringBuilder strConn = new SqlConnectionStringBuilder();
            strConn.DataSource = ".\\SQLEXPRESS";
            strConn.InitialCatalog = "study";
            strConn.IntegratedSecurity = true;
            using (SqlConnection conn = new SqlConnection(strConn.ConnectionString))
            {
                //  string strSQL = "select * from student"; //sql字符串
                // SqlCommand cmd = new SqlCommand("selectClass",conn);
                SqlCommand cmd = new SqlCommand(); //创建command对象
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "selectClass";
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();  //执行ExecuteReader(),创建DataReader对象
                if (reader.HasRows)  //判读reader里是否还有记录
                {
                    int rows = 0;
                    Console.WriteLine("*******Records of student******\n");
                    while (reader.Read())  //判断是否读完
                    {
                        for (int i = 0; i < reader.FieldCount; i++) //FieldCount属性得到字段的个数
                        {
                            //GetName(i)得到第i个字段的名称,GetValue(i)得到第i个字段的值
                            Console.Write("{0}:{1}", reader.GetName(i), reader.GetValue(i));
                        }
                        Console.WriteLine();
                        rows++;
                    }
                    Console.WriteLine("\n共{0}行记录", rows); //输出共有多少条记录
                }
                reader.Close();  //关闭reader
            }
            Console.ReadLine();
        }
    }
}
