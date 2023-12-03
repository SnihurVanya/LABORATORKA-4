using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Vehicle : IDriveable
    {
        public double Speed { get; set; }
        public double Size { get; set; }
        public string Type { get; set; }

        public Vehicle(double speed, double size, string type)
        {
            Speed = speed;
            Size = size;
            Type = type;
        }

        public void Move()
        {
            Console.WriteLine($"Vehicle of type {Type} is moving at speed {Speed}.");
        }

        public void Stop()
        {
            Console.WriteLine($"Vehicle of type {Type} has stopped.");
        }
    }

}
