using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesoDatos.Proc_CarreraProfesional
{
    public class ProcedemientosCarrerasProfesionales
    {
        Conectar.Conexion conn = Conectar.Conexion.CrearInstancia();
        public string ProcInsetarCarrera(Entidades.Carreras_Cursos.EntidadesCarreras obj)
        {
            string rpt = "";
            SqlConnection sqlConn = null;

            try
            {
                // Validar que los campos no estén vacíos o contengan solo espacios
                if (string.IsNullOrWhiteSpace(obj.NombreCarrera) || string.IsNullOrWhiteSpace(obj.Descripcion))
                {
                    MessageBox.Show("LOS CAMPOS NO PUEDEN ESTAR VACÍOS O CONTENER SOLO ESPACIOS EN BLANCO.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return "Intente nueevamente";
                }

                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando de inserción
                SqlCommand insert = new SqlCommand("dbo.insertarcarreras", sqlConn);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@NombreCarrera", obj.NombreCarrera.Trim()); // Eliminar espacios en blanco
                insert.Parameters.AddWithValue("@DescripcionCarrera", obj.Descripcion.Trim()); // Eliminar espacios en blanco

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
        public string ProcModificarCarrera(Entidades.Carreras_Cursos.EntidadesCarreras obj)
        {
            if (obj.CodigoCarrera <= 0)
            {
                return "SELECIONE UN CODIGO PARA PODER MODIFICAR";
            }

            // Verificar que los campos string no sean solo espacios en blanco
            if (string.IsNullOrWhiteSpace(obj.NombreCarrera) || string.IsNullOrWhiteSpace(obj.Descripcion))
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
                SqlCommand update = new SqlCommand("dbo.modificarcarreras", sqlConn);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("@CodigoCarreraProfesional", obj.CodigoCarrera); // ID de la carrera a modificar
                update.Parameters.AddWithValue("@NombreCarrera", obj.NombreCarrera);
                update.Parameters.AddWithValue("@DescripcionCarrera", obj.Descripcion);

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
        public string ProcEliminarCarrera(Entidades.Carreras_Cursos.EntidadesCarreras obj)
        {
            if (obj.CodigoCarrera <= 0)
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
                SqlCommand delete = new SqlCommand("dbo.eliminarcarreras", sqlConn);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("@CodigoCarreraProfesional", obj.CodigoCarrera); // ID de la carrera a eliminar

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
        public string ProcConsultarCarrera(Entidades.Carreras_Cursos.EntidadesCarreras obj, TextBox txtcodigo ,TextBox txtnom, TextBox txtdescr) 
        {
            string rpt = "";
            SqlConnection sqlConn = null;
            try {
                sqlConn = conn.CrearConexion();
                sqlConn.Open();

                SqlCommand consult = new SqlCommand("dbo.consularcarrera", sqlConn);
                consult.CommandType = CommandType.StoredProcedure;
                consult.Parameters.AddWithValue("@CodigoCarreraProfesional", obj.CodigoCarrera);
                using (SqlDataReader rdr = consult.ExecuteReader()) 
                {
                    while (rdr.Read()) 
                    {
                        txtcodigo.Text = rdr["CodigoCarreraProfesional"].ToString();
                        txtnom.Text = rdr["NombreCarrera"].ToString();
                        txtdescr.Text = rdr["DescripcionCarrera"].ToString();
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
        public DataTable ProcListartablaCarrreras()
        {
            SqlConnection sqlConn = null;
            DataTable dt = new DataTable();

            try
            {
                // Crear la conexión
                sqlConn = conn.CrearConexion();
                sqlConn.Open(); // Abrir la conexión

                // Preparar el comando para ejecutar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("dbo.verificarcarreras", sqlConn);
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
