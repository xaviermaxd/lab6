using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App6
{
    public class GroupStudent<K, T> : ObservableCollection<T>
    {
        public K Key { get; private set; }

        public GroupStudent(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
                this.Items.Add(item);
        }
    }
}
