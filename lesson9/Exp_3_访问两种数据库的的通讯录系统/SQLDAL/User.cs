using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Model;
using IDAL;

namespace SQLDAL
{
   /// <summary>
   /// 访问并操作数据表user的类
   /// </summary>
    
    public  class User:IUser 
    {
       public User() { }

       #region Method

        //判断用户名，密码是否正确
       public bool Login(string userName, string userPassword)
       {
           string strSql="select count(1) from [User] where UserName=@UserName and Password=@UserPassword ";
           SqlParameter[] parameters ={ 
                           new SqlParameter ("@UserName",SqlDbType .VarChar,50), 
                           new SqlParameter ("@UserPassword",SqlDbType .VarChar ,50)
                                      };
           parameters[0].Value = userName;
           parameters[1].Value = userPassword; 
           
           int n = Convert.ToInt32(SqlDbHelper.ExecuteScalar(strSql,CommandType.Text, parameters));
            if (n == 1)
               return true;
           else
               return false;
       }


        //////////更新用户密码
       public bool Update(Model.User model)
       {
           StringBuilder strSql = new StringBuilder();
           strSql.Append("update [User] set");
           strSql.Append(" Password=@Password");
           strSql.Append(" where UserName=@UserName ");
           SqlParameter[] parameters ={ 
                           new SqlParameter ("@Password",SqlDbType .VarChar,50), 
                           new SqlParameter ("@UserName",SqlDbType .VarChar ,50)
                                      };
           parameters[0].Value = model.Password;
           parameters[1].Value = model.UserName;
           int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(),
                               CommandType.Text, parameters);
           if (rows  == 1)
               return true;
           else
               return false;
       }
       #endregion Method

    }
}
