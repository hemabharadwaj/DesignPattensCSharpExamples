using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{
    public class Application
    {
        private IVocabularyStore vocabularyStore;

        public void start()
        {
            vocabularyStore = VocabularyStoreFactory.getVocabularyStore();
            // Use this store for the user
        }
    }
}
