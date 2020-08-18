using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Example.Interface
{
    public interface IUIToolsFactory
    {
        IToolButton createToolButton(String type);
        IShape createShape(String type);
        IMenuList createMenuList(String type);
    }
}
