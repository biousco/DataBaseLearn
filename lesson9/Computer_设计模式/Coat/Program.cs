using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace Coat
{
    //上衣基类
    public class StyleCoat
    {
        public virtual string GetStyle() //虚方法
        {
            return "Coat";
        }
    }
    //裤子基类
    public class StyleTrousers
    {
        public virtual string GetStyle()
        {
            return "Trousers";
        }
    }

    //休闲上衣，继承上衣基类
    class FashionCoat : StyleCoat
    {
        public override string GetStyle()
        {
            return "FashionCoat";
        }
    }

    class CasualCoat : StyleCoat
    {
        public override string GetStyle()
        {
            return "CasualCoat";
        }
    }

    //休闲裤子，继承裤子基类
    class FashionTrousers : StyleTrousers
    {
        public override string GetStyle()
        {
            return "FashionTrousers";
        }
    }

    class CasualTrousers : StyleTrousers
    {
        public override string GetStyle()
        {
            return "CasualTrousers";
        }
    }

    //修改：反射+配置文件
    public class SuitFactory
    {
        static string styleName = ConfigurationManager.AppSettings["styleName"];

        public static StyleCoat CreateStyleCoat()
        {
            string className = styleName + "Coat";
            //利用反射技术创建上衣对象
            return (StyleCoat)Assembly.Load("Coat").CreateInstance("Coat." + className);
        }

        public static StyleTrousers CreateStyleTrousers()
        {
            string className = styleName + "Trousers";
            //利用反射技术创建裤子对象
            return (StyleTrousers)Assembly.Load("Coat").CreateInstance("Coat." + className);
        }
    }

    //客户端代码

    class Program
    {
        static void Main(string[] args)
        {
            StyleCoat styleCoat;
            StyleTrousers styleTrousers;

            styleCoat = SuitFactory.CreateStyleCoat();
            styleTrousers = SuitFactory.CreateStyleTrousers();

            Console.WriteLine("上衣: {0}",styleCoat.GetStyle());
            Console.WriteLine("裤子: {0}",styleTrousers.GetStyle());

            Console.ReadLine();

        }
    }
}
