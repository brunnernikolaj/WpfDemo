using DesktopAppMvvm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Input;
using lib;

namespace DesktopAppMvvm.ViewModel
{
    class MainWindowViewModel
    {
       // public ObservableCollection<>

        public MainWindowModel Model { get; set; }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel { ModulesOpenCount = 2 };
            EditButtonClick = new DelegateCommand(OpenEditWindow);
            UISetup();

             
            LoadContexMenu();
        }

        public ICommand EditButtonClick { get; set; }
        private void OpenEditWindow(object obj)
        {
            var editWindow = new EditWindow();
            editWindow.Show();
            editWindow.VM.LoadProperties(Model);
        }

        private void UISetup()
        {
            var uri = new Uri("pack://application:,,,/defaultbackground.png");
            Model.BackgroundImage = new BitmapImage(uri);
        }

        private void LoadContexMenu()
        {
            var Menu = new ContextMenu();
            
            var exitProgramSubMenu = new MenuItem { Header = "Exit", };
            exitProgramSubMenu.Click += (obj, e) => { Application.Current.Shutdown(); };
            Menu.Items.Add(exitProgramSubMenu);
            
            Model.RightClickMenu = Menu;
        }
    }
}
