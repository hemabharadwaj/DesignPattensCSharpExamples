using SingletonPattern;
using System;
using Xunit;

namespace DesignPatternTest
{
    public class SingletonTest
    {
        [Fact]
        public void Test1_EagerInitialization()
        {
           Cache cache = Cache.getInstance();
           Cache cache1 = Cache.getInstance();
           Assert.Equal(cache, cache1);
        }

        [Fact]
        public void Test1_LazyLoading()
        {
            SingletonPattern.Ex2_LazyLoading.Cache cache = SingletonPattern.Ex2_LazyLoading.Cache.getInstance();
            SingletonPattern.Ex2_LazyLoading.Cache cache1 = SingletonPattern.Ex2_LazyLoading.Cache.getInstance();
            Assert.Equal(cache, cache1);
        }

        [Fact]
        public void Test1_DoubleCheck()
        {
            SingletonPattern.Ex3_DoubleCheck.Cache cache = SingletonPattern.Ex3_DoubleCheck.Cache.getInstance();
            SingletonPattern.Ex3_DoubleCheck.Cache cache1 = SingletonPattern.Ex3_DoubleCheck.Cache.getInstance();
            Assert.Equal(cache, cache1);
        }

        [Fact]
        public void Test1_StaticHelper()
        {
            SingletonPattern.Ex4_StaticHelper.Cache cache = SingletonPattern.Ex4_StaticHelper.Cache.getInstance();
            SingletonPattern.Ex4_StaticHelper.Cache cache1 = SingletonPattern.Ex4_StaticHelper.Cache.getInstance();
            Assert.Equal(cache, cache1);
        }

        [Fact]
        public void Test1_IntefaceBased()
        {
            SingletonPattern.Ex5_IntefaceBased.Cache cache = SingletonPattern.Ex5_IntefaceBased.Cache.getInstance();
            SingletonPattern.Ex5_IntefaceBased.Cache cache1 = SingletonPattern.Ex5_IntefaceBased.Cache.getInstance();
            Assert.Equal(cache, cache1);

            cache.setValue("key", "value1");
            String value = cache.getValue("key");
            Assert.Equal("value1", value);
        }
    }
}
