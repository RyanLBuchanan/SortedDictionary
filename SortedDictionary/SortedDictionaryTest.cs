using System.Text.RegularExpressions;

namespace SortedDictionary
{
    internal class SortedDictionaryTest
    {
        static void Main(string[] args)
        {
            // Create sorted dictionary based on user input
            SortedDictionary<string, int> dictionary = CollectWords();

            DisplayDictionary(dictionary);
        }

        // Create sirted dictionary from user input
        private static SortedDictionary<string, int> CollectWords()
        {
            var dictionary = new SortedDictionary<string, int>();

            Console.WriteLine("Enter a string: ");  // Prompt for user input
            string input = Console.ReadLine();  // Get input

            // Split input text into tokens
            string[] words = Regex.Split(input, @"\s+");

            // Process input words
            foreach (var word in words)
            {
                var key = word.ToLower(); // Get word in lowercase

                // If the dictionary contains the word
                if (dictionary.ContainsKey(key))
                {
                    ++dictionary[key];
                }
                else
                {
                    dictionary.Add(key, 1);
                }
            }

            return dictionary;
        }

        // Display dictionary content 
        private static void DisplayDictionary<K, V>(SortedDictionary<K, V> dictionary)
        {
            Console.WriteLine($"\nSorted dictionary contains:\n{"Key", -12}{"Value", -12}");

            // Generate output for each key in the sorted dictionary 
            // by iterating through the keys property with a foreach statement
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key,-12}{dictionary[key], -12}");
            }

            Console.WriteLine($"\nsize: {dictionary.Count}");
        }
    }
}