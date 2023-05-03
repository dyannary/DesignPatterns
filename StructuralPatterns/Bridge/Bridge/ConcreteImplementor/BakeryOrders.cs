using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class BakeryOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Bakery.");
        }
    }
}
