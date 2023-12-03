using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public class Network
    {
        public List<Computer> Computers { get; set; }

        public Network()
        {
            Computers = new List<Computer>();
        }

        public void ConnectComputers(Computer source, Computer target)
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.Connect(target);
            }
            else
            {
                Console.WriteLine("Error: Source computer is not connectable.");
            }
        }

        public void DisconnectComputers(Computer source, Computer target)
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.Disconnect(target);
            }
            else
            {
                Console.WriteLine("Error: Source computer is not connectable.");
            }
        }

        public void TransferData(Computer source, Computer target, string data)
        {
            if (source is IConnectable connectableSource)
            {
                connectableSource.TransferData(target, data);
            }
            else
            {
                Console.WriteLine("Error: Source computer is not connectable.");
            }
        }
    }
}
