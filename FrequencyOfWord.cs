using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    class FrequencyOfWord
    {
        Dictionary<string, int> frequency= new Dictionary<string, int>();

       

        internal void Find_frequency(MyMapNode<int, string> hash)
        {
            int key = 0;
            while (key <= hash.size)
            {
                string hash_value = hash.Get(key).ToLower();
                if (frequency.Count == 0)
                {
                    frequency.Add(hash_value, 1);
                }
                else
                { int check = 0;
                    foreach (var item in frequency)
                    {
                        if (item.Key == hash_value)
                            check = 1;

                    }
                    if(check==1)
                        frequency[hash_value]++;
                    else
                        frequency.Add(hash_value, 1);
                }
                key++;
            }
            foreach (var item in frequency)
            {
                Console.WriteLine($"frequency of word '{item.Key}' is {item.Value}");
            }
        }
    }
}
