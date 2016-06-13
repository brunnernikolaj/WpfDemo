using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DesktopAppMvvm.EditWindowControls.CustomEventArgs
{
    public class PropertyChangeEventsArgs<T> : EventArgs
    {
      public T Property;
      public PropertyChangeEventsArgs(T property)
        {
            Property = property;
        }
    }
}
