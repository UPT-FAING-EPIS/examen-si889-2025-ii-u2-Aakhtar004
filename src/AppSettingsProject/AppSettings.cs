public class AppSettings
{
    private static AppSettings _instance;
    private static readonly object _lock = new object();

    public string Environment { get; set; }
    public string ApiBaseUrl { get; set; }

    private AppSettings() { }

    public static AppSettings Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new AppSettings();
                    }
                }
            }
            return _instance;
        }
    }

    public void Initialize(string environment, string apiBaseUrl)
    {
        Environment = environment;
        ApiBaseUrl = apiBaseUrl;
    }

    public string GetSummary()
    {
        return $"Entorno: {Environment}, API: {ApiBaseUrl}";
    }
}