delegate int MathOperation(int x, int y);
delegate void MultiplyMethods();
class Program
{
    static void Main(string[] args)
    {
        #region Homework1
        MathOperation add = (a, b) => a + b;
        MathOperation subtract = (a, b) => a - b;
        MathOperation multiply = (a, b) => a * b;

        Console.WriteLine(add(3, 4));        // Output: 7
        Console.WriteLine(subtract(3, 4));   // Output: -1
        Console.WriteLine(multiply(3, 4));   // Output: 12
        #endregion

        #region Homework2
        static void Method1()
        {
            Console.WriteLine("First Method");
        }

        static void Method2()
        {
            Console.WriteLine("Second Method");
        }
        static void Method3()
        {
            Console.WriteLine("Third Mehtod");
        }

        MultiplyMethods multiplyMethods = Method1;
        multiplyMethods += Method2;
        multiplyMethods += Method3;
        multiplyMethods();
        multiplyMethods -= Method2;
        multiplyMethods();
        #endregion
    }
}