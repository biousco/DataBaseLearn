using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public  class Contact
    {
        //针对Contact表创建的类
        public Contact() { }

        #region Model

        private int _id;
        private string _name;
        private string _phone;
        private string _email;
        private string _qq;
        private string _workunit;
        private string _officephone;
        private string _homephone;
        private string _homeaddress;
        private string _memo;
        private int _groupid;
      
         ///<summary>
         ///自动编号
         ///</summary>
         public int Id
         {
             set { _id = value; }
             get { return _id; }
         
         }
         ///<summary>
         ///联系人名称
         ///</summary>
         public string Name
         {
             set { _name = value; }
             get { return _name; }

         }
         ///<summary>
         ///手机
         ///</summary>
         public string Phone
         {
             set { _phone = value; }
             get { return _phone; }

         }
         ///<summary>
         ///电子邮件
         ///</summary>
         public string Email
         {
             set { _email = value; }
             get { return _email; }

         }
         ///<summary>
         ///qq
         ///</summary>
         public string QQ
         {
             set { _qq = value; }
             get { return _qq; }

         }
         ///<summary>
         ///工作单位
         ///</summary>
         public string WorkUnit
         {
             set { _workunit = value; }
             get { return _workunit; }

         }
         ///<summary>
         ///办公电话
         ///</summary>
         public string OfficePhone
         {
             set { _officephone = value; }
             get { return _officephone; }

         }
         ///<summary>
         ///家庭住址
         ///</summary>
         public string HomeAddress
         {
             set { _homeaddress = value; }
             get { return _homeaddress; }

         }
         ///<summary>
         ///家庭电话
         ///</summary>
         public string HomePhone
         {
             set { _homephone = value; }
             get { return _homephone; }

         }

       ///<summary>
         ///备注
         ///</summary>
         public string Memo
         {
             set { _memo = value; }
             get { return _memo; }

         }

         ///<summary>
         ///分组编号
         ///</summary>
         public int GroupId
         {
             set { _groupid = value; }
             get { return _groupid; }

         }

        #endregion Model
    }
 }
