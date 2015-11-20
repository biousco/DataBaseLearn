using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace AccessDAL
{
    //数据访问类：User
    public partial class User
    {
        public User()
        { }

        #region Method

        //判断用户名、密码是否正确
        public bool Login(string userName, string userPassword)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [User]");
            strSql.Append(" where UserName=@UserName and Password=@UserPassword");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@UserName", OleDbType.VarChar,50),
                                              new OleDbParameter("@UserPassword", OleDbType.VarChar,50)
                                          };
            parameters[0].Value = userName;
            parameters[1].Value = userPassword;
            int n = Convert.ToInt32(OleDbHelper.ExecuteScalar(strSql.ToString(),parameters));
            if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //更新用户密码
        public bool Update(Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [User] set ");
            strSql.Append("[Password]=@Password ");
            strSql.Append("where [UserName]=@UserName ");
            OleDbParameter[] parameters = {
                                              new OleDbParameter("@Password", OleDbType.VarChar, 50),
                                              new OleDbParameter("@UserName", OleDbType.VarChar, 50)
                                          };
            parameters[0].Value = model.Password;
            parameters[1].Value = model.UserName;
            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
            if (rows == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        #endregion Method
    }
}
