/* ==========================================================================
 * Set the service Title and Product Name in the Assembly Information
 * screen in the project's properties.
 * Important: generate a new GUID and replace the existing GUID in the
 * Assembly Information screen in the project's properties.
 * ==========================================================================
 */

namespace SelfInstallingWindowsServiceCSharp
{
    public partial class ServiceBase : System.ServiceProcess.ServiceBase
    {
        private ServiceWorker service;

        public ServiceBase()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            service = new ServiceWorker();
            service.Start();
        }

        protected override void OnStop()
        {
            base.OnStop();
            service.Stop();
        }
    }

}
