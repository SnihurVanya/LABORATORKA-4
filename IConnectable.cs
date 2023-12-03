using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    public interface IConnectable
    {
        void Connect(Computer target);
        void Disconnect(Computer target);
        void TransferData(Computer target, string data);
    }
}
