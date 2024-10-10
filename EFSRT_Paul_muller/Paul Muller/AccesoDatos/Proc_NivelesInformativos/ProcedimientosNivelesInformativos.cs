using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos.Proc_NivelesInformativos
{
    public class ProcedimientosNivelesInformativos
    {
        Conectar.Conexion conn = Conectar.Conexion.CrearInstancia();
        public string ProcInsetarNivelesInformativos(Entidades.Niveles_Informativos.EntidadesNivelesInformativos obj)
        {
            string rpt = "";
            SqlConnection sqlConn = null;

            try
            {
                // Validar que los campos no estén vacíos o contengan solo espacios
                if (string.IsNullOrWhiteSpace(obj.NombreNivelInformativo) || string.IsNullOrWhiteSpace(obj.DescripcionNivelInformativo))
                {
                    MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACÍOS O CONTENER SOLO ESPACIOS EN BLANCO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "Intente nueevamente";
                }

                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando de inserción
                SqlCommand insert = new SqlCommand("dbo.insertarnivelesinformativos", sqlConn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@Nombre", obj.NombreNivelInformativo.Trim()); // Eliminar espacios en blanco
                insert.Parameters.AddWithValue("@Descripcion", obj.DescripcionNivelInformativo.Trim()); // Eliminar espacios en blanco

                // Ejecutar el comando
                int datosinsertados = insert.ExecuteNonQuery();
                rpt = datosinsertados > 0 ? "LA CARRERA SE INSERTO CON EXITO" : "NO SE PUDO INSERTAR LA CARRERA";
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
        public string ProcModificarNivelesInformativos(Entidades.Niveles_Informativos.EntidadesNivelesInformativos obj)
        {
            if (obj.CodigoNivelInformativo <= 0)
            {
                return "SELECIONE UN CODIGO PARA PODER MODIFICAR";
            }

            // Verificar que los campos string no sean solo espacios en blanco
            if (string.IsNullOrWhiteSpace(obj.NombreNivelInformativo) || string.IsNullOrWhiteSpace(obj.DescripcionNivelInformativo))
            {
                return "LOS CAMPOS NO PUEDEN ESTAR VACÍOS O CONTENER SOLO ESPACIOS EN BLANCO";
            }
            string rpt = "";
            SqlConnection sqlConn = null;

            try
            {
                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando de modificación
                SqlCommand update = new SqlCommand("dbo.modificarnivelesinformativos", sqlConn);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("@CodigoNivelInformativo", obj.CodigoNivelInformativo); // ID de la carrera a modificar
                update.Parameters.AddWithValue("@Nombre", obj.NombreNivelInformativo);
                update.Parameters.AddWithValue("@Descripcion", obj.DescripcionNivelInformativo);

                // Ejecutar el comando
                int filasAfectadas = update.ExecuteNonQuery();
                rpt = filasAfectadas > 0 ? "LA CARRERA SE MODIFICÓ CON ÉXITO" : "NO SE PUDO MODIFICAR LA CARRERA";
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
        public string ProcEliminarNivelesInformativos(Entidades.Niveles_Informativos.EntidadesNivelesInformativos obj)
        {
            if (obj.CodigoNivelInformativo <= 0)
            {
                return "SELECIONE UN CODIGO PARA PODER MODIFICAR";
            }

            string rpt = "";
            SqlConnection sqlConn = null;

            try
            {
                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando de eliminación
                SqlCommand delete = new SqlCommand("dbo.eliminarnivelesinformativos", sqlConn);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("@CodigoNivelInformativo", obj.CodigoNivelInformativo); // ID de la carrera a eliminar

                // Ejecutar el comando
                int filasAfectadas = delete.ExecuteNonQuery();
                rpt = filasAfectadas > 0 ? "LA CARRERA SE ELIMINÓ CON ÉXITO" : "NO SE PUDO ELIMINAR LA CARRERA";
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
        public string ProcConsultarNivelesInformativos(Entidades.Niveles_Informativos.EntidadesNivelesInformativos obj, TextBox txtcodigo, TextBox txtnom, TextBox txtdescr)
        {
            string rpt = "";
            SqlConnection sqlConn = null;
            try
            {
                sqlConn = conn.CrearConexion();
                sqlConn.Open();

                SqlCommand consult = new SqlCommand("dbo.consultarnivelesinformativos", sqlConn);
                consult.CommandType = CommandType.StoredProcedure;
                consult.Parameters.AddWithValue("@CodigoNivelInformativo", obj.CodigoNivelInformativo);
                using (SqlDataReader rdr = consult.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        txtcodigo.Text = rdr["CodigoNivelInformativo"].ToString();
                        txtnom.Text = rdr["Nombre"].ToString();
                        txtdescr.Text = rdr["Descripcion"].ToString();
                    }
                }
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
        public DataTable ProcListartablaNivelesInformativos()
        {
            SqlConnection sqlConn = null;
            DataTable dt = new DataTable();

            try
            {
                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando para ejecutar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("dbo.verificarnivelesinformativos", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Crear el SqlDataAdapter y llenar el DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Puedes manejar el error de manera adecuada según tu lógica
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }

            // Retornar la tabla con los datos
            return dt;
        }
    }
}
