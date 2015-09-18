using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Dog:Animal,Catch
    {
        public Dog(String name):base(name)
        {
            this.name = name;
        }

        public Dog() {
        }

        public override string getSound()
        {
            return "汪";
        }

        public void CatchAnimal()
        {
            Console.WriteLine("狗捉老鼠");
        }
    }
}
