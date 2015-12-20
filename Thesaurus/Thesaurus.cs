using System.Collections.Generic;
using System.Linq;

namespace Thesaurus
{
    public class Thesaurus : IThesaurus
    {
        List<List<string>> _wordList = new List<List<string>>();

        public void AddSynonyms(IEnumerable<string> synonyms)
        {
            //Check if the words being added already is in the thesaurus
            if (_wordList.Any(x => x.Intersect(synonyms).Any()))
            {
                //Check if an entire sequence in the thesaurus exists in the sequence to be added (that is, the stored sequence is being updated with additional words)
                //var query = _wordList.All(x => x.Contains(synonyms);
                if (_wordList.All(x => x.Intersect(synonyms).Any()))
                {
                    int index = _wordList.FindIndex(x => x.Intersect(synonyms).Any());
                    _wordList.Insert(index, _wordList.ElementAt(index).Union(synonyms).ToList());
                    _wordList.RemoveAt(index + 1);
                }
                //Otherwise assume that the added sequence is of different meaning than the existing sequence(s)
                else
                {
                    _wordList.Add(synonyms.ToList());
                }

            }
            else//*/
            {
                //If not, then safely add the entire sequence as a new entry
                _wordList.Add(synonyms.ToList());
            }
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            //Find the lists containing the word, then exclude the word that was used to search on since it looks strange that a word is a synonym to itself
            return _wordList.Where(x => x.Contains(word)).SelectMany(x => x).Except(new[] { word });
        }

        public IEnumerable<string> GetWords()
        {
            return _wordList.SelectMany(x => x);
        }
    }
}