using FactoryPattern.Ex1_basic_factory;
using FactoryPattern.Ex2_loose_coupling;
using FactoryPattern.Ex3_encapsulation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternTest
{
    public class FactoryPatternTest
    {

        [Fact]
        public void Test1_Ex1_BasicShapeFactory()
        {
            BasicShapeFactory basicShapeFactory = new BasicShapeFactory();
            IShape circle = basicShapeFactory.create("CIRCLE");
            IShape rectangle = basicShapeFactory.create("RECTANGLE");

            Assert.Equal("Circle", circle.getName());
            Assert.Equal("Rectangle", rectangle.getName());
        }

        [Fact]
        public void Test2_Ex2_AuditorFactoryTest()
        {
            IAuditor auditor = AuditorFactory.create();
            Assert.Equal("FactoryPattern.Ex2_loose_coupling.FileSystemAuditor", auditor.GetType().ToString());
        }

        [Fact]
        public void Test3_Ex2_SomeFeatureTest()
        {
            SomeFeature target;
            target = new SomeFeature();
            Assert.NotNull(target);           
        }

        [Fact]
        public void Test4_Ex3_ClaimCreatorTest()
        {
            ClaimCreator target;
            target = new ClaimCreator();
            Assert.NotNull(target);
        }
    }
}
