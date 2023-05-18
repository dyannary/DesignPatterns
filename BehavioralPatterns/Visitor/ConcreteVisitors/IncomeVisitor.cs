using Visitor.AbstractElement;
using Visitor.ConcreteElements;
using Visitor.Visitor;

namespace Visitor.ConcreteVisitors
{
    class IncomeVisitor : IVisitor
    {
        public void Visit(Element element) 
        {
            Employee employee = element as Employee;

            employee.AnnualSalary *= 1.10;
            Console.WriteLine($"{employee.GetType().Name} " +
                $"{employee.Name}'s new income: " +
                $"{employee.AnnualSalary:C}");
        }
    }
}
