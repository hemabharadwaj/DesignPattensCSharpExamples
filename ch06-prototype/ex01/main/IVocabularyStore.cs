using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example.Interface
{
    public interface IVocabularyStore
    {
        int getWordCount();
        List<String> getWordList(); 
        String getMeaning(String word);
        List<String> getUnlearnedWords();
        void setWordLearned(String word);
        void setWordUnLearned(String word);
        IVocabularyStore getCopy();
    }
}
