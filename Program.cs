using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLib
{
    public class MyClass
    {
        private string myProperty;

        public event EventHandler<PropertyEventArgs> PropertyChanged;

        public string MyProperty
        {
            get { return myProperty; }
            set
            {
                if (myProperty != value)
                {
                    myProperty = value;
                    OnMyPropertyChanged(nameof(MyProperty));
                }
            }
        }

        protected virtual void OnMyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyEventArgs(propertyName));
        }
    }

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName { get; }

        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
