using DesktopAppMvvm.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppLib;
using System.Windows.Threading;
using System.Windows.Input;

namespace DesktopAppMvvm.ViewModel
{
    class DiskControlViewModel
    {
        public DiskControlModel Model {get; set;}

        private DispatcherTimer UpdateTimer = new DispatcherTimer();

        public DiskControlViewModel(DriveInfo dInfo)
        {
            Model = new DiskControlModel(dInfo) { RefreshSpeed = new TimeSpan(0,0,0,5,0)};
           

            UpdateTimer.Interval = Model.RefreshSpeed;
            UpdateTimer.Tick += Update;
            UpdateTimer.Start();
        }

        

        private void Update(object sender, EventArgs e)
        {
            foreach (DriveInfo dInfo in DriveInfo.GetDrives())
            {
                if (dInfo.Name.Equals(Model.HarddiskName) && dInfo.IsReady)
                {
                    Model.UsageRectWidth = dInfo.ToPercentDouble() * 3;
                    Model.UsageString = dInfo.ToUsageString();
                }
            }
        }
    }
}
