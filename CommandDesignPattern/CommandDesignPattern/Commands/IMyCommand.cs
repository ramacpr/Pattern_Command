using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandDesignPattern.Commands
{
    public interface IMyCommand 
    {
        void Execute();
        void UnExecute();
    }
}
