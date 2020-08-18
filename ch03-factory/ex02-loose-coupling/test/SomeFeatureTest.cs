using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Company.Example
{
    public class SomeFeatureTest
    {
        [Fact]
        public void object_is_created()
        {
            SomeFeature target;
            target = new SomeFeature();
            Assert.NotNull(target);
        }
    }
}
