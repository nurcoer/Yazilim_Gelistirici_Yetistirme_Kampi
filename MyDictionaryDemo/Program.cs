using System;
using System.Collections.Generic;

namespace MyDictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Kadriye");
            myDictionary.Add(2, "Türkan");
            myDictionary.Add(3, "Emre");
            myDictionary.Add(4, "Ali");



            Console.WriteLine(myDictionary.Count);
            Console.ReadLine();

        }
    }
}
