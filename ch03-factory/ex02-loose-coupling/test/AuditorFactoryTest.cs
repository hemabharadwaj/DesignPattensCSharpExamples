using Company.Example.Interface;
using Xunit;

namespace Company.Example
{
    public class AuditorFactoryTest
    {

        [Fact]
        public void object_is_created()
        {
            IAuditor auditor = AuditorFactory.create();
            Assert.Equal("Company.Example.FileSystemAuditor", auditor.GetType().ToString());
        }
    }
}
