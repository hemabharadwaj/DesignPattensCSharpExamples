using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ex1_basic_factory
{
    public interface IShapeFactory
    {
        IShape create(String type);
    }
}
