using Decorator.Component;

namespace Decorator
{
    abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish dish;

        public Decorator(RestaurantDish dish)
        {
            this.dish = dish;
        }

        public override void Display()
        {
            dish.Display();
        }
    }
}
