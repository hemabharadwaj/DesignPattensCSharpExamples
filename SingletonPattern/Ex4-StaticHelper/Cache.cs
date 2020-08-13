using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Ex4_StaticHelper
{
    public sealed class Cache
    {
        private static class SingletonHelper
        {
            public static Cache Instance = new Cache();
        }

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            return SingletonHelper.Instance;
        }
    }
}
