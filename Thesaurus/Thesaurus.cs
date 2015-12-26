using System.Collections.Generic;
using System.Linq;

namespace Thesaurus
{
    public class Thesaurus : IThesaurus
    {
        Dictionary<string, List<string>> _wordList = new Dictionary<string, List<string>>();

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            foreach (string s in synonyms)
            {
                //Check if the word that is to be added already exists in thesaurus.
                if (_wordList.ContainsKey(s))
                {
                    //In that case, the word is to be updated with additional synonyms.
                    _wordList[s].InsertRange(0, _wordList[s].Union(synonyms).Except(_wordList[s]).Except(new[] { s }));
                }
                else
                {
                    //The word is new to the thesaurus and can safely be added with its synonyms.
                    _wordList.Add(s, synonyms.Except(new[] { s }).ToList());
                }
            }
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            return _wordList[word];
        }

        public IEnumerable<string> GetWords()
        {
            return _wordList.Keys;
        }
    }
}