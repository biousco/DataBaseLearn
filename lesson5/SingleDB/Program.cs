using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection db = DBConnection.GetDB();
            DBConnection db2 = DBConnection.GetDB();
            if(db == db2)
            {
                Console.WriteLine("db和db2是同一个实例");
            } else
            {
                Console.WriteLine("db和db2是不同的实例");
            }
            Console.ReadLine();
        }
    }
}
