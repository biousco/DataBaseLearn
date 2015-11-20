using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
     public class User
    {
        //针对User表创建的类
         public User() { }

        #region Model 
            //region是c#预处理器指令。
           // #region是一个分块预处理命令，它主要用于编辑代码的分段，在编译时会被自动删除。
          //#region使你可以在使用VS代码编辑器的大纲显示功能时指定可展开或折叠的代码块。

         private string _username;
         private string _password;

         ///<summary>
         ///用户名
         ///</summary>
         //<summary>文档注释. 在一个类,方法或属性定义的上一行输入///就会出现<summary>. 
         //调用这个类或方法时写在<summary>里的东西就会以提示的方式出现.
 
         public string UserName
         {
             set { _username = value; }
             get { return _username; }
         
         }
         ///<summary>
         ///密码
         ///</summary>
         public string Password
         {
             set { _password = value; }
             get { return _password; }

         }
        #endregion Model
    }
}
