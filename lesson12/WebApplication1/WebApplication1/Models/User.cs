using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
        [Serializable]

        public class User
        {
            private string adminUser = string.Empty; //设置用户名称为空值
            private string adminPwd = string.Empty; //设置用户密码为空值
            public string AdminUser   //设置相对应的属性
            {
                get { return this.adminUser; }
                set { this.adminUser = value; }
            }
            public string AdminPwd     //设置相对应的属性
            {
                get { return this.adminPwd; }
                set { this.adminPwd = value; }
            }
        }
    }