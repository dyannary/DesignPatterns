namespace Adapter
{
    public class FahrenheitRecipe 
    {
        public void Cook(decimal degrees)
        {
            Console.WriteLine("Preheat oven to {0:00} degrees.", degrees);
            Console.WriteLine("Mix ingredients together.");
            Console.WriteLine("Bake for 20 minutes at {0:00} degrees.", degrees);
        }
    }
}
