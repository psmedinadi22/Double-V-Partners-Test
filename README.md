# Prueba técnica Double V Partners

A continuación se puede vizualizar paso a paso el proceso realizado:

### 1. Crear el proyecto en ASP.NET Core:
- Abre Visual Studio y crea un nuevo proyecto ASP.NET Core Web Application.
- Selecciona el tipo "API" y nombra tu proyecto.

### 2. Configurar la base de datos:
- Utiliza Entity Framework Core para trabajar con la base de datos.
- Crea tus entidades `Persona` y `Usuario` como clases en tu proyecto.
- Define las propiedades de estas entidades según los atributos que mencionaste.

```csharp
public class Persona
{
    public int Id { get; set; }
    public string Nombres { get; set; }
    public string Apellidos { get; set; }
    // Otros atributos aquí
}

public class Usuario
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    // Otros atributos aquí
}
```

### 3. Configurar Entity Framework Core:
- Configura tu DbContext para interactuar con la base de datos.

```csharp
public class ApplicationDbContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    // Configuración y métodos aquí
}
```

### 4. Crear migraciones y aplicarlas a la base de datos:
- Abre la consola del Administrador de paquetes (PMC) o la terminal.
- Ejecuta los comandos de migración para crear la base de datos.

### 5. Crear controladores para las entidades:
- Crea controladores API para las entidades `Persona` y `Usuario`.
- Define acciones para realizar operaciones CRUD (crear, leer, actualizar, eliminar).

### 6. Implementar endpoints para las operaciones necesarias:
- Define endpoints para insertar datos de `Persona` y `Usuario`.
- Crea endpoints para validar el inicio de sesión (`login`) del usuario.

### 7. Implementar la lógica de negocio:
- En el controlador de `Usuario`, implementa la lógica para verificar el inicio de sesión.

### 8. Probar la API:
- Utiliza herramientas como Postman para probar los endpoints y asegurarte de que funcionen correctamente.
- Verifica la inserción de datos y la validación de inicio de sesión.

# Video


[test.webm](https://github.com/psmedinadi22/Double-V-Partners-Test/assets/64180738/63d828d8-9a77-4ce5-8da7-976098879b97)

