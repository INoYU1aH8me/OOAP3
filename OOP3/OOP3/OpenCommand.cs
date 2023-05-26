using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class OpenCommand: BaseCommand, ICommand
    {
        public OpenCommand(Window window) : base(window)
        {
            
        }
        public void Execute()
        {
            window.Open();
            windowStateHistory().AddState(window.state);
        }
    }
}
