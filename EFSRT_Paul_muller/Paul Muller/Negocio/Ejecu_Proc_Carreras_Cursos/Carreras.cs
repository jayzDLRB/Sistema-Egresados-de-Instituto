using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Negocio.Ejecu_Proc_Carreras_Cursos
{
    public class Carreras
    {
        public static string InsertarCarreras(string carrera, string descrip)
        {
            try
            {
               
                // Proceder con la inserción si las validaciones son correctas
                AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales carreras = new AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales();

                Entidades.Carreras_Cursos.EntidadesCarreras objC = new Entidades.Carreras_Cursos.EntidadesCarreras();
                objC.NombreCarrera = carrera;
                objC.Descripcion = descrip;

                return carreras.ProcInsetarCarrera(objC);
            }
            catch (Exception ex)
            {
                return $"Error al insertar carrera: {ex.Message}";
            }
        }
        public static string ModificarCarreras(int codigocarerra, string carrera, string descrip) 
        {
            try
            {

                // Proceder con la inserción si las validaciones son correctas
                AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales carreras = new AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales();

                Entidades.Carreras_Cursos.EntidadesCarreras objC = new Entidades.Carreras_Cursos.EntidadesCarreras();
                objC.CodigoCarrera = codigocarerra;
                objC.NombreCarrera = carrera;
                objC.Descripcion = descrip;

                return carreras.ProcModificarCarrera(objC);
            }
            catch (Exception ex)
            {
                return $"Error al insertar carrera: {ex.Message}";
            }
        }
        public static string EliminarCarreras(int codigo) 
        {
            try {
                AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales carreras = new AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales();
                Entidades.Carreras_Cursos.EntidadesCarreras objC = new Entidades.Carreras_Cursos.EntidadesCarreras();
                objC.CodigoCarrera= codigo;
                return carreras.ProcEliminarCarrera(objC);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar carrera: {ex.Message}";
            }
        }
        public static string ConsultarCarreras(int codigocarrera, System.Windows.Forms.TextBox codigo, System.Windows.Forms.TextBox nomcar, System.Windows.Forms.TextBox descip)
        {
            try
            {
                AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales carreras = new AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales();
                Entidades.Carreras_Cursos.EntidadesCarreras objCC = new Entidades.Carreras_Cursos.EntidadesCarreras();

                // Asignar el código de carrera
                objCC.CodigoCarrera = codigocarrera;

                return carreras.ProcConsultarCarrera(objCC,codigo,nomcar, descip);
            }
            catch (Exception ex)
            {
                return $"Error al consultar carrera: {ex.Message}";
            }
        }
        public static DataTable ListaCarrera() 
        {
            try
            {
                AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales listacarrea = new AccesoDatos.Proc_CarreraProfesional.ProcedemientosCarrerasProfesionales();
                return listacarrea.ProcListartablaCarrreras();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception($"Error al listar Carreras: {ex.Message}");
            }

        }

    }
}
