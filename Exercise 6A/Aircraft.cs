using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6A
{
    class Aircraft : Vehicle
    {
        // Passes AircraftType back to console from menu
        public override string AircraftType(string AircraftType)
        {
            Console.WriteLine($"{AircraftType}");
            return AircraftType;
        }
    }
}
