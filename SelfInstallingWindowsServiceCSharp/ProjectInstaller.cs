using System.ComponentModel;
using System.Reflection;

namespace SelfInstallingWindowsServiceCSharp
{

    [RunInstaller(true)]
    public class ProjectInstaller : System.Configuration.Install.Installer
    {

        string MyServiceName;
        string MyServiceDisplayName;

        public ProjectInstaller()
        {
            MyServiceName = Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_");
            MyServiceDisplayName = Assembly.GetExecutingAssembly().GetName().Name;
            InitializeComponent();
        }

        //Installer overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (!(ReferenceEquals(components, null)))
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //Required by the Component Designer
        private Container components = null;

        //NOTE: The following procedure is required by the Component Designer
        //It can be modified using the Component Designer.
        //Do not modify it using the code editor.
        internal System.ServiceProcess.ServiceProcessInstaller ServiceProcessInstaller1;
        internal System.ServiceProcess.ServiceInstaller ServiceInstaller1;
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.ServiceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.ServiceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            //
            //ServiceProcessInstaller1
            //
            this.ServiceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ServiceProcessInstaller1.Password = null;
            this.ServiceProcessInstaller1.Username = null;
            //
            //ServiceInstaller1
            //
            this.ServiceInstaller1.ServiceName = MyServiceName;
            this.ServiceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.ServiceInstaller1.DisplayName = MyServiceDisplayName;
            //
            //ProjectInstaller
            //
            this.Installers.AddRange(new System.Configuration.Install.Installer[] { this.ServiceProcessInstaller1, this.ServiceInstaller1 });

        }

    }

}
