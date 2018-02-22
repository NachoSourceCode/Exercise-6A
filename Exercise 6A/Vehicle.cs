using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6A
{
    class Vehicle
    {
        //Method to handle StartEngine noise from mainMenu 
        public string StartEngine(string spinningUpEngine)
        {
            Console.WriteLine($"Starting engine: {spinningUpEngine}");
            return spinningUpEngine;
        }

        public virtual string AircraftType(string AircraftType)
        {
            Console.WriteLine("Whaammmmm.");

            return AircraftType;
        }

        public virtual string ShipType(string ShipType)
        {
            Console.WriteLine("scccccrrooooshh");

            return ShipType;
        }
    }
}
