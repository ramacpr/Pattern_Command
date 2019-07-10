using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Receivers
{
    public class Fan : IReceiver
    {
        public Fan() { }

        public void ActionOff()
        {
            throw new NotImplementedException();
        }

        public void ActionOn()
        {
            throw new NotImplementedException();
        }
    }
}
