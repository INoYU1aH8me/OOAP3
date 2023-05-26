using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Controller
    {
        Dictionary<char, ICommand> controls = new Dictionary<char, ICommand>();   
        public void SetButton(char button, ICommand command)
        {
            controls[button] = command;
        }
        public void PushButton(char button)
        {
            if (controls.ContainsKey(button))
            {
                controls[button].Execute();
            }
        }
    }
}
