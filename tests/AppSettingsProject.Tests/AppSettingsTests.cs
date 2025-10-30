using Xunit;

public class AppSettingsTests
{
    [Fact]
    public void CrearConfiguracion_DeberiaRetornarResumenCorrecto()
    {
        AppSettings.Instance.Initialize("Producción", "https://api.miapp.com");

        var resumen = AppSettings.Instance.GetSummary();

        Assert.Equal("Entorno: Producción, API: https://api.miapp.com", resumen);
    }

    [Fact]
    public void CambiarConfiguracion_DeberiaActualizarValores()
    {
        AppSettings.Instance.Initialize("Desarrollo", "http://localhost:5000");
        AppSettings.Instance.Environment = "QA";
        AppSettings.Instance.ApiBaseUrl = "https://qa.api.miapp.com";

        var resumen = AppSettings.Instance.GetSummary();

        Assert.Equal("Entorno: QA, API: https://qa.api.miapp.com", resumen);
    }
}