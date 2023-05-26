using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Window
    {
        public enum State {Open, Closed, Ventilation};
        
        public State state = State.Closed;             
        public void Open()
        {
            state = State.Open;
        }
        public void Close()
        {
            state = State.Closed;
        }
        public void Ventilate()
        {
            state = State.Ventilation;
        }

    }
}
