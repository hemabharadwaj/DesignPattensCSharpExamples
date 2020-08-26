using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example
{
    public class Resume
    {
        private List<String> sectionList = new List<String>();

        public void addSection(String section)
        {
            sectionList.Add(section);
        }

        public String toString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(String section in sectionList)
            {
                builder.Append(section);
            }
            return builder.ToString();
        }
    }
}
