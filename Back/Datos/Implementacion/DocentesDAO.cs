using Back.Datos.Interfaz;
using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Back.Datos.Implementacion
{
    public class DocentesDAO:IDocentesDAO
    {
        public bool CrearDocente(Docente oDocente)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_INSERTAR_DOCENTE", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_docente", oDocente.IdDocente);
                comando.Parameters.AddWithValue("@nom_docente", oDocente.Nombre);
                comando.Parameters.AddWithValue("@ape_docente", oDocente.Apellido);
                comando.Parameters.AddWithValue("@direccion", oDocente.Direccion);
                comando.Parameters.AddWithValue("@altura", oDocente.Altura);
                comando.Parameters.AddWithValue("@nro_tel", oDocente.Telefono);
                comando.Parameters.AddWithValue("@email", oDocente.Email);
                comando.Parameters.AddWithValue("@titulo", oDocente.TituloDocente.IdTitulo);
                comando.Parameters.AddWithValue("@barrio", oDocente.Barrio.IdBarrio);
                comando.ExecuteNonQuery();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if(conexion!=null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
        public bool ActualizarDocente(Docente oDocente)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_ACTUALIZAR_DOCENTE", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_docente", oDocente.IdDocente);
                comando.Parameters.AddWithValue("@nom_docente", oDocente.Nombre);
                comando.Parameters.AddWithValue("@ape_docente", oDocente.Apellido);
                comando.Parameters.AddWithValue("@direccion", oDocente.Direccion);
                comando.Parameters.AddWithValue("@altura", oDocente.Altura);
                comando.Parameters.AddWithValue("@nro_tel", oDocente.Telefono);
                comando.Parameters.AddWithValue("@email", oDocente.Email);
                comando.Parameters.AddWithValue("@titulo", oDocente.TituloDocente.IdTitulo);
                comando.Parameters.AddWithValue("@barrio", oDocente.Barrio.IdBarrio);
                comando.ExecuteNonQuery();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
        public bool BorrarDocente(int nroDocente)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_BORRAR_DOCENTE", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_docente", nroDocente);
                comando.ExecuteNonQuery();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    aux = false;
                }
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return aux;
        }
        public List<Docente> TraerDocentes(List<Parametro> lParam)
        {
            List<Docente> lDocentes = new List<Docente>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DOCENTES", lParam);
            foreach(DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_docente"].ToString());
                string nom = fila["nom_docente"].ToString();
                string ape = fila["ape_docente"].ToString();
                string dir = fila["direccion"].ToString();
                int alt = int.Parse(fila["altura"].ToString());
                string tel = fila["nro_tel"].ToString();
                string mail = fila["email"].ToString();
                Docente oDocente = new Docente(id,new Titulo(),nom,ape,dir,alt,tel,mail,new Barrio());
                int idTit = int.Parse(fila["id_titulo"].ToString());
                string tit = fila["titulo"].ToString();
                Titulo auxTitulo = new Titulo(idTit, tit);
                oDocente.TituloDocente = auxTitulo;
                int idBar = int.Parse(fila["id_barrio"].ToString());
                string bar = fila["barrio"].ToString();
                Barrio auxBarrio = new Barrio(idBar,bar,new Ciudad());
                int idCiud = int.Parse(fila["id_ciudad"].ToString());
                string ciud = fila["ciudad"].ToString();
                Ciudad auxCiudad = new Ciudad(idCiud, ciud);
                auxBarrio.CiudadBarrio = auxCiudad;
                oDocente.Barrio = auxBarrio;
                lDocentes.Add(oDocente);
            }
            return lDocentes;
        }
        public Docente TraerDocente(int nroDocente)
        {
            Docente oDocente = new Docente();
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@docente", nroDocente));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DOCENTE", lParam);
            foreach (DataRow fila in tabla.Rows)
            {
                oDocente.IdDocente = int.Parse(fila["id_docente"].ToString());
                oDocente.Nombre = fila["nom_docente"].ToString();
                oDocente.Apellido = fila["ape_docente"].ToString();
                oDocente.Direccion = fila["direccion"].ToString();
                oDocente.Altura = int.Parse(fila["altura"].ToString());
                oDocente.Telefono = fila["nro_tel"].ToString();
                oDocente.Email = fila["email"].ToString();
                int idTit = int.Parse(fila["id_titulo"].ToString());
                string tit = fila["titulo"].ToString();
                Titulo auxTitulo = new Titulo(idTit, tit);
                oDocente.TituloDocente = auxTitulo;
                int idBar = int.Parse(fila["id_barrio"].ToString());
                string bar = fila["barrio"].ToString();
                Barrio auxBarrio = new Barrio(idBar, bar, new Ciudad());
                int idCiud = int.Parse(fila["id_ciudad"].ToString());
                string ciud = fila["ciudad"].ToString();
                Ciudad auxCiudad = new Ciudad(idCiud, ciud);
                auxBarrio.CiudadBarrio = auxCiudad;
                oDocente.Barrio = auxBarrio;
            }
            return oDocente;
        }
        public List<Titulo> TraerTitulos()
        {
            List<Titulo> lTitulos = new List<Titulo>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_TRAER_TITULOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int idTit = int.Parse(fila["id_titulo"].ToString());
                string tit = fila["titulo"].ToString();
                Titulo oTitulo = new Titulo(idTit,tit);
                lTitulos.Add(oTitulo);
            }
            return lTitulos;
        }
        public List<Barrio> TraerBarrios()
        {
            List<Barrio> lBarrios = new List<Barrio>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_TRAER_BARRIOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int idBar = int.Parse(fila["id_barrio"].ToString());
                string bar = fila["barrio"].ToString();
                Barrio oBarrio = new Barrio(idBar, bar, new Ciudad());
                int idCiud = int.Parse(fila["id_ciudad"].ToString());
                string ciud = fila["ciudad"].ToString();
                Ciudad oCiudad = new Ciudad(idCiud, ciud);
                oBarrio.CiudadBarrio = oCiudad;
                lBarrios.Add(oBarrio);
            }
            return lBarrios;
        }
    }
}
