using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Anagram anagram = new Anagram();
            List<String> anagrams = anagram.FindAnagrams("pots");

            foreach(var entry in anagrams)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}
