using DesktopAppMvvm.EditWindowControls.Containers;
using DesktopAppMvvm.EditWindowControls.CustomEventArgs;
using DesktopAppMvvm.EditWindowControls.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for EditImageControl.xaml
    /// </summary>
    public partial class EditImageControl : UserControl
    {
        public event EventHandler<PropertyChangeEventsArgs<ImageSource>> ImageChanged;

        public EditImageDataContext Context = new EditImageDataContext();

        private string ImageFileDialogDefaultExt = ".png .jpg";
        private string ImageFileDialogFilter = "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff" + "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|";

        public EditImageControl(PropertyContainer<ImageSource> property)
        {
            InitializeComponent();
            Context.Image = property.Property;
            Context.PropertyName = property.PropertyName;
            Context.ImageName = "Default";
            this.DataContext = Context;
        }

        private void Image_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog imageFileDialog = new Microsoft.Win32.OpenFileDialog();
            imageFileDialog.DefaultExt = ImageFileDialogDefaultExt;
            imageFileDialog.Filter = ImageFileDialogFilter; 

            Nullable<bool> result = imageFileDialog.ShowDialog();

            if (result == true)
            {
                var uri = new Uri(imageFileDialog.FileName);
                var imgSource = new BitmapImage(uri);
                Context.Image = imgSource;
                Context.ImageName = imageFileDialog.SafeFileName;
                ImageChanged(this, new PropertyChangeEventsArgs<ImageSource>(imgSource)); 
            }
        }
    }
}
