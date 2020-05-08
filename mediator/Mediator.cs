using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediator
{
    abstract class Mediator
    {
        public abstract void Send(string msg, People colleague);
    }
}
