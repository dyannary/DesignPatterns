using Composite.Component;

namespace Composite.Composite
{
    class ProductBox : IProduct
    {
        private List<IProduct> _subProducts;

        public ProductBox()
        {
            _subProducts = new List<IProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine($"\nName: {Name}. \nCategory: {Category}");
            Console.WriteLine("\nAll the products in the box: ");

            foreach(var subProduct in _subProducts)
            {
                subProduct.GetProductDetails();
            }
        }

        public decimal GetProductPrice()
        {
            Price = 0;

            foreach(var subProduct in _subProducts)
            {
                this.Price += subProduct.GetProductPrice();
            }

            Console.WriteLine("The total price: " + this.Price);

            return Price;
        }

        public void AddProduct(IProduct product)
        {
            _subProducts.Add(product);
        }

        public void RemoveProduct(IProduct product) 
        {
            _subProducts.Remove(product);
        }
    }
}
