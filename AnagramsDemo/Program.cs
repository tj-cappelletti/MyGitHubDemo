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
            Console.WriteLine("Please enter a word you would like to find anagrams for:");
            var word = Console.ReadLine();

            Anagram anagram = new Anagram();
            List<String> anagrams = anagram.FindAnagrams(word);

            foreach (var entry in anagrams)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}
