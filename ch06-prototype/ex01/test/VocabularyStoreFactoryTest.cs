using Company.Example.Interface;
using Xunit;

namespace Company.Example.Test
{
    public class VocabularyStoreFactoryTest
    {
        [Fact]
        void check_stores_are_different()
        {
            IVocabularyStore store1 = VocabularyStoreFactory.getVocabularyStore();
            IVocabularyStore store2 = VocabularyStoreFactory.getVocabularyStore();
            Assert.NotEqual(store1, store2);
        }

        [Fact]
        void check_stores_are_differentcontain_base_words()
        {
            IVocabularyStore store1 = VocabularyStoreFactory.getVocabularyStore();
            IVocabularyStore store2 = VocabularyStoreFactory.getVocabularyStore();
            Assert.Equal("n. Not an issue", store1.getMeaning("feature"));
            Assert.Equal("n. Slogging for the whole night", store1.getMeaning("night"));

            Assert.Equal("n. Not an issue", store2.getMeaning("feature"));
            Assert.Equal("n. Slogging for the whole night", store2.getMeaning("night"));
        }

    }
}
