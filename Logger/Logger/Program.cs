// See https://aka.ms/new-console-template for more information
using LoggerSingleton;

Console.WriteLine("Hello, World!");


Logger logger = Logger.Instance;

// Set log level (optional)
logger.SetLogLevel(LogLevel.DEBUG);

// Create multiple threads and log messages
Thread thread1 = new Thread(() => LogMessages(logger, "Thread 1", 5, LogLevel.INFO));
Thread thread2 = new Thread(() => LogMessages(logger, "Thread 2", 5, LogLevel.DEBUG));

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

// Print all log entries
Console.WriteLine("\nAll Log Entries:");
foreach (string entry in logger.GetLogEntries())
{
    Console.WriteLine(entry);
}


static void LogMessages(Logger logger, string threadName, int count, LogLevel logLevel)
{
    for (int i = 1; i <= count; i++)
    {
        logger.Log($"{threadName} - Log Message {i}", logLevel);
        Thread.Sleep(100);
    }
}
