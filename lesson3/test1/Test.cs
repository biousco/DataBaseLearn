using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    
    class Test
    {
        static void Main(string[] args)
        {
            Cat mimi = new Cat("mimi");
            mimi.SHOUTCOUNT = 4;
            mimi.shout();
            Console.WriteLine();

            Cat coco = new Cat("coco");
            coco.SHOUTCOUNT = 2;
            coco.shout();
            Console.WriteLine();

            Dog wangcai = new Dog("wangcai");
            wangcai.SHOUTCOUNT = 8;
            wangcai.shout();
            Console.WriteLine();

            Cow moumou = new Cow("moumou");
            moumou.SHOUTCOUNT = 3;
            moumou.shout();
            Console.WriteLine();

            Sheep miemie = new Sheep("miemie");
            miemie.SHOUTCOUNT = 5;
            miemie.shout();
            Console.WriteLine();

            coco.CatchAnimal();
            wangcai.CatchAnimal();
            Console.ReadLine();
        }
    }
}
