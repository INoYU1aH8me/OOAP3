using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class UndoCommand : BaseCommand, ICommand
    {
        public UndoCommand(Window window) : base(window)
        {
            
        }
        public void Execute()
        {
            window.state = windowStateHistory().GetPreviousState();           
        }
    }

}
