using System;
using System.Collections.Generic;


namespace Day15_HashTablesProgram
{
    internal class HashTable
    {
        // Function to count frequency of
        // words in the given string
        static void Count_freq(String str)
        {
            SortedDictionary<String,int> mp = new SortedDictionary<String, int>();

            // Splitting to find the word
            String[] arr = str.Split(' ');

            // Loop to iterate over the words
            for (int i = 0; i < arr.Length; i++)
            {

                // Condition to check if the
                // array element is present
                // the hash-map
                if (mp.ContainsKey(arr[i]))
                {
                    mp[arr[i]] = mp[arr[i]] + 1;
                }
                else
                {
                    mp.Add(arr[i], 1);
                }
            }

            // Loop to iterate over the
            // elements of the map
            foreach (KeyValuePair<String, int> entry in mp)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
