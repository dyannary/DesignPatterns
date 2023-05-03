using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
    public class ProductDairyFreeOrder : ProductOrder
    {
        public override void Send()
        {
            store.Place("Dairy-Free Order");
        }
    }
}
