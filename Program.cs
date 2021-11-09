using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the UC2 Hash Table");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves" +
                               " deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(para.Length-1);
            for (int i=0;i<para.Length;i++)
            {
                hash.Add(i, para[i]);

            }

            FrequencyOfWord find = new FrequencyOfWord();
            find.Find_frequency(hash);



        }
    }
}
