class Program
{
    struct Coordinate
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double CalculateDistance(Coordinate second)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(X - second.X), 2) + Math.Pow(Math.Abs(Y - second.Y), 2));
        }
    }

    struct Product
    {
        public string Name { get; private set; }
        public float Price { get; private set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }

    static double CalculatePrices(Product[] products)
    {
        double result = 0;
        for (int i = 0; i < products.Length; ++i)
        {
            result += products[i].Price;
        }
        return result;
    }
    static void Main(string[] args)
    {

        Coordinate A = new(1, 3);
        Coordinate B = new(4, 7);
        Console.WriteLine(A.CalculateDistance(B));

        Product prod1 = new("apple", 500);
        Product prod2 = new("orange", 1000);
        Product prod3 = new("watermelon", 1200);

        Product[] products = { prod1, prod2, prod3 };
        Console.WriteLine(CalculatePrices(products));
    }
}
