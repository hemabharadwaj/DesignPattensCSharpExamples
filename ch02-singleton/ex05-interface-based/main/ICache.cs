using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example.Interface
{
    public interface ICache
    {
        String getValue(String key);
        void setValue(String key, String value);
    }
}
