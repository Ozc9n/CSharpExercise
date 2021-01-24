using System;
using System.Collections.Generic;

namespace MyDictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {//MyList<string> myList = new MyList<string>();
            //myList.Add("Hüseyin");
            //myList.Add("Ekrem");
            //myList.Add("Mustafa");
            //myList.Add("Serkan");

            //Console.WriteLine(myList.Find(3));

            //string[] dizi = new string[] {"Enes" , "Ensar" , "Nuri" };

            
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Woswos");
            myDictionary.Add(2, "BMW");
            myDictionary.Add(4, "Audi");


            //Console.WriteLine(myDictionary.Value(12));
            //Console.WriteLine(myDictionary.Key("Araba"));

            Console.WriteLine(myDictionary[4]);
            Console.WriteLine(myDictionary[2]);
            Console.WriteLine(myDictionary["BMW"]);
            Console.ReadLine();

        }
    }
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[tempArray.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            int index = items.Length - 1;
            items[index] = item;

        }
        public T Find(int index)
        {
            return items[index];
        }


    }

    class MyDictionary<TKey, TValue>
    {
        private List<TKey> _tKey;
        private List<TValue> _tValue;

        public MyDictionary()
        {
            _tKey = new List<TKey>();
            _tValue = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            _tKey.Add(key);
            _tValue.Add(value);
        }

        public TValue Value(TKey tKey)
        {
            int index = _tKey.IndexOf(tKey);
            return _tValue[index];
        }

        public TKey Key(TValue tValue)
        {
            int index = _tValue.IndexOf(tValue);
            return _tKey[index];
        }


        public TValue this[TKey tKey]
        {
            get
            {
                int index = _tKey.IndexOf(tKey);
                return _tValue[index];
            }
        }

        public TKey this[TValue tValue]
        {
            get
            {
                int index = _tValue.IndexOf(tValue);
                return _tKey[index];
            }
        }
    }
}