using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Example
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
            this.wordMap.Add("feature", "n. Not an issue");
            this.wordMap.Add("night", "n. Slogging for the whole night");
        }



        public IVocabularyStore getCopy()
        {
            Dictionary<String, String> newWordMap = new Dictionary<String, String>();
            foreach (var entry in wordMap)
            {
                newWordMap.Add(entry.Key, entry.Value);
            }
            return new DefaultVocabularyStore(newWordMap);
        }

        public string getMeaning(string word)
        {
            return wordMap[word];
        }

        public List<string> getUnlearnedWords()
        {
            // some logic
            return null;
        }

        public int getWordCount()
        {
            return wordMap.Count;
        }

        public List<string> getWordList()
        {
            return wordMap.Keys.ToList();
        }

        public void setWordLearned(string word)
        {
            // some logic
        }

        public void setWordUnLearned(string word)
        {
            // some logic
        }

    }
}
