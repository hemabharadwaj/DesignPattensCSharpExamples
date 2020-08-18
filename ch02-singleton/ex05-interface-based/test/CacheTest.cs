using Company.Example.Interface;
using Xunit;

namespace Company.Example
{
    public class CacheTest
    {
        private ICache target;

        public CacheTest()
        {
            target = Cache.getInstance();
        }
        [Fact]
        public void check_object_is_same()
        {           
            Cache cache = Cache.getInstance();
            Assert.Equal(target, cache);
        }

        [Fact]
        public void check_key_returned()
        {
            target.setValue("key", "value1");
            string value = target.getValue("key");
            Assert.Equal("value1", value);
        }
    }
}
