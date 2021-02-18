using System;

namespace MyDictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictonary = new MyDictionary<int, string>();
            myDictonary.Add(5, "Ankara");
            myDictonary.List();
        }
    }
}
