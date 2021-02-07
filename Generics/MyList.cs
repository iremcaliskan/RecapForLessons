using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyList<T> //T : type
    { // Liste arkaplanda bir array yönetir.
        T[] _items;
        T[] tempArray;
        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            tempArray = _items; // Newlenme için önceki referans adresi tutulur, eleman kaybetmemk için
            _items = new T[_items.Length + 1]; // Eleman sayısı 1 artınca newlendi.
            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }
            _items[_items.Length - 1] = item; // Açılan boşluğa gelen elemanı at

        }

        // propfull
        public int Count
        {
            get { return _items.Length; }                
        }

        public T[] Items
        {
            get { return _items; }
        }
    }
}
