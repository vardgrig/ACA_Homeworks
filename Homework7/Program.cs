
#region News class and event delegate

StartNews();
void StartNews()
{
    News news = new News();
    news.Subscribe(HandleBreakingNews);
    news.PresentNews("Breaking News: The Global Game Jam has just started!");

    void HandleBreakingNews(string message)
    {
        Console.WriteLine(message);
    }
}

public delegate void BreakingNewsEventHandler(string message);
public class News
{
    private event BreakingNewsEventHandler BreakingNews;

    private BreakingNewsEventHandler[] subscribers = new BreakingNewsEventHandler[10];
    private int subCount = 0;

    public void Subscribe(BreakingNewsEventHandler subscriber)
    {
        BreakingNews += subscriber;
        subscribers[subCount++] = subscriber;
        Console.WriteLine("Number of subscribers: " + subCount);
    }

    public void PresentNews(string message)
    {
        foreach(var subscriber in subscribers)
        {
            subscriber(message);
        }
    }
}

#endregion
#region OutOfRangeException
////MyMethod();
//void MyMethod()
//{
//    int[] array = new int[]
//    {
//        1,2,3,4,5
//    };

//    foreach (int number in array)
//    {
//        Console.WriteLine(number);
//    }

//    Random r = new Random();
//    for (int i = 0; i < 9; ++i)
//    {
//        int j = r.Next(0, 10);
//        try
//        {
//            Console.WriteLine(array[j]);
//        }
//        catch (IndexOutOfRangeException)
//        {
//            Console.WriteLine("Index of element out of bounds. Index must be smaller than Array.Length");
//            Console.WriteLine($"Array Length is: {array.Length}");
//            Console.WriteLine($"Index is: {j}");
//        }
//    }
//}
#endregion
#region Custom Exception handling
////Input();

//void Input()
//{
//    try
//    {
//        Console.Write("Your Name: ");
//        string name = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(name))
//            throw new WrongNameException();

//        Console.Write("Your Surname: ");
//        string surname = Console.ReadLine();

//        if (string.IsNullOrWhiteSpace(surname))
//            throw new WrongNameException();

//        Console.Write("Your Age: ");
//        int age = int.Parse(Console.ReadLine());

//        if (age < 0 || age > 120)
//            throw new WrongAgeExecption();

//        Console.WriteLine($"Hello {name} {surname}, you're {age} years old!");
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine(e);
//    }

//}
//class WrongAgeExecption : Exception
//{
//    public override string Message => "You must input your real age (from 1-120)...";
//}
//class WrongNameException : Exception
//{
//    public override string Message => "Invalid characters in your name";
//}
#endregion
