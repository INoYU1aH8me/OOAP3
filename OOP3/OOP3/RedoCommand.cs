using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class RedoCommand : BaseCommand, ICommand
    {
        public RedoCommand(Window window) : base(window)
        {

        }
        public void Execute()
        {
            window.state = windowStateHistory().GetNextState();
        }
    }
}
