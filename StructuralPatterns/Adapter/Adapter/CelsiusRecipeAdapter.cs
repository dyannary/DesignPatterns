namespace Adapter
{
    public class CelsiusRecipeAdapter : IFoodRecipe
    {
        private FahrenheitRecipe _fahrenheitRecipe;

        public CelsiusRecipeAdapter(FahrenheitRecipe fahrenheitRecipe)
        {
            _fahrenheitRecipe = fahrenheitRecipe;
        }

        public void Cook(decimal degrees)
        {
            decimal recipeDegrees = (degrees - 32) * 5 / 9;

            _fahrenheitRecipe.Cook(recipeDegrees);
        }
    }
}
