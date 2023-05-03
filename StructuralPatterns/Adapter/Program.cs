using Adapter;

FahrenheitRecipe fahrenheitRecipe = new FahrenheitRecipe();

IFoodRecipe reciepeCelsius = new CelsiusRecipeAdapter(fahrenheitRecipe);

reciepeCelsius.Cook(350);