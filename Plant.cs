using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Plant 
    {
        public string Type { get; set; }
        public int Energy { get; internal set; }
        public int Size { get; internal set; }
        public int Age { get; internal set; }

        public void Reproduction()
        {
            Console.WriteLine("Plant is reproducing.");
        }
    }
}
