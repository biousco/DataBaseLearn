using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SQLDAL
{
    //针对表ContactGroup的数据访问类
    public class ContactGroup
    {
        public ContactGroup()
        { }

        #region Method
        
        //根据查询条件获取分组列表
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID, GroupName, Memo ");
            strSql.Append("from [ContactGroup] ");
            if (strWhere.Trim() != "")
                strSql.Append(" where " + strWhere);

            return SqlDbHelper.ExecuteDataTable(strSql.ToString());
        }

        //增加一条数据
        public bool Add(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [ContactGroup] (GroupName, Memo) ");
            strSql.Append("values (@GroupName, @Memo); select @@IDENTITY");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@GroupName", SqlDbType.VarChar, 50), 
                                           new SqlParameter ("@Memo", SqlDbType.VarChar , 200)
                                       };
            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;

            int rows = Convert.ToInt32(
                SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters));
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        //根据分组编号，获取分组信息
        public Model.ContactGroup GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Id, GroupName, Memo from [ContactGroup] ");
            strSql.Append("where Id = @Id ");
            SqlParameter[] parameters ={ new SqlParameter ("@Id", SqlDbType.Int, 4) };
            parameters[0].Value = Id;

            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(),
                                   CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["GroupName"] != null && dt.Rows[0]["GroupName"].ToString() != "")
                {
                    model.GroupName = dt.Rows[0]["GroupName"].ToString();
                }
                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        //根据分组名称，获取分组信息
        public Model.ContactGroup GetModel(string groupName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Id, GroupName, Memo from [ContactGroup] ");
            strSql.Append("where GroupName = @GroupName ");
            SqlParameter[] parameters ={ new SqlParameter ("@GroupName", SqlDbType.NVarChar, 50) };
            parameters[0].Value = groupName;
            Model.ContactGroup model = new Model.ContactGroup();
            DataTable dt = SqlDbHelper.ExecuteDataTable(strSql.ToString(), CommandType.Text, parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["GroupName"] != null && dt.Rows[0]["GroupName"].ToString() != "")
                {
                    model.GroupName = dt.Rows[0]["GroupName"].ToString();
                }
                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        //删除分组
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ContactGroup ");
            strSql.Append("where Id=@Id ");
            SqlParameter[] parameters ={ new SqlParameter ("@Id",SqlDbType.Int,4) };
            parameters[0].Value = Id;
            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //更新分组信息
        public bool Update(Model.ContactGroup model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ContactGroup set ");
            strSql.Append("GroupName=@GroupName, ");
            strSql.Append("Memo=@Memo ");
            strSql.Append("where Id=@Id ");
            SqlParameter[] parameters ={ 
                                           new SqlParameter ("@GroupName",SqlDbType.NVarChar,50),
                                           new SqlParameter ("@Memo",SqlDbType.NVarChar,200),
                                           new SqlParameter ("@Id",SqlDbType.Int,4)
                                       };

            parameters[0].Value = model.GroupName;
            parameters[1].Value = model.Memo;
            parameters[2].Value = model.Id;
            int rows = SqlDbHelper.ExecuteNonQuery(strSql.ToString(), CommandType.Text, parameters);
            if (rows > 0)
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
