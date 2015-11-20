using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public  class ContactGroup
    {
        //针对ContactGroup表创建的类

        public ContactGroup() { }

        #region Model

         private int _id;
         private string _groupname;
         private string _memo;
         ///<summary>
         ///自动编号
         ///</summary>
         public int Id
         {
             set { _id = value; }
             get { return _id; }
         
         }
         ///<summary>
         ///分组名称
         ///</summary>
         public string GroupName
         {
             set { _groupname = value; }
             get { return _groupname; }

         }
       ///<summary>
         ///备注
         ///</summary>
         public string Memo
         {
             set { _memo = value; }
             get { return _memo; }

         }
        #endregion Model
    }
}
