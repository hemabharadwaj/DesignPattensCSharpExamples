using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch06_prototype.ex01
{
    public class DefaultVocabularyStore : IVocabularyStore
    {
        private Dictionary<String, String> wordMap;
        private DefaultVocabularyStore(Dictionary<String, String> wordMap)
        {
            this.wordMap = wordMap;
        }
        public DefaultVocabularyStore()
        {
            this.wordMap = new Dictionary<string, string>();
            // expensive word loading operation here
            this.wordMap.put("feature", "n. Not an issue");
            this.wordMap.put("night", "n. Slogging for the whole night");
        }



        public IVocabularyStore getCopy()
        {
            Dictionary<String, String> newWordMap = new Dictionary<String, String>();
            for (Entry<String, String> entry : wordMap.entrySet())
            {
                newWordMap.put(entry.getKey(), entry.getValue());
            }
            return new DefaultVocabularyStore(newWordMap);
        }

        public string getMeaning(string word)
        {
            return wordMap[word];
        }

        public List<string> getUnlearnedWords()
        {
            throw new NotImplementedException();
        }

        public int getWordCount()
        {
            return wordMap.Count;
        }

        public ISet<string> getWordList()
        {
            return wordMap.Keys.All();
        }

        public void setWordLearned(string word)
        {
            throw new NotImplementedException();
        }

        public void setWordUnLearned(string word)
        {
            throw new NotImplementedException();
        }
    }
}
