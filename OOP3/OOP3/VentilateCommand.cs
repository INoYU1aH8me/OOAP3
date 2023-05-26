using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class VentilateCommand : BaseCommand, ICommand
    {
        public VentilateCommand(Window window) : base(window)
        {

        }
        public void Execute()
        {
            window.Ventilate();
            windowStateHistory().AddState(window.state);
        }
    }
}
