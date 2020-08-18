using Company.Example.Interface;

namespace Company.Example
{
    public class DatabaseAuditor : IAuditor
    {
        public void log(string message)
        {
            // write to database
        }
    }
}
