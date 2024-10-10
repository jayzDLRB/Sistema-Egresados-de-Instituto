using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Ejucc_Proc_NivelesInformativos
{
    public class NivelesInformativos
    {
        public static string InsertarNivelInformativo(string nivelinformativo, string descrionnivelinformativo)
        {
            try
            {

                // Proceder con la inserción si las validaciones son correctas
                AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos nivelesinformativos = new AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos();

                Entidades.Niveles_Informativos.EntidadesNivelesInformativos objN = new Entidades.Niveles_Informativos.EntidadesNivelesInformativos();
                objN.NombreNivelInformativo = nivelinformativo;
                objN.DescripcionNivelInformativo = descrionnivelinformativo;

                return nivelesinformativos.ProcInsetarNivelesInformativos(objN);
            }
            catch (Exception ex)
            {
                return $"Error al insertar carrera: {ex.Message}";
            }
        }
        public static string ModificarNivelInformativo(int codigonivelinfromativo, string nivelinfromativo, string descrip)
        {
            try
            {

                AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos nivelesinformativos = new AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos();

                Entidades.Niveles_Informativos.EntidadesNivelesInformativos objN = new Entidades.Niveles_Informativos.EntidadesNivelesInformativos();
                objN.CodigoNivelInformativo = codigonivelinfromativo;
                objN.NombreNivelInformativo = nivelinfromativo;
                objN.DescripcionNivelInformativo = descrip;

                return nivelesinformativos.ProcModificarNivelesInformativos(objN);
            }
            catch (Exception ex)
            {
                return $"Error al insertar carrera: {ex.Message}";
            }
        }
        public static string EliminarNivelInformativo(int codigonivelinfromativo)
        {
            try
            {
                AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos nivelesinformativos = new AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos();
                Entidades.Niveles_Informativos.EntidadesNivelesInformativos objN = new Entidades.Niveles_Informativos.EntidadesNivelesInformativos();
                objN.CodigoNivelInformativo = codigonivelinfromativo;
                return nivelesinformativos.ProcEliminarNivelesInformativos(objN);
            }
            catch (Exception ex)
            {
                return $"Error al eliminar carrera: {ex.Message}";
            }
        }
        public static string ConsultarNivelInformativo(int codigocarrera, System.Windows.Forms.TextBox codigo, System.Windows.Forms.TextBox nomnvl, System.Windows.Forms.TextBox descip)
        {
            try
            {
                AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos nivelesinformativos = new AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos();
                Entidades.Niveles_Informativos.EntidadesNivelesInformativos objN = new Entidades.Niveles_Informativos.EntidadesNivelesInformativos();
                // Asignar el código de carrera
                objN.CodigoNivelInformativo = codigocarrera;

                return nivelesinformativos.ProcConsultarNivelesInformativos(objN, codigo, nomnvl, descip);
            }
            catch (Exception ex)
            {
                return $"Error al consultar carrera: {ex.Message}";
            }
        }
        public static DataTable ListaNivelInformativo()
        {
            try
            {
                AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos listanivelesinformativos = new AccesoDatos.Proc_NivelesInformativos.ProcedimientosNivelesInformativos();
                return listanivelesinformativos.ProcListartablaNivelesInformativos();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception($"Error al listar Carreras: {ex.Message}");
            }

        }
    }
}
