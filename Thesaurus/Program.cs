using System;
using System.Collections.Generic;

namespace Thesaurus
{
    class Program
    {
        static void Main(string[] args)
        {
            IThesaurus _thesaurus = new Thesaurus();

            List<string> _words = new List<string> { "play", "performance", "show" };
            AddSynonyms(_thesaurus, _words);
            _words = new List<string> { "show", "drama", "play", "performance" };
            AddSynonyms(_thesaurus, _words);
            _words = new List<string> { "consume", "eat" };
            AddSynonyms(_thesaurus, _words);
            _words = new List<string> { "fun", "play", "sport" };
            AddSynonyms(_thesaurus, _words);

            Console.WriteLine("--ALL WORDS--");
            GetWords(_thesaurus);

            Console.WriteLine("\n--SYNONYMS TO: play--");
            GetSynonyms(_thesaurus, "play");

            _words = new List<string> { "performance", "work", "achievment" };
            AddSynonyms(_thesaurus, _words);

            Console.WriteLine("\n--SYNONYMS TO: performance--");
            GetSynonyms(_thesaurus, "performance");

            Console.WriteLine("\n--ALL WORDS--");
            GetWords(_thesaurus);

            Console.ReadLine();
        }

        static void AddSynonyms(IThesaurus thesaurus, IEnumerable<string> words)
        {
            thesaurus.AddSynonyms(words);
        }

        static void GetSynonyms(IThesaurus thesaurus, string word)
        {
            try
            {
                foreach (string synonym in thesaurus.GetSynonyms(word))
                {
                    Console.WriteLine(synonym);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: " + e.ToString() + "\nWord probably did not exist.");
            }
            
        }

        static void GetWords(IThesaurus thesaurus)
        {
            foreach (string word in thesaurus.GetWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}