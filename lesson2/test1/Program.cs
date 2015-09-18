using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Cat
    {
        public String name;
        public int shoutCount;
        public static int newCount = 0;

        public int SHOUTCOUNT
        {
            set
            {
                shoutCount = 1;
                if(0 <= value && value <= 10)
                {
                    shoutCount = value;
                } else
                {
                    Console.WriteLine("输入值不合法！");
                }
            }
            get
            {
                return shoutCount;
            }
        }

        public Cat (String name)
        {
            Cat.newCount++;
            this.name = name;
        }
        public Cat() { Cat.newCount++; }

        public void shout ()
        {
            Console.WriteLine("我的名字叫：" + this.name);
            for(int i = 0; i < shoutCount; i++)
            {
                Console.WriteLine( "喵！");
            }
            Console.WriteLine("总共喵了：" + this.shoutCount + "次");
        }

        public static void ShowNewCount ()
        {
            Console.WriteLine("实例化了：" + Cat.newCount + "次");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat mimi = new Cat("mimi");
            mimi.SHOUTCOUNT = 4;
            mimi.shout();
            Cat coco = new Cat("coco");
            mimi.shout();
            Cat.ShowNewCount();
            Console.ReadLine();
        }
    }
}
