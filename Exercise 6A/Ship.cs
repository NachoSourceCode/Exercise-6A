using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6A
{
    class Ship : Vehicle
    {
        // Passes ShipType back to console from menu
        public override string ShipType(string ShipType)
        {
            Console.WriteLine($"{ShipType}");
            return ShipType;
        }
    }
}
