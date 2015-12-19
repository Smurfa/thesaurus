using System;
using System.Collections.Generic;

namespace Thesaurus
{
    class Program
    {
        static void Main(string[] args)
        {
            IThesaurus _thesaurus = new Thesaurus();

            List<string> _words = new List<string> { "test1", "test2", "test3" };
            AddSynonyms(_thesaurus, _words);
            _words = new List<string> { "temp1", "temp2", "temp3", "temp4" };
            AddSynonyms(_thesaurus, _words);
            _words = new List<string> { "word1", "word2" };
            AddSynonyms(_thesaurus, _words);

            GetWords(_thesaurus);
            Console.WriteLine();
            GetSynonyms(_thesaurus, "temp2");
            Console.WriteLine();

            _words = new List<string> { "test2", "test4", "test5" };
            AddSynonyms(_thesaurus, _words);
            GetSynonyms(_thesaurus, "test2");

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