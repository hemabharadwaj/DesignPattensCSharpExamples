using Company.Example.Interface;
using Xunit;

namespace Company.Example.test
{
    public class ApplicationTest
    {

        [Fact]
        public void check_basic_tools_factory()
        {
            Application application;
            IUIToolsFactory toolsFactory = new BasicToolsFactory();
            application = new Application(toolsFactory);
            Assert.Equal("BasicShape", application.getShape().getName());
            Assert.Equal("BasicToolButton", application.getToolButton().getName());
            Assert.Equal("BasicMenuList", application.getMenuList().getName());
        }

        [Fact]
        public void check_advanced_tools_factory()
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
