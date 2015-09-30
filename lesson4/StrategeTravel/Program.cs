using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategeTravel
{
    class Program
    {
        //策略模式
        static void Main(string[] args)
        {
            TravelEnvironment bus = new TravelEnvironment(new Bus());
            bus.TravelEnvironmentInterface();

            TravelEnvironment plane = new TravelEnvironment(new Plane());
            plane.TravelEnvironmentInterface();

            TravelEnvironment bike = new TravelEnvironment(new Bike());
            bike.TravelEnvironmentInterface();

            Console.ReadLine();

        }
    }
}
