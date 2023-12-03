using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Workstation : Computer, IConnectable
    {
        public void Connect(Computer target)
        {
            Console.WriteLine($"Connected to {target.IPAddress}.");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Disconnected from {target.IPAddress}.");
        }

        public void TransferData(Computer target, string data)
        {
            Console.WriteLine($"Data transferred to {target.IPAddress}: {data}");
        }
    }

}
