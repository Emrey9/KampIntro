using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class MyDictionary<T, K>
    {

        KeyValuePair<T, K>[] items;
        public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }
        public void Add(T item, K key)
        {
            KeyValuePair<T, K>[] temp = items;
            items = new KeyValuePair<T, K>[items.Length + 1];

            for (int i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }
            items[items.Length - 1] = new KeyValuePair<T, K>(item, key);

        }

    }
}
