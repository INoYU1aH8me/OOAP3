using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Window window = new Window();

            Console.WriteLine();
            
            controller.SetButton(ReadChar("Set button for Open Command"), new OpenCommand(window));
            controller.SetButton(ReadChar("Set button for Close Command"), new CloseCommand(window));
            controller.SetButton(ReadChar("Set button for Ventilate Command"), new VentilateCommand(window));
            controller.SetButton(ReadChar("Set button for Undo Command"), new UndoCommand(window));
            controller.SetButton(ReadChar("Set button for Redo Command"), new RedoCommand(window));
           

            while (true)
            {
                Console.WriteLine("window state: " + window.state);
                controller.PushButton(ReadChar("press button"));
            }
        }
        static char ReadChar(string message)
        {
            while (true)
            {
                Console.Write(message+":");
                string str = Console.ReadLine();
                if (str != null && str!= "")
                {
                    return str[0];
                }
            }
        }
    }
}
