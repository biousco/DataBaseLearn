using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using IDAL;

namespace AccessDAL
{
    /// <summary>
    ///  操作Contact表的类
    /// </summary>
   public  class Contact:IContact
    {
        public Contact() { }
        #region Method
        //根据分组编号获取该分组下的联系人数量
        public int GetContactCount(int groupId)
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("select count(1) from Contact ");
            buffer.Append("where GroupId=@GroupId ");

            OleDbParameter[] parameters ={ 
                           new OleDbParameter ("@GroupId",OleDbType.Integer,4)
                                       };
            parameters[0].Value = groupId;

            return int.Parse(OleDbHelper.ExecuteScalar(buffer.ToString(), parameters).ToString());
        }

        /////根据查询条件，获取联系人列表

        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Contact.Id,Name,Phone,Email,QQ,GroupName ");
            strSql.Append("from Contact,ContactGroup where Contact.GroupId=ContactGroup.Id ");

            if (strWhere.Trim() != "")
                strSql.Append(" and " + strWhere);
            strSql.Append(" order by Contact.Id desc");

            return OleDbHelper.ExecuteDataTable(strSql.ToString());
        }


        //////增加一条记录
        public bool Add(Model.Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Contact( ");
            strSql.Append("Name,Phone,Email,QQ,WorkUnit,OfficePhone,HomeAddress,HomePhone,Memo,GroupId) ");
            strSql.Append("values ( ");
            strSql.Append("@Name,@Phone,@Email,@QQ,@WorkUnit,@OfficePhone,@HomeAddress,@HomePhone,@Memo,@GroupId) ");

            OleDbParameter[] parameters ={ 
                           new OleDbParameter ("@Name",OleDbType.VarChar,50), 
                           new OleDbParameter ("@Phone",OleDbType .VarChar ,11),
                           new OleDbParameter ("@Email",OleDbType .VarChar,50), 
                           new OleDbParameter ("@QQ",OleDbType .VarChar ,20),          
                           new OleDbParameter ("@WorkUnit",OleDbType .VarChar,200), 
                           new OleDbParameter ("@OfficePhone",OleDbType .VarChar ,20),           
                           new OleDbParameter ("@HomeAddress",OleDbType .VarChar,200), 
                           new OleDbParameter ("@HomePhone",OleDbType .VarChar ,20),            
                           new OleDbParameter ("@Memo",OleDbType .VarChar,200), 
                           new OleDbParameter ("@GroupId",OleDbType.Integer,4)
                                           
                                       };
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Phone;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.QQ;
            parameters[4].Value = model.WorkUnit;
            parameters[5].Value = model.OfficePhone;
            parameters[6].Value = model.HomeAddress;
            parameters[7].Value = model.HomePhone;
            parameters[8].Value = model.Memo;
            parameters[9].Value = model.GroupId;

            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(),parameters);
            if (rows > 0)
                return true;
            else
                return false;
        }

        /////////////////////删除一条记录
        ////////删除分组
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Contact ");
            strSql.Append("where Id=@Id ");
            OleDbParameter[] parameters ={ 
                           new OleDbParameter ("@Id",OleDbType.Integer,4) };

            parameters[0].Value = Id;
            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
                return true;
            else
                return false;
        }

        ///////////////更新一条记录

        public bool Update(Model.Contact model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Contact set ");
            strSql.Append("Name=@Name, ");
            strSql.Append("Phone=@Phone, ");
            strSql.Append("Email=@Email, ");
            strSql.Append("QQ=@QQ, ");
            strSql.Append("WorkUnit=@WorkUnit, ");
            strSql.Append("OfficePhone=@OfficePhone ,");
            strSql.Append("HomeAddress=@HomeAddress, ");
            strSql.Append("HomePhone=@HomePhone, ");
            strSql.Append("Memo=@Memo, ");
            strSql.Append("GroupId=@GroupId ");
            strSql.Append("where Id=@Id ");

            OleDbParameter[] parameters ={ 
                           new OleDbParameter ("@Name",OleDbType.VarChar,50), 
                           new OleDbParameter ("@Phone",OleDbType .VarChar ,11),
                           new OleDbParameter ("@Email",OleDbType .VarChar,50), 
                           new OleDbParameter ("@QQ",OleDbType .VarChar ,20),          
                           new OleDbParameter ("@WorkUnit",OleDbType .VarChar,200), 
                           new OleDbParameter ("@OfficePhone",OleDbType .VarChar ,20),           
                           new OleDbParameter ("@HomeAddress",OleDbType .VarChar,200), 
                           new OleDbParameter ("@HomePhone",OleDbType .VarChar ,20),            
                           new OleDbParameter ("@Memo",OleDbType .VarChar,200), 
                           new OleDbParameter ("@GroupId",OleDbType.Integer ,4) ,
                           new OleDbParameter ("@Id",OleDbType.Integer ,4)
                           };

            parameters[0].Value = model.Name;
            parameters[1].Value = model.Phone;
            parameters[2].Value = model.Email;
            parameters[3].Value = model.QQ;
            parameters[4].Value = model.WorkUnit;
            parameters[5].Value = model.OfficePhone;
            parameters[6].Value = model.HomeAddress;
            parameters[7].Value = model.HomePhone;
            parameters[8].Value = model.Memo;
            parameters[9].Value = model.GroupId;
            parameters[10].Value = model.Id;
            int rows = OleDbHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            if (rows > 0)
                return true;
            else
                return false;
        }


        ///////////根据联系人编号，获取联系人信息
        public Model.Contact GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Name,Phone,Email,QQ,WorkUnit,OfficePhone,HomeAddress,HomePhone,Memo,GroupId ");
            strSql.Append("from Contact where Id=@Id ");
            OleDbParameter[] parameters ={ 
                           new OleDbParameter ("@Id",OleDbType.Integer,4) };

            parameters[0].Value = Id;
            Model.Contact model = new Model.Contact();
            DataTable dt = OleDbHelper.ExecuteDataTable(strSql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Id"] != null && dt.Rows[0]["Id"].ToString() != "")
                {
                    model.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                }
                if (dt.Rows[0]["Name"] != null && dt.Rows[0]["Name"].ToString() != "")
                {
                    model.Name = dt.Rows[0]["Name"].ToString();
                }
                if (dt.Rows[0]["Phone"] != null && dt.Rows[0]["Phone"].ToString() != "")
                {
                    model.Phone = dt.Rows[0]["Phone"].ToString();
                }
                if (dt.Rows[0]["Email"] != null && dt.Rows[0]["Email"].ToString() != "")
                {
                    model.Email = dt.Rows[0]["Email"].ToString();
                }
                if (dt.Rows[0]["QQ"] != null && dt.Rows[0]["QQ"].ToString() != "")
                {
                    model.QQ = dt.Rows[0]["QQ"].ToString();
                }
                if (dt.Rows[0]["WorkUnit"] != null && dt.Rows[0]["WorkUnit"].ToString() != "")
                {
                    model.WorkUnit = dt.Rows[0]["WorkUnit"].ToString();
                }
                if (dt.Rows[0]["OfficePhone"] != null && dt.Rows[0]["OfficePhone"].ToString() != "")
                {
                    model.OfficePhone = dt.Rows[0]["OfficePhone"].ToString();
                }
                if (dt.Rows[0]["HomeAddress"] != null && dt.Rows[0]["HomeAddress"].ToString() != "")
                {
                    model.HomeAddress = dt.Rows[0]["HomeAddress"].ToString();
                }
                if (dt.Rows[0]["HomePhone"] != null && dt.Rows[0]["HomePhone"].ToString() != "")
                {
                    model.HomePhone = dt.Rows[0]["HomePhone"].ToString();
                }

                if (dt.Rows[0]["Memo"] != null && dt.Rows[0]["Memo"].ToString() != "")
                {
                    model.Memo = dt.Rows[0]["Memo"].ToString();
                }
                if (dt.Rows[0]["GroupId"] != null && dt.Rows[0]["GroupId"].ToString() != "")
                {
                    model.GroupId = int.Parse(dt.Rows[0]["GroupId"].ToString());
                }

                return model;

            }
            else
            {
                return null;
            }
        }

        #endregion Method
    }
}
