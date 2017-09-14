using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD.Xamarin.Models
{
    public class GroupingModel<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public GroupingModel(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
