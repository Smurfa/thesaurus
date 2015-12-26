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
            _thesaurus.AddSynonyms(_words);
            _words = new List<string> { "show", "drama", "play", "performance" };
            _thesaurus.AddSynonyms(_words);

            _words = new List<string> { "consume", "eat" };
            _thesaurus.AddSynonyms(_words);
            _words = new List<string> { "fun", "play", "sport" };
            _thesaurus.AddSynonyms(_words);

            Console.WriteLine("--ALL WORDS--");
            foreach (string s in _thesaurus.GetWords())
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--SYNONYMS TO: play--");
            foreach (string s in _thesaurus.GetSynonyms("play"))
            {
                Console.WriteLine(s);
            }

            _words = new List<string> { "performance", "work", "achievment" };
            _thesaurus.AddSynonyms(_words);

            Console.WriteLine("\n--SYNONYMS TO: performance--");
            foreach (string s in _thesaurus.GetSynonyms("performance"))
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n--ALL WORDS--");
            foreach (string s in _thesaurus.GetWords())
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}