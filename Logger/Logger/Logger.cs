namespace LoggerSingleton;

public enum LogLevel
{
    INFO,
    DEBUG,
    ERROR
}


public class Logger
{
    private static Logger _instance = null;
    private static object _padlock = new object();

    private readonly List<string> _logEntries;
    private LogLevel _currentLogLevel;

    private Logger()
    {
        _logEntries = new List<string>();
        _currentLogLevel = LogLevel.INFO;
    }

    public static Logger Instance
    {
        get
        {
            lock (_padlock)
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }
    }

    public void SetLogLevel(LogLevel loglevel)
    {
        _currentLogLevel = loglevel;
    }

    public void Log(string message, LogLevel messageLogLevel)
    {
        if (messageLogLevel >= _currentLogLevel)
            lock (_padlock)
            {
                string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{messageLogLevel}] {message}";
                _logEntries.Add(logEntry);
                Console.WriteLine(logEntry);
            }

    }

    public List<string> GetLogEntries()
    {
        return _logEntries;
    }
}

