using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class CloseCommand : BaseCommand, ICommand
    {
        public CloseCommand(Window window) : base(window)
        {

        }
        public void Execute()
        {
            window.Close();
            windowStateHistory().AddState(window.state);
        }
    }
}
