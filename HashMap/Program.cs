using System;
using System.Collections.Generic;

namespace HashMap
{
    class BadDictionary<TKey, TValue>
    {
        List<KeyValuePair<TKey, TValue>> data;
        public BadDictionary()
        {
            data = new List<KeyValuePair<TKey, TValue>>();
        }

        public void Add(TKey key, TValue value)
        {
            //FIXME: check for existing key, either overwrite it or throw an exception
            data.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue Search(TKey key)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if(data[i].Key.Equals(key))
                {
                    return data[i].Value;
                }
            }
            return default;
        }

        public void Remove(TKey key)
        {
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Key.Equals(key))
                {
                    data.RemoveAt(i);
                }
            }
        }
    }

    class MyPoint
    {
        public int X;
        public int Y;

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override int GetHashCode()
        {
            return X;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            object myObj = new object();
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            Console.WriteLine("Hello World!");
        }
    }
}
