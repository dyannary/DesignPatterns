using Observer.Observer;
using Observer.Subject;

namespace Observer.ConcreteObservers
{
    class Restaurant : IRestaurant
    {
        private string _name;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Veggies veggie)
        {
            Console.WriteLine($"Notified {_name} of {veggie.GetType().Name}'s price change to {veggie.PricePerLeu:C} per pound.");
            if(veggie.PricePerLeu < _purchaseThreshold)
            {
                Console.WriteLine($"{_name} wants to buy some {veggie.GetType().Name}!");
            }
        }

    }
}
