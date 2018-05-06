using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Vermittler.Logic
{
    public class Trigger
    {
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static string PressKey; // Presskey aus Dataset gelesen)

        /// <summary>
        /// Sendet den F1 Befehl an das Betriebssystem
        /// </summary>
        public void TransmitF1(string _classname, string _appname)
        {
            IntPtr appHandler = FindWindow(_classname, _appname);

            if (appHandler == IntPtr.Zero)
            {
                MessageBox.Show("Applikation ist nicht gestartet");
                return;
            }

            SetForegroundWindow(appHandler);
            //SendKeys.Send("{F1}");
            SendKeys.Send("{" + PressKey + "}"); // gewünschte Taste senden 
        }
    }
}
