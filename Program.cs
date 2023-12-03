using LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static void Main()
        {
            Animal animal = new Animal { Energy = 100, Age = 5, Size = 10, Type = "Mammal" };
            Plant plant = new Plant { Energy = 50, Age = 2, Size = 5, Type = "Flower" };
            Microorganism microorganism = new Microorganism { Energy = 20, Age = 1, Size = 2, Type = "Bacteria" };

            Ecosystem ecosystem = new Ecosystem();
            ecosystem.Organisms.Add(Animal);
            ecosystem.Organisms.Add(Plant);
            ecosystem.Organisms.Add(Microorganism);

            ecosystem.SimulateInteraction();
        }
    }

}
class Program
{
    static void Main()
    {
        Server server = new Server { IPAddress = "192.168.1.1", Power = 100, OS = "Windows Server", MaxConnections = 10 };
        Workstation workstation = new Workstation { IPAddress = "192.168.1.2", Power = 80, OS = "Windows 10" };
        Router router = new Router { IPAddress = "192.168.1.3", Power = 50, OS = "RouterOS" };

        Network network = new Network();
        network.Computers.Add(server);
        network.Computers.Add(workstation);
        network.Computers.Add(router);

        // Connect and transfer data
        network.ConnectComputers(server, workstation);
        network.TransferData(workstation, server, "Hello, Server!");

        // Disconnect
        network.DisconnectComputers(server, workstation);
    }
}
