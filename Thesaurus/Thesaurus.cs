using System.Collections.Generic;
using System.Linq;

namespace Thesaurus
{
    public class Thesaurus : IThesaurus
    {
        List<List<string>> _wordList = new List<List<string>>();

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            //Check if any of the words being added already is in the thesaurus
            if (_wordList.Any(x => x.Intersect(synonyms).Any()))
            {
                int index = _wordList.FindIndex(x => x.Intersect(synonyms).Any());
                _wordList.Insert(index, _wordList.ElementAt(index).Union(synonyms).ToList());
                _wordList.RemoveAt(index + 1);
            }
            else
            {
                //If not, then safely add the entire list as a new entry
                _wordList.Add(synonyms.ToList());
            }
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            //Find the list containing the word, then exclude the word that was used to search on since it looks strange that a word is a synonym to itself
            return _wordList.FirstOrDefault(x => x.Contains(word)).Except(new[] { word });
        }

        public IEnumerable<string> GetWords()
        {
            return _wordList.SelectMany(x => x);
        }
    }
}