using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DataStore<T> //generic class DataStore
    {
        public T Data { get; set; }

        private T[] _data = new T[10];
        public void AddUp(int index, T item)
        {
            if(index >=0 && index < 10)
                _data[index] = item;
        }
        public T GetData(int index)
        {
            if(index >=0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

    }

    class KeyValuePair<TKey, TValue> //having multiple type parameter 
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    
}
