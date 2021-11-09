using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class RemoveWord
    {
        public void Remove(MyMapNode<int, string> hash, string name)
        {
            int key = 0;
            while (key <= hash.size)
            {
                string hash_value = hash.Get(key).ToLower();
                if (hash_value == name) 
                {
                    hash.Remove(key);
                    Console.WriteLine($"\n \n{name} is removed  \n");
                }
              
                key++;
            }
        }
    }
}
