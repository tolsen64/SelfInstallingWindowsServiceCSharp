using System;
using System.Reflection;
using System.ServiceProcess;
using System.Windows.Forms;

namespace SelfInstallingWindowsServiceCSharp
{
    public partial class frmConfig : Form
    {
        #region Service control code.

        private ServiceController sc = null;

        public frmConfig()
        {
            InitializeComponent();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            Text = Assembly.GetExecutingAssembly().GetName().Name + " Configuration";

            foreach (ServiceController svc in ServiceController.GetServices())
            {
                if (svc.ServiceName == (Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_"))) 
                {
                    lblInstallStatus.Text = "Installed";
                    itmInstallUninstallService.Text = "Uninstall Service";
                    itmStartStopService.Enabled = true;
                    sc = svc;
                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        itmStartStopService.Text = "Stop Service";
                        itmInstallUninstallService.Enabled = false;
                    }
                }
            }

            Form_Load(sender, e);
        }

        private void itmInstallUninstallService_Click(object sender, EventArgs e)
        {
            if (itmInstallUninstallService.Text == "Install Service")
            {
                try
                {
                    if (SelfInstaller.InstallMe())
                    {
                        lblInstallStatus.Text = "Installed";
                        itmInstallUninstallService.Text = "Uninstall Service";
                        itmStartStopService.Enabled = true;
                        foreach (ServiceController svc in ServiceController.GetServices())
                        {
                            if (svc.ServiceName == (Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_")))
                            {
                                sc = svc;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to install the service. Try running this app as administrator.");
                }
            }
            else if ((string)itmInstallUninstallService.Text == "Uninstall Service")
            {
                try
                {
                    if (SelfInstaller.UninstallMe())
                    {
                        lblInstallStatus.Text = "Not Installed";
                        itmInstallUninstallService.Text = "Install Service";
                        itmStartStopService.Enabled = false;
                        sc = null;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to uninstall the service. Try running this app as administrator.");
                }
            }
        }

        private void itmStartStopService_Click(object sender, EventArgs e)
        {
            try
            {
                if ((string)itmStartStopService.Text == "Start Service")
                {
                    sc.Start();
                    while (!(sc.Status == ServiceControllerStatus.Running))
                    {
                        System.Threading.Thread.Sleep(200);
                        sc.Refresh();
                    }
                    lblRunStatus.Text = "Running";
                    itmStartStopService.Text = "Stop Service";
                    itmInstallUninstallService.Enabled = false;
                }
                else if ((string)itmStartStopService.Text == "Stop Service")
                {
                    if (sc.Status == ServiceControllerStatus.Running)
                    {
                        sc.Stop();
                    }
                    while (!(sc.Status == ServiceControllerStatus.Stopped))
                    {
                        System.Threading.Thread.Sleep(200);
                        sc.Refresh();
                    }
                    lblRunStatus.Text = "Stopped";
                    itmStartStopService.Text = "Start Service";
                    itmInstallUninstallService.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to start/stop the service. Try running this app as administrator.");
            }
        }

        private ServiceWorker svc;

        private void itmRunAsApplication_Click(object sender, EventArgs e)
        {
            if ((string)itmRunAsApplication.Text == "Run as Application")
            {
                svc = new ServiceWorker();
                svc.Start();
                itmRunAsApplication.Text = "Stop Application";
            }
            else if ((string)itmRunAsApplication.Text == "Stop Application")
            {
                svc.Stop();
                svc = null;
                itmRunAsApplication.Text = "Run as Application";
            }
        }

        #endregion

        //======================================
        // Add form load event code here.
        //======================================
        private void Form_Load(object sender, EventArgs e)
        {

        }

        //==================================================
        // Add service configuration subs & functions here.
        //==================================================

    }
}
