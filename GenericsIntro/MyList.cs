using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //type
    {
        T[] items;

        public MyList()  ////// constructor !!!!!!!!!!!!!!!!!!!!! (ctor)
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; // geçici dizi
            items = new T[items.Length + 1]; // eleman sayısını bir arttır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //degerleri geri ver.
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }   //eleman sayısını verir.
        }
        public T[] Items
        {
            get { return items; }
        }

    }
}
