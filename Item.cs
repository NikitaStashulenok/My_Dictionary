﻿using System;
using System.Collections.Generic;
using System.Text;

namespace My_Dictionary
{
    class Item<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public Item(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
