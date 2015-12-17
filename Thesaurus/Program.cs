using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    class Program
    {
        static void Main(string[] args)
        {
            Thesaurus thesaurus = new Thesaurus();
            bool cont = true;
            while(cont)
            {
                Console.WriteLine("1: Add synonyms");
                Console.WriteLine("2: Get synonyms");
                Console.WriteLine("3: Get words");
                Console.WriteLine("0: Exit");
                ConsoleKey choice = Console.ReadKey().Key;
                Console.WriteLine();

                switch(choice)
                {
                    case ConsoleKey.D1:
                        {
                            AddSynonyms(thesaurus);
                            break;
                        }
                    case ConsoleKey.NumPad1:
                        {
                            AddSynonyms(thesaurus);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            GetSynonyms(thesaurus);
                            break;
                        }
                    case ConsoleKey.NumPad2:
                        {
                            GetSynonyms(thesaurus);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            break;
                        }
                    case ConsoleKey.NumPad3:
                        {
                            GetSynonyms(thesaurus);
                            break;
                        }
                    case ConsoleKey.D0:
                        {
                            GetSynonyms(thesaurus);
                            cont = false;
                            break;
                        }
                    case ConsoleKey.NumPad0:
                        {
                            cont = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Unknown command");
                            break;
                        }
                }
            }
        }

        static void AddSynonyms(Thesaurus _thesaurus)
        {
            bool cont = true;

            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Add synonyms, press ESCAPE to complete.");

            List<string> synonyms = new List<string>();

            //_thesaurus.AddSynonyms(synonyms)
        }

        static void GetSynonyms(Thesaurus _thesaurus)
        {
            Console.Write("Enter word to find synonyms for: ");
            string word = Console.ReadLine();

            foreach(string synonym in _thesaurus.GetSynonyms(word))
            {
                Console.WriteLine(synonym);
            }
        }

        static void GetWords(Thesaurus _thesaurus)
        {
            foreach (string word in _thesaurus.GetWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}
