using NUnit.Framework.Internal;
using LoggerSingleton;
namespace LoggerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestLogMessages()
        {
            LoggerSingleton.Logger logger = LoggerSingleton.Logger.Instance;

            // Log some messages
            logger.Log("Test Message 1", LogLevel.INFO);
            logger.Log("Test Message 2", LogLevel.DEBUG);
            logger.Log("Test Message 3", LogLevel.ERROR);

            // Get log entries and assert
            var logEntries = logger.GetLogEntries();

            Assert.AreEqual(3, logEntries.Count);
            Assert.IsTrue(logEntries[0].Contains("Test Message 1"));
            Assert.IsTrue(logEntries[1].Contains("Test Message 2"));
            Assert.IsTrue(logEntries[2].Contains("Test Message 3"));
        }

        [Test]
        public void TestThreadSafety()
        {
            LoggerSingleton.Logger logger = LoggerSingleton.Logger.Instance;

            // Number of threads and log entries per thread
            int threadCount = 10;
            int entriesPerThread = 100;

            // Create and start threads
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < threadCount; i++)
            {
                int threadNumber = i;
                Thread thread = new Thread(() => LogMessages(logger, $"Thread {threadNumber}", entriesPerThread));
                threads.Add(thread);
                thread.Start();
            }

            // Wait for all threads to finish
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            // Get log entries and assert
            var logEntries = logger.GetLogEntries();

            // Assert the total number of log entries
            Assert.AreEqual(threadCount * entriesPerThread, logEntries.Count);

            // Assert the presence of log messages from each thread
            for (int i = 0; i < threadCount; i++)
            {
                Assert.IsTrue(logEntries.Any(entry => entry.Contains($"Thread {i}")));
            }
        }

        static void LogMessages(LoggerSingleton.Logger logger, string threadName, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                LogLevel logLevel = (LogLevel)(i % Enum.GetValues(typeof(LogLevel)).Length);
                logger.Log($"{threadName} - Log Message {i}", logLevel);
                Thread.Sleep(10); // Simulate some work between log entries
            }
        }
    }
}