using System;

namespace AnagramsDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var anagram = new Anagram();
            var anagrams = anagram.FindAnagrams("pots");

            foreach (var entry in anagrams)
            {
                Console.WriteLine(entry);
            }

            Console.ReadKey();
        }
    }
}