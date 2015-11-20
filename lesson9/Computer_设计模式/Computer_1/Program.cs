using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//该程序演示了用工厂方法模式实现计算器程序
//其中：
//Operation类是运算基类，定义了相应的字段，属性和虚方法；
//OperationAdd，OperationSub是运算子类，重写了虚方法
//IFactory是工厂接口，
//AddFactory，SubFactory是继承了工厂接口的工厂子类,分别用来创建加法和减法子类的对象
//所以，一个具体产品子类就对应着一个创建该子类对象的工厂子类
//自己试着添加乘法和除法运算子类和对应的工厂子类，体会工厂方法模式的特点

namespace Computer_1
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

                IFactory operFactory = new AddFactory(); //调用加法工厂子类的构造函数来创建加法类的实例

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

    public class Operation  //运算基类
    {
        private double _numberA = 0.0;
        private double _numberB = 0.0;

        public double NumberA 
        {
            get {return _numberA ; }
            set {_numberA=value ;}
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double  GetResult() //定义虚方法
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
 
