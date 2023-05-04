using Decorator.ConcreteComponent;
using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorator;

FreshSalad caesarSalad = new FreshSalad("Greek Salad", "Primavera", "Caesar Salad");
caesarSalad.Display();

Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Garlic sauce pasta");
fettuccineAlfredo.Display();

Console.WriteLine("\nMaking these dishes available.");

Available caesarAvailable = new Available(caesarSalad, 2);
Available alfredoAvailable = new Available(fettuccineAlfredo, 3);

caesarAvailable.OrderItem("John");
caesarAvailable.OrderItem("Alex");
caesarAvailable.OrderItem("Alice");

alfredoAvailable.OrderItem("Frank");
alfredoAvailable.OrderItem("Tim");
alfredoAvailable.OrderItem("Lele");
alfredoAvailable.OrderItem("Diana");  

caesarAvailable.Display();
alfredoAvailable.Display();

Console.ReadKey();