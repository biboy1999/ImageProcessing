using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing101.utils
{
    public static class Logger
    {
        public static Control LogBox { get; set; }

        public static void Log(string msg)
        {

            LogBox.InvokeIfRequired(() =>
            {
                LogBox.Text += $"[{DateTime.Now}]:{msg}\r\n"; ;
            });
        }
    }
}
