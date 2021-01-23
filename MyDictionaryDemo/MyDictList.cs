using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictList<Tkey,Tvalue>
    {
        //içerisinde key ve value değerine sahip bir nesne oluşturdum
        //bu şekilde key aracılığıyla value'ya ulaşabilicem.
        public Tkey key { get; set; }
        public Tvalue value { get; set; }
    }
}
