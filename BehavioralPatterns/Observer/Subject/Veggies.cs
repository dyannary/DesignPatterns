using Observer.Observer;

namespace Observer.Subject
{
    abstract class Veggies
    {
        private double _pricePerLeu;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();

        public Veggies(double pricePerLeu)
        {
            _pricePerLeu = pricePerLeu;
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach(IRestaurant restaurant in _restaurants)
            {
                restaurant.Update(this);
            }
            Console.WriteLine("");
        }

        public double PricePerLeu
        {
            get { return _pricePerLeu; }
            set
            {
                if(_pricePerLeu != value)
                {
                    _pricePerLeu = value;
                    Notify(); 
                }
            }
        }
    }
}
