using System.Configuration.Install;
using System.Reflection;

namespace SelfInstallingWindowsServiceCSharp
{
    public sealed class SelfInstaller
    {
        private SelfInstaller()
        {
        }

        private static readonly string _exePath = Assembly.GetExecutingAssembly().Location;

        public static bool InstallMe()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { _exePath });
            }
            catch (InstallException)
            {
                //Console.WriteLine(ex.Message)
                return false;
            }
            return true;
        }

        public static bool UninstallMe()
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { "/u", _exePath });
            }
            catch (InstallException)
            {
                //Console.WriteLine(ex.Message)
                return false;
            }
            return true;
        }
    }
}
