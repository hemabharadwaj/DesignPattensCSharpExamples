using Company.Example.Interface;

namespace Company.Example
{
    public class SomeFeature
    {
        public void feature()
        {
            IAuditor auditor = AuditorFactory.create();
            auditor.log("feature was called.");
        }
    }
}
