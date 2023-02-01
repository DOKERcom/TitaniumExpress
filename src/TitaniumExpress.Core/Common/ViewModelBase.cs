using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TitaniumExpress.Core.Common;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    protected void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    protected void Set<T>(ref T propertyFiled, T newValue, [CallerMemberName] string? propertyName = null)
    {
        if (!object.Equals(propertyFiled, newValue))
        {
            var oldValue = propertyFiled;

            propertyFiled = newValue;

            RaisePropertyChanged(propertyName);

            OnPropertyChanged(propertyName, oldValue, newValue);
        }
    }

    protected virtual void OnPropertyChanged(string propertyName, object oldValue, object newValue) { }
}