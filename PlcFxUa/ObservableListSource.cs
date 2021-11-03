using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Data.Entity;

namespace PlcFxUa
{
    class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : class
    {
        private IBindingList bindingList;
        bool IListSource.ContainsListCollection { get { return false; } }
        IList IListSource.GetList()
        {
            return bindingList ?? (bindingList = this.ToBindingList());
        }
    }
}
