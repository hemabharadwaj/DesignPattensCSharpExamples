using Company.Example.Interface;

namespace Company.Example
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
