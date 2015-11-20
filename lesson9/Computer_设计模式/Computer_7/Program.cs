using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_7
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
                double numberA = Convert.ToDouble(strNumberA);
                double numberB = Convert.ToDouble(strNumberB);

                OperationInt operInt; //声明整数基类型变量
                OperationDouble operDouble; //声明小数基类型变量

                IFactory operFactory = new AddFactory();
                // IFactory operFactory = new SubFactory();  //决定进行什么运算

                operInt = operFactory.CreateOperationInt();
                operInt.NumberA = (int)numberA; //获取第一个运算数的整数部分
                operInt.NumberB = (int)numberB; //获取第二个运算数的整数部分
                strResult = operInt.GetResult(); //多态,调用子类的方法
                Console.WriteLine("整数部分运算结果是 " + strResult);

                operDouble = operFactory.CreateOperationDouble();
                operDouble.NumberA = numberA - operInt.NumberA; //获取第一个运算数的小数部分
                operDouble.NumberB = numberB - operInt.NumberB; //获取第二个运算数的小数部分
                strResult = operDouble.GetResult(); //多态,调用子类的方法
                Console.WriteLine("小数部分运算结果是 " + strResult);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("输入有错", ex.Message);
                Console.ReadLine();
            }
        }
    }

    public class OperationInt //整数运算基类
    {
        private int _numberA = 0;
        private int _numberB = 0;

        public int NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public int NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual int GetResult() //定义虚方法
        {
            int result = 0;
            return result;
        }
    }

    public class OperationDouble //小数运算基类
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

    class OperationAddInt : OperationInt //整数加法子类，继承OperationInt
    {
        public override int GetResult() //重写虚方法
        {
            int result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSubInt : OperationInt //整数减法子类，继承OperationInt
    {
        public override int GetResult() //重写虚方法
        {
            int result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    class OperationAddDouble : OperationDouble //小数加法子类，继承OperationDouble
    {
        public override double GetResult() //重写虚方法
        {
            double result = 0.0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSubDouble : OperationDouble //小数减法子类，继承OperationDouble
    {
        public override double GetResult() //重写虚方法
        {
            double result = 0.0;
            result = NumberA - NumberB;
            return result;
        }
    }

    //工厂接口或是抽象的工厂类
    interface IFactory
    {
        //在工厂接口中定义两个方法,分别创建两个对象
        OperationInt CreateOperationInt(); //创建整数运算对象
        OperationDouble CreateOperationDouble(); //创建小数运算对象
    }

    //具体的加法工厂子类：组装整数加法类对象和小数加法类对象
    public class AddFactory : IFactory
    {
        public OperationInt CreateOperationInt()
        {
            return new OperationAddInt();
        }
        public OperationDouble CreateOperationDouble()
        {
            return new OperationAddDouble();
        }
    }

    //具体的减法工厂子类：组装整数减法类对象和小数减法类对象
    public class SubFactory : IFactory
    {
        public OperationInt CreateOperationInt()
        {
            return new OperationSubInt();
        }
        public OperationDouble CreateOperationDouble()
        {
            return new OperationSubDouble();
        }
    }
}
