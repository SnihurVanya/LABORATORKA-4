using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public Ecosystem()
        {
            Organisms = new List<LivingOrganism>();
        }

        public void SimulateInteraction()
        {
            // Logic for interaction between organisms (feeding, reproduction, competition for resources)
            Console.WriteLine("Simulating interaction in the ecosystem.");
        }
    }
}