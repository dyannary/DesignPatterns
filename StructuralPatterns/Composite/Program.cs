using Composite.Composite;
using Composite.Leaf;

Product mouse = new Product()
{
    Name = "Mouse",
    Price = 35.0m,
    Category = "Product"
};

Product laptop = new Product()
{
    Name = "Laptop",
    Price = 1200.00m,
    Category = "Product"
};

Product Monitor = new Product()
{
    Name = "Monitor",
    Price = 150.00m,
    Category = "Product"
};

ProductBox box = new ProductBox()
{
    Name = "Tech Box",
    Category = "Box"
};

laptop.GetProductDetails();
laptop.GetProductPrice();

box.AddProduct(mouse);
box.AddProduct(laptop);
box.AddProduct(Monitor);

box.GetProductDetails();
box.GetProductPrice();

Product keyboard = new Product()
{
    Name = "Keyboard",
    Price = 20.0m,
    Category = "Product"
};

Product headphones = new Product()
{
    Name = "Headphones",
    Price = 35.0m,
    Category = "Product"
};

ProductBox secondBox = new ProductBox()
{
    Name = "Second Box",
    Category = "Box"
};

secondBox.AddProduct(keyboard);
secondBox.AddProduct(headphones);

secondBox.GetProductDetails();
secondBox.GetProductPrice();

Console.ReadKey();