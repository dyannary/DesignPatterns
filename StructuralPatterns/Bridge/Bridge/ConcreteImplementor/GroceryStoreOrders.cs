using Bridge.Implementor;

namespace Bridge.ConcreteImplementor
{
    public class GroceryStoreOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Grocery Store.");
        }
    }
}
