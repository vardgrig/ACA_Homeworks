double Result4(int x)
{
    return Math.Log(Math.Exp(x) + 1) + Math.Pow(Math.Pow(x, 2) + 4, 1f/3f);
}
double Result8(int x, int y)
{
    return Math.Pow(Math.Pow(x, 2) + Math.Pow(Math.Pow(y, 2) + 4, 1f / 3f), 1f / 4f) + Math.Pow(Math.Abs(x) + Math.Abs(y), 10);
}
double Result11(int a, int b, int x)
{
    if (Math.Pow(a, 2) + Math.Pow(b, 2) > 5)
        return 3 * Math.Exp(a - x) + Math.Log(Math.Pow(a, 2) + Math.Pow(b, 2) + 5, 3);
    else if (Math.Pow(a, 2) + Math.Pow(b, 2) < 1)
        return Math.Pow(Math.Tan(a + b), 4);
    return -3;
}
double Result12(int a, int x)
{
    if (x >= -5 && x <= 5)
        return Math.Pow(1 + Math.Pow(a, 2), 6);
    else if (x > 5)
        return Math.Cos(Math.Pow(Math.Log10(Math.Abs(x)), 2) + Math.Pow(x, 8));
    return a;
}
void Result74()
{
    for(float x = -3.8f; x <= 5.4f; x += 0.3f)
    {
        Console.WriteLine(Math.Pow(2, x + 4));
    }
}
void Result77()
{
    for(int x = -8; x <=8; x += 3)
    {
        if (x > 3)
            Console.WriteLine(Math.Pow(x, 2) + 4 * Math.Pow(x, 8));
        else
            Console.WriteLine(0);
    }
}
double Result111(int x, int n)
{
    double result = 0;
    for( int i = 0; i <= n; ++i)
    {
        result += Math.Pow(x, 4 * i + 1) / (4 * i + 1);
    }
    return result;
}
double Result118(int x, int n)
{
    double result = 0;
    for(int i = 0; i <= n; ++i)
    {
        result += Math.Pow(Math.Abs(2 * x + i), i) / ((i + 1) * (i + 2));
    }
    return result;
}

void Problem4()
{
    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result4(x));
}
void Problem8()
{
    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result8(x,y));
}
void Problem11()
{
    Console.WriteLine("Insert a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result11(a, b, x));
}
void Problem12()
{
    Console.WriteLine("Insert a: ");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result12(a, x));
}
void Problem111()
{
    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert positive n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result111(x, n));
}
void Problem118()
{
    Console.WriteLine("Insert x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert positive n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Result118(x, n));
}

//Problem4();
//Problem8();
//Problem11();
//Problem12();
//Result74();
//Result77();
//Problem111();
//Problem118();


