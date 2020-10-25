using System.Collections.Generic;

namespace HashTable
{
    class Item<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }

        public Item(int key)
        {
            Nodes = new List<T>();
            Key = key;
        }
    }
}
