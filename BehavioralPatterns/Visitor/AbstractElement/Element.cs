using Visitor.Visitor;

namespace Visitor.AbstractElement
{
    abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
