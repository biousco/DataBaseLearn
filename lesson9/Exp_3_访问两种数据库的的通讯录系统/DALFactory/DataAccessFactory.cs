using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using IDAL;
using System.Reflection;//反射

namespace DALFactory
{
   sealed public  class DataAccessFactory
    { 
      //获得指定的程序集名称
       private static readonly string AssemblyName=ConfigurationManager.AppSettings["DAL"]; 
       
       //获得要访问的DAL层的类名称      
       //利用反射机制动态创建对象，将对象实例化由编译时转为运行时，不需要用switch..case 来判断了。
       //反射技术动态创建对象的方法是：
       //Assemmbly.Load("程序集名称").CreateInstance("命名空间.类名称");
       //
       //创建IUser对象
       public static IUser CreateUser()
       {
           string className = AssemblyName + ".User"; //类名称
           return (IUser) Assembly .Load (AssemblyName).CreateInstance (className);
           //利用反射机制，创建对象，并进行类型转换，把子类转换成父类接口类型；
       }

       /////创建IContact对象
       public static IContact CreateContact()
       {
           string className = AssemblyName + ".Contact"; //类名称
           return (IContact)Assembly.Load(AssemblyName).CreateInstance(className);         
       }

       /////创建IContactGroup对象
       public static IContactGroup CreateContactGroup()
       {
           string className = AssemblyName + ".ContactGroup"; //类名称
           return (IContactGroup)Assembly.Load(AssemblyName).CreateInstance(className);
       }

       /////创建IContactGroup对象
       public static IBackupAndRestoreDb CreateBackupAndRestoreDb()
       {
           string className = AssemblyName + ".BackupAndRestoreDb "; //类名称
           return (IBackupAndRestoreDb)Assembly.Load(AssemblyName).CreateInstance(className);
       }      
    }
}
