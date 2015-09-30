using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategeTravel
{
    abstract class Strategy
    {
        abstract public void TravelMethodInterface();
    }
    
    //各种方法
    class Bike:Strategy
    {
        public override void TravelMethodInterface()
        {
            Console.WriteLine("骑自行车");
        }
    }

    class Bus:Strategy
    {
        public override void TravelMethodInterface()
        {
            Console.WriteLine("坐巴士");
        }
    }

    class Plane:Strategy
    {
        public override void TravelMethodInterface()
        {
            Console.WriteLine("坐飞机");
        }
    }

    //环境变量
    class TravelEnvironment
    {
        Strategy strategy;

        public TravelEnvironment(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void TravelEnvironmentInterface()
        {
            strategy.TravelMethodInterface();
        }
    }

}
