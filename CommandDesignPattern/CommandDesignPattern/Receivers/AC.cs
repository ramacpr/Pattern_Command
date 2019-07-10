using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Receivers
{
    public class AC : IReceiver
    {
        public AC() { }

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
