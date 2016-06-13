using DesktopAppMvvm.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopAppMvvm
{
	/// <summary>
	/// Interaction logic for HarddiskModuleView.xaml
	/// </summary>
	public partial class HarddiskModuleView : UserControl
	{
		public HarddiskModuleView()
		{
			this.InitializeComponent();
            this.DataContext = new HarddiskModuleViewModel();
		}
	}
}