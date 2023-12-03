using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class TrafficSimulation
    {
        public static void Main()
        {
            Road cityRoad = new Road(10.0, 4.0, 2);
            Vehicle car = new Vehicle(60.0, 2.0, "Car");
            Vehicle truck = new Vehicle(40.0, 5.0, "Truck");

            SimulateTraffic(cityRoad, car);
            SimulateTraffic(cityRoad, truck);
        }

        public static void SimulateTraffic(Road road, IDriveable vehicle)
        {
            road.IncreaseTraffic();
            vehicle.Move();
            vehicle.Stop();
        }
    }
}
