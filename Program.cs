using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(5);
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "to");
            hash.Add(5, "be");

            FrequencyOfWord find = new FrequencyOfWord();
            find.Find_frequency(hash);

            string hash5 = hash.Get(5);
            Console.WriteLine("5th index value:" + hash5);

        }
    }
}
