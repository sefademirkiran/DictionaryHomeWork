using System;

namespace DictionaryHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(34, "İstanbul");
            myDictionary.Add(06, "Ankara");
            myDictionary.Add(41, "Kocaeli");
            myDictionary.Add(27, "Gaziantep");

            Console.WriteLine("Şehirler : ");
            for (int i = 0; i < myDictionary.Length; i++)
            {
                Console.WriteLine("Plaka Kodu:"+ myDictionary.Keys[i]+  " " +"Şehir Adı :"+ " " + myDictionary.Values[i]);
            }
        }
    }
}
