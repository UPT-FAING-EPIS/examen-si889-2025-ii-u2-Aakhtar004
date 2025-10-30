# AppSettings Application

Esta aplicación demuestra el uso del patrón Singleton en la clase AppSettings para manejar configuraciones de la aplicación.

## Información para Probar el Sistema

### Requisitos Previos
- .NET 8.0 SDK instalado.

### Ejecutar la Aplicación
1. Navega al directorio `src/AppSettingsProject`.
2. Ejecuta `dotnet run`.
   - Esto inicializará AppSettings con valores de producción y mostrará el resumen.
   - Luego cambiará a QA y mostrará el resumen actualizado.

### Ejecutar las Pruebas
1. Navega al directorio raíz del proyecto.
2. Ejecuta `dotnet test`.
   - Esto ejecutará las pruebas unitarias y verificará que el Singleton funcione correctamente.

### Generar Documentación
- La documentación se genera automáticamente en GitHub Actions y se publica en GitHub Pages.

### Reporte de Cobertura
- El reporte de cobertura se genera en releases y se publica en GitHub Pages bajo `/coverage`.