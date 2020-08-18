using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{   
    public sealed class Cache
    {
        public static Cache Instance = new Cache();

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            return Instance;
        }
    }
    
}
