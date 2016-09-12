using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramsDemo
{
    public class Anagram
    {
        private readonly String filePath;

        public Anagram()
        {
            filePath = ConfigurationManager.AppSettings["WordListFile"];
        }

        public List<String> FindAnagrams(String word)
        {
            List<String> anagrams = new List<String>();
            Dictionary<char, int> wordLetters = GenerateCharterDictionary(word);

            using (StreamReader streamReader = File.OpenText(filePath))
            {
                while (!streamReader.EndOfStream)
                {
                    String entry = streamReader.ReadLine();

                    if (entry.Length == word.Length)
                    {
                        Dictionary<char, int> entryLetters = GenerateCharterDictionary(entry);

                        if (wordLetters.Count == entryLetters.Count)
                        {
                            bool match = true;

                            foreach (KeyValuePair<char, int> kvp in wordLetters)
                            {
                                if (!entryLetters.ContainsKey(kvp.Key) || entryLetters[kvp.Key] != kvp.Value)
                                    match = false;
                            }

                            if (match)
                                anagrams.Add(entry);
                        }
                    }
                    else
                        continue;
                }
            }

            return anagrams;
        }

        private Dictionary<char, int> GenerateCharterDictionary(String word)
        {
            string lowerWord = word.ToLower();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char character in lowerWord)
            {
                if (dictionary.ContainsKey(character))
                    dictionary[character]++;
                else
                    dictionary.Add(character, 1);
            }

            return dictionary;
        }
    }
}
