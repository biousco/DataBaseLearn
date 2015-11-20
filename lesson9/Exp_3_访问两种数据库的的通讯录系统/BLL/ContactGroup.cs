using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Model;
//using AccessDAL;

namespace BLL
{
    //针对ContactGroup表操作的业务逻辑类
    //该类除了将表示层的数据转发给数据访问层外，还负责业务逻辑，如在
    //增加分组时，判断分组名称是否为空，判断分组名称是否重复，删除时，判断
    //该分组下是否存在联系人，如果存在，不允许删除该分组
    public  class ContactGroup
    {
       //AccessDAL.ContactGroup group = new AccessDAL.ContactGroup();
        //多态：子类对象用父类型表示
       IDAL.IContactGroup group = DALFactory.DataAccessFactory.CreateContactGroup();
      
        public DataTable GetList(string strWhere)
       {
           return group.GetList(strWhere);
       }
       ///
       public Model .ContactGroup GetModel(string groupName)
       {
           return group.GetModel(groupName);
       }
       ////
       public Model.ContactGroup GetModel(int id)
       {
           return group.GetModel(id);
       }
       ////
       public bool CheckModel(Model .ContactGroup model,out string msg)
       {
           bool check = true;
           msg = "";
           //业务逻辑，判断分组名称是否为空
           if (model.GroupName == "")
           {
               msg = "分组名称不能为空";
               check = false;

           }
           return check;

       }
       /////
       public bool Add(Model.ContactGroup model, out string msg)
       {
           if (!CheckModel(model, out msg))
           {
               return false;
           }
           else
           { 
           //业务逻辑，判断分组名称是否同数据库中已有的重复
               Model.ContactGroup modelCheck = GetModel(model.GroupName);
               if (modelCheck != null)
               {
                   msg = "分组名称重复";
                   return false;
               }
               else
               {
                   return group.Add(model );
               }
           }
       
       }

       ////////
       public bool Delete(int Id)
       {
           //AccessDAL.Contact contact = new AccessDAL.Contact();
           IDAL.IContact contact = DALFactory.DataAccessFactory.CreateContact();

           int count = contact.GetContactCount(Id);
           if (count > 0)
           {
               return false;//如果该分组下存在联系人，不能删除该分组
           }
           else
           {
               return group.Delete(Id);
           }
       }

       ///////
       public bool Update(Model.ContactGroup model, out string msg)
       {
           if (!CheckModel(model, out msg))
           {
               return false;
           }
           else
           {
               
              return group.Update(model);
              
           }
       }

    }
}
