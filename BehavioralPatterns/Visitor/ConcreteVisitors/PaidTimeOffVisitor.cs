using Visitor.AbstractElement;
using Visitor.ConcreteElements;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitors
{
    class PaidTimeOffVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            employee.PaidTimeOffDays += 3;
            Console.WriteLine($"{employee.GetType().Name} " +
                $"{employee.Name}'s new vacation days: " +
                $"{employee.PaidTimeOffDays}");
        }
    }
}
