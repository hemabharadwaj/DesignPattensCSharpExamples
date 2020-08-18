using Company.Example.Interface;

namespace Company.Example
{
    public class BasicToolsFactory : IUIToolsFactory
    {
        public IMenuList createMenuList(string type)
        {
            return new BasicMenuList();
        }

        public IShape createShape(string type)
        {
            return new BasicShape();
        }

        public IToolButton createToolButton(string type)
        {
            return new BasicToolButton();
        }
    }
}
