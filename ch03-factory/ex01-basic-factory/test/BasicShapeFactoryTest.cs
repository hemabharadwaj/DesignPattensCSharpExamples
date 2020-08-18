using Company.Example;
using Company.Example.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Company.Example
{
    public class BasicShapeFactoryTest
    {

        [Fact]
        public void check_object_created()
        {
            BasicShapeFactory target = new BasicShapeFactory();
            IShape circle = target.create("CIRCLE");
            IShape rectangle = target.create("RECTANGLE");

            Assert.Equal("Circle", circle.getName());
            Assert.Equal("Rectangle", rectangle.getName());
        }
    }
}
