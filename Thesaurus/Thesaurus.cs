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

            
            List<string> temp = new List<string>();
            temp.Add("test");
            temp.Add("test2");
            temp.Add("test3");
            temp.Add("test4");

            return temp;
        }

        public IEnumerable<string> GetWords()
        {
            throw new Exception("Not yet implemented");
        }
    }
}