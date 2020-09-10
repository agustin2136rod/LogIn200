using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login200_D
{
    public delegate void StateObserver(State s);

    public delegate void InputHandler(State state, String args);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CredentialsD model = new CredentialsD("Alice", "Wonderland");
            ControllerD controller = new ControllerD(model);
            Form1 view = new Form1(controller.handleEvents);
            controller.registerObs(view.DisplayState);

            Application.Run();
        }
    }
}
