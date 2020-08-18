using Xunit;

namespace Company.Example
{
    public class CacheTest
    {
        [Fact]
        public void check_object_is_same()
        {
            Cache cache = Cache.getInstance();
            Cache cache1 = Cache.getInstance();
            Assert.Equal(cache, cache1);
        }
    }
}
