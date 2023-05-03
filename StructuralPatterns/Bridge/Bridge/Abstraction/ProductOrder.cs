using Bridge.Implementor;

namespace Bridge.Abstraction
{
    public abstract class ProductOrder
    {
        public IOrderingSystem store;

        public abstract void Send();
    }
}
