using System;

class Program
{
    static void Main(string[] args)
    {
        AppSettings.Instance.Initialize("Producción", "https://api.miapp.com");
        Console.WriteLine(AppSettings.Instance.GetSummary());

        AppSettings.Instance.Environment = "QA";
        AppSettings.Instance.ApiBaseUrl = "https://qa.api.miapp.com";
        Console.WriteLine(AppSettings.Instance.GetSummary());
    }
}