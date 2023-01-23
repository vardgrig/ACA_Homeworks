Person[] person = new Person[]{
    new Person("Vardan", "Grigoryan", 22, Sex.Male),
    new Person("Robert", "Karapetyan", 17, Sex.Male),
    new Person("Maria", "Abayan", 20, Sex.Female),
    new Person("Arthur", "Yeganyan", 28, Sex.Male),
    new Person("Karen", "Knyazyan", 25, Sex.Male),
    new Person("Anahit", "Ter-Martirosyan", 33, Sex.Female)
};
//Console.WriteLine(Person.AverageAge(person));

////////////////////////////////////////////////////////////////////////////////////////////////////

Point p1 = new(1, 2, 3);
Point p2 = new(1, 0, 0);
Point p3 = new(4, -4, 3);
Point p4 = new(0, 2, -1);
Point p5 = p1 + p2;
Point p6 = p3 / p4;

//p5.PrintPoint();
//p6.PrintPoint();

struct Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public Sex Sex { get; set; }
    public Person(string firstName, string lastName, int age, Sex sex)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Sex = sex;
    }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = 0;
        Sex = Sex.Other;
    }
    public static implicit operator Employee(Person person)
    {
        return new Employee(person.FirstName, person.LastName);
    }

    public static float AverageAge(Person[] persons)
    {
        float sum = 0;
        foreach (var p in persons)
        {
            sum += p.Age;
        }
        return sum / persons.Length;
    }
}
struct Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Salary { get; set; }
    public Role Role { get; set; }
    public Employee(string firstName, string lastName, int salary, Role role)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        Role = role;
    }
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = 0;
        Role = Role.None;
    }
    public static implicit operator Person(Employee employee)
    {
        return new Person(employee.FirstName, employee.LastName);
    }
}

enum Role
{
    Programmer,
    Artist,
    Modeler,
    VFX_Artsit,
    None
}
enum Sex
{
    Male,
    Female,
    Other
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Point operator +(Point p1, Point p2)
    {
        return new(p1.X + p2.X, p1.Y + p2.Y, p1.Z + p2.Z);
    }
    public static Point operator *(Point p1, Point p2)
    {
        return new(p1.X * p2.X, p1.Y * p2.Y, p1.Z * p2.Z);
    }
    public static Point operator -(Point p1, Point p2)
    {
        return new(p1.X - p2.X, p1.Y - p2.Y, p1.Z - p2.Z);

    }
    public static Point operator /(Point p1, Point p2)
    {
        try
        {
            return new(p1.X / p2.X, p1.Y / p2.Y, p1.Z / p2.Z);
        }
        catch
        {
            throw new DivideByZeroException();
        }
    }
    public void PrintPoint()
    {
        Console.WriteLine($"x:{X} \t y:{Y} \t z:{Z}");
    }
}