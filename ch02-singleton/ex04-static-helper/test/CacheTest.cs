using Xunit;

namespace Company.Example
{
    public class CacheTest
    {
        [Fact]
        public void check_object_is_same()
        {
            Cache target = Cache.getInstance();
            Cache cache = Cache.getInstance();
            Assert.Equal(target, cache);
        }
    }
}
