namespace Company.Example
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
