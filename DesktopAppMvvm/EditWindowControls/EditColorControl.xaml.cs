using DesktopAppLib.Classes;
using DesktopAppMvvm.EditWindowControls.Containers;
using DesktopAppMvvm.EditWindowControls.CustomEventArgs;
using DesktopAppMvvm.EditWindowControls.DataContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DesktopAppMvvm.EditWindowControls
{
    /// <summary>
    /// Interaction logic for EditColorControl.xaml
    /// </summary>
    public partial class EditColorControl : UserControl
    {
        public event EventHandler<PropertyChangeEventsArgs<SolidColorBrush>> ColorChanged;

        public EditColorDataContext Context = new EditColorDataContext();

        public EditColorControl(PropertyContainer<SolidColorBrush> property )
        {
            InitializeComponent();
            Context.Color = property.Property;
            Context.PropertyName = property.PropertyName;
            DataContext = Context;
            LoadColors();
        }

        private void LoadColors()
        {
            foreach (SolidColorBrush Color in WpfColors.Colors)
            {
                var colorRect = new Rectangle { Fill = Color, Height = 20, Width = 20 };
                colorRect.MouseLeftButtonUp += colorRect_MouseLeftButtonUp;
                ColorWP.Children.Add(colorRect);
            }
        }

        void colorRect_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var colorSelected = (SolidColorBrush)(sender as Rectangle).Fill;
            ColorChanged(this, new PropertyChangeEventsArgs<SolidColorBrush>(colorSelected));
        }



    }
}
