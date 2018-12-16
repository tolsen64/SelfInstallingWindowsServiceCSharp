using System;
using System.ServiceProcess;


namespace SelfInstallingWindowsServiceCSharp
{
    static class ConsoleApp
    {

        static void Main()
        {
            if (System.Environment.UserInteractive)
            {
                Console.WriteLine("Opening service configuration window...");
                frmConfig frm = new frmConfig();
                frm.ShowDialog();
            }
            else
            {
                System.ServiceProcess.ServiceBase.Run(new System.ServiceProcess.ServiceBase[] { new ServiceBase() });
            }
        }

    }
}
