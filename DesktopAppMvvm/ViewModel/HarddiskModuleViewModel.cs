using DesktopAppMvvm.Model;
using lib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace DesktopAppMvvm.ViewModel
{
    class HarddiskModuleViewModel
    {
        public HarddiskModuleModel Model {get; set;}

        public ObservableCollection<DiskControlViewModel> Harddisks { get; set; }

        private DispatcherTimer UpdateTimer = new DispatcherTimer();

        public HarddiskModuleViewModel()
        {
            Model = new HarddiskModuleModel { RefreshSpeed = new TimeSpan(0,0,0,5,0) ,BackgroundColor = new SolidColorBrush(Color.FromArgb(100,0,0,255))};
            EditButtonClick = new DelegateCommand(OpenEditWindow);

            Harddisks = new ObservableCollection<DiskControlViewModel>();

            UpdateTimer.Interval = Model.RefreshSpeed;
            UpdateTimer.Tick += Update;

            Load();
        }


        public ICommand EditButtonClick { get; set; }
        private void OpenEditWindow(object obj)
        {
            var editWindow = new EditWindow();
            editWindow.Show();
            editWindow.VM.LoadProperties(Model);
        }

        private void Update(object sender, EventArgs e)
        {
            foreach (DriveInfo Dinfo in DriveInfo.GetDrives())
            {
                if (Dinfo.IsReady)
                {
                    Harddisks.Add(new DiskControlViewModel(Dinfo));
                }
            }
        }

        public void Load()
        {
            foreach (DriveInfo Dinfo in DriveInfo.GetDrives())
            {
                if (Dinfo.IsReady)
                {
                    Harddisks.Add(new DiskControlViewModel(Dinfo));
                }
            }
        }
    }
}
