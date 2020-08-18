using Company.Example.Interface;

namespace Company.Example
{
    public class AuditorFactory
    {
        public static IAuditor create()
        {
            return new FileSystemAuditor();
        }

    }
}
