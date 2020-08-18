using Company.Example.Interface;
using System;
using System.Collections.Generic;

namespace Company.Example
{
    public sealed class Cache : ICache
    {

        public static Cache Instance = new Cache();
        private Dictionary<String, String> cacheMap = new Dictionary<string, string>();

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            return Instance;
        }

        public string getValue(string key)
        {
            return cacheMap[key];
        }

        public void setValue(string key, string value)
        {
            cacheMap.Add(key, value);
        }
    }
}
