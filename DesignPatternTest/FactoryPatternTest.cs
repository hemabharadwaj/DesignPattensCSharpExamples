using FactoryPattern.Ex1_basic_factory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternTest
{
    public class FactoryPatternTest
    {

        [Fact]
        public void Test1_BasicShapeFactory()
        {
            BasicShapeFactory basicShapeFactory = new BasicShapeFactory();
            IShape circle = basicShapeFactory.create("CIRCLE");
            IShape rectangle = basicShapeFactory.create("RECTANGLE");

            Assert.Equal("Circle", circle.getName());
            Assert.Equal("Rectangle", rectangle.getName());
        }
    }
}
