namespace Singleton;

public static class MySingleton
{

    public static string instance;
    public static string instance2;
    //public static string Instance3 { get; set; } = "Instance" + GetRandomNumber(3);

    private static readonly object _lockObj = new object();

    private static string? _instance
    {
        get;
        set;
    }

    static MySingleton()
    {
        instance = "Instance " + GetRandomNumber(1);
        instance2 = "Instance 2" + GetRandomNumber(2);
    }//static helper method generating random number from 0 to 1000


    public static string? Instance
    {
        get
        {
            if (_instance == null)
                lock (_lockObj)
                {
                    Console.WriteLine("Lock was unlocked");
                    if (_instance == null)
                    {
                        Console.WriteLine("MySingleton contstructor called");
                        _instance = "Instance" + GetRandomNumber(3);
                    }

                }

            return _instance;
        }
    }
    public static int GetRandomNumber(int num)
    {
        lock (_lockObj) // Adding lock for thread safety
        {
            Random random = new();
            int randomNumber = random.Next(0, 1000);
            Console.WriteLine($"Instance {num} is " + randomNumber);
            return randomNumber;
        }
    }
}


public class MySingleton2
{
    public object? Instance { get; set; }
    public static object? Instance2 { get; set; }
}