using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAppMvvm.EditWindowControls.Containers
{
    public class PropertyContainer<T>
    {
        public T Property { get; set; }
        public string PropertyName { get; set; }
    }
}
