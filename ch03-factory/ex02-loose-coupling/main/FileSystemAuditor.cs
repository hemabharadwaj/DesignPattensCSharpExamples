using Company.Example.Interface;

namespace Company.Example
{
    public class FileSystemAuditor : IAuditor
    {
        public void log(string message)
        {
            // write to file system
        }
    }
}
