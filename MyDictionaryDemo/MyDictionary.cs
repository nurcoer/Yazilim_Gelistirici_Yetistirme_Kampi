using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    public class MyDictionary<Tkey,Tval> 
    {
        //üzerinde işlem yapılacak  tipte dictionarylerin tanımlanması
        MyDictList<Tkey,Tval>[] _myDictLists;
        MyDictList<Tkey, Tval>[] _tempDictLists;

        //ctor oluşturulan dictionary'nin 0 boyutlu key ve value ya
        //sahip  dizisinin oluşturulması 
        public MyDictionary()
        {
            _myDictLists = new MyDictList<Tkey, Tval>[0];
        }

        //MyDictionarye key ve value ekleme sistemi.
        public void Add(Tkey key,Tval val)
        {
            _tempDictLists = _myDictLists;
            _myDictLists = new MyDictList<Tkey, Tval>[_myDictLists.Length + 1];

           

            for (int i = 0 ; i < _tempDictLists.Length; i++)
            {
                _myDictLists[i] = _tempDictLists[i];
            }

            MyDictList<Tkey, Tval> newDict = new MyDictList<Tkey, Tval> ();
            newDict.key = key;
            newDict.value = val;

            _myDictLists[_myDictLists.Length - 1] = newDict;
        }

        //MyDictionary uzunluğunu döndürür.
        public int Count { get { return _myDictLists.Length; } }

    }
}
