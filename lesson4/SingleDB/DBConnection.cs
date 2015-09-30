using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB
{
    //单例模式数据库连接
    class DBConnection
    {
        private static DBConnection dbconnection;

        //私有的构造函数，外部无法通过new来创建这个类的实例
        private DBConnection()
        {

        }

        //在类外不需要实例化就能调用该静态方法
        public static DBConnection GetDB ()
        {
            //保证只实例化一次
            if (dbconnection == null)
                dbconnection = new DBConnection();
            return dbconnection;
        }


    }
}
