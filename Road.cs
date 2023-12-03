using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Road
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public int Lanes { get; set; }
        public int TrafficLevel { get; set; }

        public Road(double length, double width, int lanes)
        {
            Length = length;
            Width = width;
            Lanes = lanes;
            TrafficLevel = 0;
        }

        public void IncreaseTraffic()
        {
            TrafficLevel++;
            Console.WriteLine($"Traffic increased on the road. Current traffic level: {TrafficLevel}");
        }
    }

}
