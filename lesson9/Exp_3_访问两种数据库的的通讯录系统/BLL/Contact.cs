using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;
using Model;
// using AccessDAL; 
using System.Data;

namespace BLL
{
   public  class Contact
    {
        //针对Contact表的业务处理逻辑类
        //把表示层的数据转发给数据访问层
       //AccessDAL.Contact dal = new AccessDAL.Contact();
       IDAL.IContact dal = DALFactory.DataAccessFactory.CreateContact();  //多态：子类对象用父类型表示

        public int GetContactGount(int groupId)
        {
            return dal.GetContactCount(groupId);
        }

        ///
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        ///
       
        ////
        public bool CheckModel(Model.Contact model, out string msg)
        {
            bool check = true;
            msg = "";
            //业务逻辑，判断分组名称是否为空
            if (model.Name == "")
            {
                msg = "联系人名称不能为空";
                check = false;
                return check;
            }
            if (!Utility.CheckMobilePhone(model.Phone))
            {
                msg = "手机号码不正确";
                check = false;
                return check;
            }
            if (!Utility.CheckEmail(model.Email))
            {
                msg = "Email格式不正确";
                check = false;
                return check;
            }
            if (!Utility.CheckQQ(model.QQ))
            {
                msg = "QQ号码不正确";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.OfficePhone))
            {
                msg = "办公电话号码不正确";
                check = false;
                return check;
            }
            if (!Utility.CheckPhone(model.HomePhone))
            {
                msg = "家庭电话号码不正确";
                check = false;
                return check;
            }
            return check;
        }


        /////
        public bool Add(Model.Contact model, out string msg)
        {
            if (!CheckModel(model, out msg))
            {
                return false;
            }
            else
            {
                return dal.Add(model);
            }

        }

        ////////
        public bool Delete(int Id)
        {
             return dal.Delete(Id);
        }

        ///////
        public bool Update(Model.Contact model, out string msg)
        {
            if (!CheckModel(model, out msg))
            {
                return false;
            }
            else
            {
                return dal.Update(model);
            }
        }
       ////
        public Model.Contact GetModel(int Id)
        {
            return dal.GetModel(Id);
        }

    }
}
