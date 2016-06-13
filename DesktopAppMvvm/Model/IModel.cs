using System;
namespace DesktopAppMvvm.Model
{
    public interface IModel
    {
        List<System.Reflection.PropertyInfo> GetProperties();
    }
}
