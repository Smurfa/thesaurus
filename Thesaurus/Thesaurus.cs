using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    public class Thesaurus : IThesaurus
    {
        //Dictionary<string, List<string>> _words = new Dictionary<string, List<string>>();
        List<List<string>> _wordList = new List<List<string>>();

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            _words.Add(synonyms.ToList());
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            //TODO: Why am I not allowed to write it on single line? Exludes first element but not the others in a list.
            //return _wordList.FirstOrDefault(x => x.Contains(word)).Where((y, i) => i != y.IndexOf(word));

            // Works as well
            //return _wordList.FirstOrDefault(x => x.Contains(word)).Except(new[] { word });

            var synonyms = _wordList.FirstOrDefault(x => x.Contains(word));
            return synonyms.Where((y, i) => i != y.IndexOf(word));
        }

        public IEnumerable<string> GetWords()
        {
            return _wordList.SelectMany(x => x.ToList());
        }
    }
}