using System;

struct Coordinate
{
    public int x { get; private set; }
    public int y { get; private set; }

    public Coordinate(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public float CalculateDistance(Coordinate second)
    {
        return Sqrt(Math.Pow(Math.Abs(this.x - second.x),2) + Math.Pow(Math.Abs(this.y - second.y), 2));
    }
}

struct Product
{
    public string name { get; private set; }
    public float price { get; private set; }

    public Product(string name, float price)
    {
        this.name = name;
        this.price = price;
    }
}

float CalculatePrices(Product[] products)
{
    float result;
    for(int i = 0; i < products.Length; ++i){
        result += products[i].price;
    }
    return result;
}

Coordinate A = new Coordinate(1,3);
Coordinate B = new Coordinate(4,7);
Console.WriteLine(A.CalculateDistance(B));

Product prod1 = new Product("apple", 500);
Product prod2 = new Product("orange", 1000);
Product prod3 = new Product("watermelon", 1200);

Product[] products = {prod1,prod2,prod3};
Console.WriteLine(CalculatePrices(products);


