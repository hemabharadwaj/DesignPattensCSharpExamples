using Xunit;

namespace Company.Example
{
    public class ClaimCreatorTest
    {
        [Fact]
        public void object_is_created()
        {
            ClaimCreator target;
            target = new ClaimCreator();
            Assert.NotNull(target);
        }
    }
}
