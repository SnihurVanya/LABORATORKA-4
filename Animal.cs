using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Animal 
    {
        public string Type { get; set; }
        public int Energy { get; internal set; }
        public int Size { get; internal set; }
        public int Age { get; internal set; }

        public void Reproduction()
        {
            Console.WriteLine("Animal is reproducing.");
        }

        public void Hunting()
        {
            Console.WriteLine("Animal is hunting other organisms.");
        }
    }
}
