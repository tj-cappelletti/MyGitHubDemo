﻿using System;

namespace AnagramsDemo
{
    internal class Program
    {
        private static void Main(string[] args)
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