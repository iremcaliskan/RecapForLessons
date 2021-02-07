using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyDictionary <TKey, TValue>
    {
        TKey[] _keys;
        TValue[] _values;
        TKey[] tempKeys;
        TValue[] tempValues;
        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = _keys;
            _keys = new TKey[_keys.Length + 1];

            tempValues = _values;
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }

            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
        }


        public int Count
        {
            get { return _keys.Length; }
        }

        public TKey[] Keys
        {
            get { return _keys; }
        }

        public TValue[] Values
        {
            get { return _values; }
        }
    }
}
