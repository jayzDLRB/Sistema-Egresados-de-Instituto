using System;
using System.Data.SqlClient;

namespace AccesoDatos.Conectar
{
  public class Conexion
  {
    // Declaramos las variables privadas de esta clase
    private string Base;
    private string Servidor;
    private string Usuario;
    private string Contrasena;
    private bool Seguridad; // Permite establecer el método de autenticación para conectar a SQLServer
    private static Conexion conn = null; // Crear un objeto de tipo de conexión para compartir

    // Constructor privado (patrón Singleton)
    private Conexion()
    {
      this.Base = "EGRESADOS";
      this.Servidor = ".";
      this.Usuario = "Conectar";
      this.Contrasena = "12345";
      this.Seguridad = true; // Cambiar a false si se usa autenticación SQL
    }

    // Método público para devolver el string de conexión
    public SqlConnection CrearConexion()
    {
      SqlConnection cdn = new SqlConnection();
      try
      {
        // Crear la cadena de conexión
        string connectionString = $"Server={this.Servidor};Database={this.Base};";

        // Validar el tipo de seguridad utilizado en la conexión
        if (this.Seguridad)
        {
          connectionString += "Integrated Security=SSPI;";
        }
        else
        {
          connectionString += $"User Id={this.Usuario};Password={this.Contrasena};";
        }

        cdn.ConnectionString = connectionString;
      }
      catch (Exception ex)
      {
        cdn = null;
        throw new Exception("Error al crear la cadena de conexión: " + ex.Message);
      }
      return cdn;
    }

    // Método para generar una instancia única (Singleton)
    public static Conexion CrearInstancia()
    {
      if (conn == null)
      {
        conn = new Conexion();
      }
      return conn;
    }
  }
}
