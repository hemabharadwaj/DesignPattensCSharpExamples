using System;

namespace Company.Example.Interface
{
    public interface IShapeFactory
    {
        IShape create(String type);
    }
}
