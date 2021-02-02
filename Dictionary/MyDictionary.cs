using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Keys;
        TValue[] Values;

        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = Keys;
            TValue[] tempValue = Values;
            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                Keys[i] = tempKey[i];               
            }

            Keys[Keys.Length - 1] = key;

            for (int i = 0; i < tempValue.Length; i++)
            {
                Values[i] = tempValue[i];
            }
            
            Values[Values.Length - 1] = value;
        }

        public TKey[] keys
        {
            get { return Keys; }
        }

        public TValue[] values
        {
            get { return Values; }
        }
    }
}
