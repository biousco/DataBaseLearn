using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Cat:Animal,Catch
    {

        public Cat(String name):base(name)
        {
        }

        public Cat()
        {
        }

        public override string getSound()
        {
            return "喵";
        }

        public void CatchAnimal()
        {
            Console.WriteLine("猫捉老鼠");
        }

    }
}
