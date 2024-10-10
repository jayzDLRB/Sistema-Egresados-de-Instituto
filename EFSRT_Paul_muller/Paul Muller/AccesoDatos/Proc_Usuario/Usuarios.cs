using AccesoDatos.Proc_Usuario.ElementosRecuperacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.Usuario
{
    public class Usuarios
    {
        Conectar.Conexion conn = Conectar.Conexion.CrearInstancia();

        public string ProcInsertarUsuarios(Entidades.Usuarios.EntidadesUsuarios obj)
        {
            string rpt = "";
            SqlConnection sqlConn = null;

            try
            {
                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando de inserción
                SqlCommand insert = new SqlCommand("dbo.insertarusuario", sqlConn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                insert.Parameters.AddWithValue("@Contrasena", obj.Contrasena);
                insert.Parameters.AddWithValue("@CorreoElectronico", obj.CorreoElectronico);

                // Ejecutar el comando
                int datosinsertados = insert.ExecuteNonQuery();
                rpt = datosinsertados > 0 ? "NO SE PUDO INSERTAR EL USUARIO" : "USUARIO SE INSERTO CON EXITO";
            }
            catch (Exception ex)
            {
                rpt = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            return rpt;
        }
        public bool ProcValidarUsuarios(Entidades.Usuarios.EntidadesUsuarios obj)
        {
            bool rpt = false;
            SqlConnection sqlConn = null;

            try
            {
                sqlConn = conn.CrearConexion();
                sqlConn.Open();

                SqlCommand validar = new SqlCommand("dbo.sp_ValidarUsuario", sqlConn);
                validar.CommandType = CommandType.StoredProcedure;

                // Agregar los parámetros correctamente
                validar.Parameters.AddWithValue("@NombreUsuario", obj.NombreUsuario);
                validar.Parameters.AddWithValue("@Contrasena", obj.Contrasena); // Cambia aquí

                int rest = (int)validar.ExecuteScalar();

                // Si el resultado es 1, el usuario y contraseña son válidos
                rpt = (rest == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar el usuario: " + ex.Message);
            }
            finally
            {
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            return rpt;
        }
    }
}
