using Bridge.Abstraction;
using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;

ProductOrder _sendOrder = new ProductDairyFreeOrder();
_sendOrder.store = new GroceryStoreOrders();
_sendOrder.Send();

_sendOrder.store = new BakeryOrders();
_sendOrder.Send();

_sendOrder = new ProductGlutenFreeOrder();
_sendOrder.store = new GroceryStoreOrders();
_sendOrder.Send();

_sendOrder.store = new BakeryOrders();
_sendOrder.Send();

Console.ReadKey();