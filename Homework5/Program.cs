#region Bank Account
class BankAccount
{
    private readonly string _accountNumber;
    private double _balance;
    private readonly string _holderName;

    public string AccountNumber { get { return _accountNumber; } }
    public double Balance { get { return _balance; } }
    public string HolderName { get { return _holderName; } }

    public BankAccount(string accountNumber, double balance, string holderName)
    {
        if (string.IsNullOrEmpty(accountNumber))
            throw new Exception("Account number cannot be null or empty.");
        
        if (balance < 0)
            throw new Exception("Balance cannot be negative.");
        
        if (string.IsNullOrEmpty(holderName))
            throw new Exception("Holder name cannot be null or empty.");

        _accountNumber = accountNumber;
        _balance = balance;
        _holderName = holderName;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new Exception("Amount must be positive.");
        
        _balance += amount;
    }

    public void Draw(double amount)
    {
        if (amount <= 0)
            throw new Exception("Amount must be positive.");
        
        if (amount > _balance)
            throw new Exception("Cannot draw more than the available balance.");
        
        _balance -= amount;
    }

    public override string ToString()
    {
        return "Account Number: " + AccountNumber +
             "\nAccount Holder: " + HolderName +
             "\nAccount Balance: " + Balance;
    }

    public void PrintAccountInfo()
    {
        Console.WriteLine(this);
    }
}
#endregion

#region Rectangle
class Rectangle
{
    public double Height { get; private set; }
    public double Width { get; private set; }

    public Rectangle(double width, double height)
    {
        if (width < 0 || height < 0)
            throw new Exception("Invalid parameters");

        Width = width;
        Height = height;
    }
    public virtual double Area()
    {
        return  Height * Width;
    }

    public virtual double Perimeter()
    {
        return 2 * (Height + Width);
    }
}
class Square : Rectangle
{
    public Square(double side) : base(side, side) { }

    public override double Area()
    {
        return Height * Height;
    }

    public override double Perimeter()
    {
        return 4 * Height;
    }
}
class Trapezoid : Rectangle
{
    public double FirstSide { get; private set; }
    public double SecondSide { get; private set; }

    public Trapezoid(double height, double side1, double side2) : base(side1, height)
    {
        if (side2 < 0)
            throw new Exception("Invalid Parameters");
        
        FirstSide = side1;
        SecondSide = side2;
    }

    public override double Area()
    {
        return Height * (FirstSide + SecondSide) / 2;
    }

    public override double Perimeter()
    {
        return FirstSide + SecondSide + Height + Width;
    }
}
class Rhombus : Rectangle
{
    public double FirstDiagonal { get;set; }
    private double SecondDiagonal { get; set; }

    public Rhombus(double diag1, double diag2) : base(diag1, diag2)
    {
        if (diag1 < 0 || diag2 < 0)
            throw new Exception("Invalid Parameters");
        
        FirstDiagonal = diag1;
        SecondDiagonal = diag2;
    }

    public override double Area()
    {
        return FirstDiagonal * SecondDiagonal / 2;
    }

    public override double Perimeter()
    {
        return 4 * Height;
    }
}
class Parallelogram : Rectangle
{
    private double MainSide;

    public Parallelogram(double mainSide, double height) : base(mainSide, height)
    {
        MainSide = mainSide;
    }

    public override double Area()
    {
        return MainSide * Height;
    }

    public override double Perimeter()
    {
        return 2 * (MainSide + Height);
    }
}

#endregion

#region MathHelper
static class MathHelper
{
    public static readonly double PI;
    static MathHelper()
    {
        PI = 3.14;
    }
    public static double Sin(double x)
    {
        return Math.Sin(x);
    }

    public static double Cos(double x)
    {
        return Math.Cos(x);
    }

    public static double Tan(double x)
    {
        return Math.Tan(x);
    }
}
#endregion

#region Person
class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Address { get; private set; }

    public Person(string name, int age) : this()
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("Name cannot be null or empty.");
        
        if (age < 0)
            throw new Exception("Age must be positive");
        
        Name = name;
        Age = age;
    }

    private Person()
    {
        Address = "Address not defined";
    }

    public override string ToString()
    {
        return (string.IsNullOrEmpty(Address) ? Address : $"Address: {Address}") + $"\nName: {Name}" + $"\nAge: {Age}";
    }
    public void PrintPersonInfo()
    {
        Console.WriteLine(this);
    }
}
#endregion