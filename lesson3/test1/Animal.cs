using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    public abstract class Animal
    {
        public String name;
        public int shoutCount;
        public static int newCount = 0;

        public int SHOUTCOUNT
        {
            set
            {
                shoutCount = 1;
                if (0 <= value && value <= 10)
                {
                    shoutCount = value;
                }
                else
                {
                    Console.WriteLine("输入值不合法！");
                }
            }
            get
            {
                return shoutCount;
            }
        }

        public Animal(String name)
        {
            Animal.newCount++;
            this.name = name;
        }

        public Animal()
        {
            Animal.newCount++;
        }

        public virtual void shout()
        {
            Console.Write("我的名字叫：" + this.name);
            Console.WriteLine();
            for (int i = 0; i < shoutCount; i++)
            {
                Console.Write(getSound() + "!");
            }
            Console.WriteLine();
            Console.WriteLine("总共" + getSound() + "了：" + this.shoutCount + "次");
        }

        public abstract String getSound();

    }
}
