using System;
using System.Collections.Generic;
using System.Text;

namespace genericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[];
        }
    
        public void Add(T item)
        {
            T[] tempArry = items; //geici olarak bilgiler ucmasın diye tutar 
            items = new T[items.Length+1];//eleman sayısı +1 artar 
            for (int i = 0; i < tempArry.Length; i++)
            {
                items[i] = tempArry[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
