using System.Linq;
using System;

namespace Day15_HashTablesProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str = "To be or not to be";
            int[] freq = new int[str.Length];
            int i, j;

            //Converts given string into character array  
            char[] string1 = str.ToCharArray();

            for (i = 0; i < str.Length; i++)
            {
                freq[i] = 1;
                for (j = i + 1; j < str.Length; j++)
                {
                    if (string1[i] == string1[j])
                    {
                        freq[i]++;

                        //Set string1[j] to 0 to avoid printing visited character  
                        string1[j] = '0';
                    }
                }
            }

            //Displays the each character and their corresponding frequency  
            Console.WriteLine("Characters and their corresponding frequencies");
            for (i = 0; i < freq.Length; i++)
            {
                if (string1[i] != ' ' && string1[i] != '0')
                    Console.WriteLine(string1[i] + "-" + freq[i]);
            }
        }

    }
}