using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class WindowStateHistory
    {
        List<Window.State> states = new List<Window.State>();
        int stateIndex = 0;

        public WindowStateHistory(Window.State basestate)
        {
            states.Add(basestate);
        }
        public void AddState(Window.State state)
        {
            if (stateIndex < states.Count-1)
            {
                states.RemoveRange(stateIndex+1, states.Count-1-stateIndex);
            }
            states.Add(state);
            stateIndex++;
            Log();
        }
        public Window.State GetPreviousState()
        {
            if (stateIndex > 0)
            {
                stateIndex--;               
            }
            Log();
            return states[stateIndex];
            // 0 1 2 3 4
            // C O V C O
        }
        public Window.State GetNextState()
        {
            if (stateIndex < states.Count - 1)
            {
                stateIndex++;
            }
            Log();
            return states[stateIndex];
            
        }
        void Log()
        {
            foreach(Window.State state in states)
            {
                Console.Write(state + ", ");                
            }
            Console.WriteLine(stateIndex);
        }
    }
}
