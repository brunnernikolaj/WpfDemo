using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopAppMvvm.Model;
using System.Windows;
using System.Windows.Controls;
using DesktopAppMvvm.EditWindowControls;
using System.Windows.Media;
using System.Reflection;
using DesktopAppMvvm.EditWindowControls.CustomEventArgs;
using DesktopAppMvvm.EditWindowControls.Containers;

namespace DesktopAppMvvm.ViewModel
{
    public class EditWidowViewModel
    {
        public EditWindowModel Model;

        public ObservableCollection<UserControl> EditControls { get; set; }

        public EditWidowViewModel()
        {
            EditControls = new ObservableCollection<UserControl>();
        }

        public void LoadProperties(IModel model)
        {
            foreach (PropertyInfo property in model.GetProperties())
            {
                if (property.PropertyType == typeof(ImageSource))
                {
					SomeObject object = new SomeObject();
                    SomeObject.Changed += (obj, e) => { property.SetValue(model, e.Property); };
                }

                if (property.PropertyType == typeof(SolidColorBrush))
                {
					SomeObject object = new SomeObject();
                    SomeObject.Changed += (obj, e) => { property.SetValue(model, e.Property); };
                }
            }
        }
    }
}
