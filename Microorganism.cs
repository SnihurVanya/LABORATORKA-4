using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Microorganism
    {
        internal int Energy;

        public string Type { get; set; }
        public int Age { get; internal set; }
        public int Size { get; internal set; }

        public void Reproduction()
        {
            Console.WriteLine("Microorganism is reproducing.");
        }
    }

}
