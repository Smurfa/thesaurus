using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    public class Thesaurus 
    {
        //Dictionary<string, List<string>> _words = new Dictionary<string, List<string>>();
        List<List<string>> _words = new List<List<string>>();

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            _words.Add(synonyms.ToList());
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            //TODO: Filter so that the word searched for isn't returned as well.
            return _words.FirstOrDefault(x => x.Contains(word));
        }

        public IEnumerable<string> GetWords()
        {
            return _words.SelectMany(words => words.ToList());
        }
    }
}