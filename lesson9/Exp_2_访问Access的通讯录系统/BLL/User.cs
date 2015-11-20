using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace BLL
{
   public  class User
    {
        //针对User表的业务处理逻辑类
        //把表示层的数据转发给数据访问层
        IDAL.IUser user = DALFactory.DataAccessFactory.CreateUser();
       //AccessDAL.User user = new AccessDAL.User();
        public bool Login(string userName, string userPassword)
        {
            return user.Login(userName,userPassword);
        }

        public bool Update(Model.User model)
        {
            return user.Update(model );
        }
    }
}
