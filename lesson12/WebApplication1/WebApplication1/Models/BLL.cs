using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1.Models
{
    public class BLL
    {
        /// <summary>
        /// 用户登录(BLL类)：负责与界面层 、数据访问层的联系
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static int sysLogin(User m)
        {
            string str = "adminValid"; //存储过程名称
            SqlParameter[] sqlParameter =
                {
                    //将UI层传递过来的用户名称和密码赋值给存储过程中的变量分别是adminUser和adminPwd(注意大小写)
                    new SqlParameter("@adminUser",SqlDbType.VarChar,20),
                    new SqlParameter("@adminPwd",SqlDbType.VarChar,20)
                };
            sqlParameter[0].Value = m.AdminUser;  //为参数指定值得来源
            sqlParameter[1].Value = m.AdminPwd;

            DAL d = new DAL();
            return int.Parse(d.ExecuteScalar(str, sqlParameter));//把存储过程名和参数传入
        }
    }
}