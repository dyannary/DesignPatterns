using Visitor.AbstractElement;

namespace Visitor.Visitor
{
    interface IVisitor
    {
        void Visit(Element element);
    }
}
