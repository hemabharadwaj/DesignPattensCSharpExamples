using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Ex1_basic_factory
{
    public class BasicShapeFactory : IShapeFactory
    {
        public IShape create(string type)
        {
            if (type.Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (type.Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
