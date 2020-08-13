using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Ex2_LazyLoading
{
    public sealed class Cache
    {

        public static Cache Instance;

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            if (Instance == null)
            {
                Instance = new Cache();
            }
            return Instance;
        }
    }
}
