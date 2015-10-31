using StudyDAL;
using StudyModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyBLL
{
    public class BLL
    {
        public static int sysLogin(Admin m)
        {
            string str = "adminValid";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("adminUser",m.AdminUser),
                new SqlParameter("adminPwd",m.AdminPwd)
            };
            DAL d = new DAL();
            return Int32.Parse(d.ExecuteScalar(str, sqlParameter));
        }
    }
}
