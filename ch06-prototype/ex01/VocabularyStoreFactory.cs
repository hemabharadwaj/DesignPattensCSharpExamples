using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch06_prototype.ex01
{
    public class VocabularyStoreFactory
    {
        private static IVocabularyStore vocabularyStore = new DefaultVocabularyStore();

        public static IVocabularyStore getVocabularyStore()
        {
            return vocabularyStore.getCopy();
        }
    }
}
