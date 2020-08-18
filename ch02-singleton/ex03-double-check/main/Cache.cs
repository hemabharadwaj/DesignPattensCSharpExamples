namespace Company.Example
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
