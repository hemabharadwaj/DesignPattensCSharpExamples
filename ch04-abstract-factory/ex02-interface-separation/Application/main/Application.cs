using Company.Example.Interface;

namespace Company.Example
{
    public class Application
    {
        private  IUIToolsFactory toolsFactory;
        private  IToolButton toolButton;
        private  IShape shape;
        private  IMenuList menuList;

        public Application(IUIToolsFactory toolsFactory)
        {
            this.toolsFactory = toolsFactory;
            this.toolButton = toolsFactory.createToolButton("TOOL_1");
            this.shape = toolsFactory.createShape("CIRCLE");
            this.menuList = toolsFactory.createMenuList("FILE");
        }

        public IShape getShape()
        {
            return this.shape;
        }

        public IToolButton getToolButton()
        {
            return this.toolButton;
        }

        public IMenuList getMenuList()
        {
            return this.menuList;
        }
    }
}
