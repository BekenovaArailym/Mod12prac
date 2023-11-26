using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLib
{
    public class MyClass : IPropertyChanged
    {
        private string myProperty;

        public string MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    NotifyPropertyChanged(nameof(MyProperty));
                }
            }
        }

        public event PropertyEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }

    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
}