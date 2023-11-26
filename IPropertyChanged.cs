using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);
}