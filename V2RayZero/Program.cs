using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V2RayZero
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Process currProc = Process.GetCurrentProcess();

            Process[] runningProc = Process.GetProcesses();
            foreach (Process item in runningProc)
            {
                if (item.ProcessName == currProc.ProcessName && item.Id != currProc.Id)
                {
                    currProc.Close();
                }
            }
            Application.Run(new V2Ray_ZERO());
        }
    }
}
