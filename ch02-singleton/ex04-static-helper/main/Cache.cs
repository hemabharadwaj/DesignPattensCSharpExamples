namespace Company.Example
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
