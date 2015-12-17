using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesaurus
{
    public class Thesaurus 
    {
        List<Word> _words = new List<Word>();
        
        public void AddSynonyms()
        {
            
        }

        public IEnumerable<string> GetSynonyms(string word)
        {
            throw new Exception("Not implemented yet");
        }

        public IEnumerable<string> GetWords()
        {
            throw new Exception("Not implemented yet");
        }
    }
}
}
