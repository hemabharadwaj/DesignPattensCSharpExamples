using Company.Example.Interface;

namespace Company.Example
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
