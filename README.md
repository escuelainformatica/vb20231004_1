# vb20231004_1
Tome los archivos de la base de datos, y arrastrelos y sueltelos en el explorador de solución

## Para instalar las herramientas para conectarme a la base de datos

Ejecutar esto en la consola de administracion de paquetes (Herramientas -> admin paquetes nuget -> consola)

```shell
NuGet\Install-Package EntityFrameworkCore.VisualBasic -Version 7.0.0
NuGet\Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 7.0.11
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 7.0.11
```

Una vez que esta instalada, agregar la conexion a la base de datos

## Conexion
Para crear la conexion, haga doble click en el archivo .mdf.  Esta accion deberia instalar la conexion que puede verse en la ventana de Explorador de Sercvidores.

Una vez que la conexion esta lista, seleccione la conexion y vea las propiedades
Luego, copie la cadena de conexion.
"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\cursovb2023\WinFormsApp3\WinFormsApp3\base2012.mdf;Integrated Security=True"

En la consola de administracion de paquetes: (cambie lo que esta en asterisco por su cadena de conexion.
```shell
Scaffold-DbContext "****" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
```
