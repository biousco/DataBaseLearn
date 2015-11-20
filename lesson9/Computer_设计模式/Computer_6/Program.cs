using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; //反射
//注意：
//先在项目的"引用"下添加引用.Net组件"System.Configuration"
//方法是：
//在"解决方案资源管理器"中，右键点击项目名"Computer6"下的"引用"->"添加引用"
//选择".NET"页面中的"System.Configuration"，然后点击"确定"
//然后再写下面这个语句导入"System.Configuration"命名空间

using System.Configuration; //配置

//注意：
//上一个程序使用工厂方法使得增加新运算功能时,除了要增加新的运算子类和新的工厂子类外,
//还需要在客户端修改相应代码,实际上还是在一定程度上违反了“开闭原则”
//本程序使用“反射”＋“配置文件”方式把在客户端的修改转移到配置文件中,不动客户端代码
//好处是：
//把具体工厂类的名称写在了应用程序配置文件中，因为配置文件是一个方便修改的xml文件,不需要修改客户端代码，实现了“开闭原则”

namespace Computer_6
{
    //客户端显示类
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //接受屏幕输入的数值
                Console.Write("请输入数字A: ");
                string strNumberA = Console.ReadLine();
                Console.Write("请输入数字B: ");
                string strNumberB = Console.ReadLine();
                double strResult = 0.0;

                Operation oper; //声明基类型变量

                //利用配置文件管理类来读取系统配置文件，获得AppSettings节中key为FactoryName的value值
                //即要使用哪个工厂子类来创建运算子类
                string factoryName = ConfigurationManager.AppSettings["FactoryName"];

                //反射技术的格式：Assembly.Load("程序集名称").CreateInstance("命名空间.类名称")
                //作用：根据 "命名空间.类名称"来创建该类的实例
                //由于CreateInstance("命名空间.类名称")中的参数为字符串类型，可以写成变量，
                //而变量的值可从配置文件中得到
                IFactory operFactory = (IFactory)Assembly.Load("Computer_6").CreateInstance("Computer_6." + factoryName);

                oper = operFactory.CreateOperation();
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);

                strResult = oper.GetResult(); //多态,调用子类的方法

                Console.WriteLine("结果是 " + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("输入有错", ex.Message);
                Console.ReadLine();
            }
        }
    }

    public class Operation //运算基类
    {
        private double _numberA = 0.0;
        private double _numberB = 0.0;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult() //定义虚方法
        {
            double result = 0.0;
            return result;
        }
    }

    class OperationAdd : Operation //加法子类，继承Operation
    {
        public override double GetResult() //重写虚方法
        {
            double result = 0.0;
            result = NumberA + NumberB;
            return result;
        }
    }

    class OperationSub : Operation //减法子类，继承Operation
    {
        public override double GetResult() //重写虚方法
        {
            double result = 0.0;
            result = NumberA - NumberB;
            return result;
        }
    }

    interface IFactory //工厂接口或是抽象的工厂类
    {
        Operation CreateOperation();
    }

    class AddFactory : IFactory //具体的加法工厂子类：创建加法类对象
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }

    class SubFactory : IFactory //具体的减法工厂子类：创建减法类对象
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
