using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Ex3_DoubleCheck
{
    public sealed class Cache
    {

        public static Cache Instance;
        private static readonly object Cachelock = new object();

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            if (Instance == null)
            {
                lock(Cachelock)
                {
                    if (Instance == null)
                    {
                        Instance = new Cache();
                    }
                }
            }
            return Instance;
        }
    }
}
