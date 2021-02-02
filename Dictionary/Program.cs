using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Ted");
            myDictionary.Add(2, "Barney");
            myDictionary.Add(3, "Marshall");

            for (int i = 0; i < myDictionary.keys.Length; i++)
            {
                Console.WriteLine(myDictionary.keys[i] + " " + myDictionary.values[i]);
            }
        }
    }
}
