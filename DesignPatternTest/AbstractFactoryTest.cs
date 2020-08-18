using AbstractFactory.ex01_ui_tools_factory;
using AbstractFactory.ex01_ui_tools_factory.factory.advanced;
using AbstractFactory.ex01_ui_tools_factory.factory.basic;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatternTest
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void Test1_check_basic_tools_factory()
        {
            Application application;
            IUIToolsFactory toolsFactory = new BasicToolsFactory();
            application = new Application(toolsFactory);
            Assert.Equal("BasicShape", application.getShape().getName());
            Assert.Equal("BasicToolButton", application.getToolButton().getName());
            Assert.Equal("BasicMenuList", application.getMenuList().getName());
        }

        [Fact]
        public void Test2_check_advanced_tools_factory()
        {
            Application application;
            IUIToolsFactory toolsFactory = new AdvancedToolsFactory();
            application = new Application(toolsFactory);

            Assert.Equal("AdvancedShape", application.getShape().getName());
            Assert.Equal("AdvancedToolButton", application.getToolButton().getName());
            Assert.Equal("AdvancedMenuList", application.getMenuList().getName());
        }
    }
}
