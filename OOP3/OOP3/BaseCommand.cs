using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class BaseCommand
    {
        static Dictionary<Window, WindowStateHistory> windowStateHistoryMap = new Dictionary<Window, WindowStateHistory>();        
        protected WindowStateHistory windowStateHistory()
        {
            return windowStateHistoryMap[window];
        }

        protected Window window;
        public BaseCommand(Window window)
        {
            this.window = window;
            if (!windowStateHistoryMap.ContainsKey(window))
            {
                windowStateHistoryMap[window] = new WindowStateHistory(window.state);
            }
        }
    }
}
