using Observer.ConcreteObservers;
using Observer.ConcreteSubject;

Tomatoes tomatoes = new Tomatoes(3.42);
tomatoes.Attach(new Restaurant("First Restaurant", 3.37));
tomatoes.Attach(new Restaurant("Second Restaurand", 3.74));
tomatoes.Attach(new Restaurant("Third Restaurant", 3.75));

tomatoes.PricePerLeu = 3.38;
tomatoes.PricePerLeu = 3.36;
tomatoes.PricePerLeu = 3.74;
tomatoes.PricePerLeu = 3.41;

Console.ReadKey();
