using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
    public class ProductGlutenFreeOrder : ProductOrder
    {
        public override void Send()
        {
            store.Place("Gluten-free Order");
        }
    }
}
