﻿using System;
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
            Thesaurus _thesaurus = new Thesaurus();
            bool _cont = true;
            while(_cont)
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
                            AddSynonyms(_thesaurus);
                            break;
                        }
                    case ConsoleKey.NumPad1:
                        {
                            AddSynonyms(_thesaurus);
                            break;
                        }
                    case ConsoleKey.D2:
                        {
                            GetSynonyms(_thesaurus);
                            break;
                        }
                    case ConsoleKey.NumPad2:
                        {
                            GetSynonyms(_thesaurus);
                            break;
                        }
                    case ConsoleKey.D3:
                        {
                            GetWords(_thesaurus);
                            break;
                        }
                    case ConsoleKey.NumPad3:
                        {
                            GetWords(_thesaurus);
                            break;
                        }
                    case ConsoleKey.D0:
                        {
                            _cont = false;
                            break;
                        }
                    case ConsoleKey.NumPad0:
                        {
                            _cont = false;
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
            //bool cont = true;

            //Console.Write("Enter word: ");
            //string word = Console.ReadLine();
            //Console.WriteLine("Add synonyms, press ESCAPE to complete.");

            //List<string> synonyms = new List<string>();
            List<string> temp = new List<string>();
            temp.Add("test");
            temp.Add("test1");
            temp.Add("test2");

            _thesaurus.AddSynonyms(temp);
        }

        static void GetSynonyms(Thesaurus _thesaurus)
        {
            Console.Write("Enter word to find synonyms for: ");
            string word = Console.ReadLine();

            foreach (string synonym in _thesaurus.GetSynonyms(word))
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
