using Back.Datos.Interfaz;
using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Implementacion
{
    public class ExamenesDAO:IExamenesDAO
    {
        public int ObtenerProximoExamen()
        {
            int aux = HelperDAO.ObtenerInstancia().ObtenerEscalar("PA_OBTENER_PROX_EXAMEN", "@prox");
            return aux;
        }
        public bool ConfirmarExamen(Examen oExamen)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_INSERTAR_EXAMEN", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@proxExamen", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                comando.Parameters.Add(param);
                comando.Parameters.AddWithValue("@fecha",oExamen.FechaExamen);
                comando.Parameters.AddWithValue("@id_materia", oExamen.MateriaExamen.IdMateria);
                comando.Parameters.AddWithValue("@id_docente", oExamen.DocenteExamen.IdDocente);
                comando.ExecuteNonQuery();
                int auxParam = (int)param.Value;
                foreach (DetalleAlumnoExamen det in oExamen.DetallesExamen)
                {
                    SqlCommand comandoDet = new SqlCommand("PA_INSERTAR_DETALLE_EXAMEN", conexion, transaccion);
                    comandoDet.CommandType = CommandType.StoredProcedure;
                    comandoDet.Parameters.AddWithValue("@id_examen",auxParam);
                    comandoDet.Parameters.AddWithValue("@id_alumno",det.AlumnoDetalle.IdAlumno);
                    comandoDet.Parameters.AddWithValue("@nota",det.NotaDetalle);
                    //Programar trigger del estado academico
                    comandoDet.ExecuteNonQuery();
                }

                transaccion.Commit();
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
        public bool ActualizarExamen(Examen oExamen)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_ACTUALIZAR_EXAMEN", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_examen", oExamen.IdExamen);
                comando.Parameters.AddWithValue("@fecha", oExamen.FechaExamen);
                comando.Parameters.AddWithValue("@id_materia", oExamen.MateriaExamen.IdMateria);
                comando.Parameters.AddWithValue("@id_docente", oExamen.DocenteExamen.IdDocente);
                comando.ExecuteNonQuery();
                foreach (DetalleAlumnoExamen det in oExamen.DetallesExamen)
                {
                    SqlCommand comandoDet = new SqlCommand("PA_INSERTAR_DETALLE_EXAMEN", conexion, transaccion);
                    comandoDet.CommandType = CommandType.StoredProcedure;
                    comandoDet.Parameters.AddWithValue("@id_examen", oExamen.IdExamen);
                    comandoDet.Parameters.AddWithValue("@id_alumno", det.AlumnoDetalle.IdAlumno);
                    comandoDet.Parameters.AddWithValue("@nota", det.NotaDetalle);
                    //Programar trigger del estado academico
                    comandoDet.ExecuteNonQuery();
                }
                transaccion.Commit();
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
        public bool BorrarExamen(int nroExamen)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_BORRAR_EXAMEN", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_examen", nroExamen);
                comando.ExecuteNonQuery();
                transaccion.Commit();
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
        public Examen TraerExamen(int nroExamen)
        {
            Examen oExamen = new Examen();
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@id_examen",nroExamen));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_EXAMEN", lParam);
            foreach(DataRow fila in tabla.Rows)
            {
                oExamen.IdExamen = nroExamen;
                oExamen.FechaExamen = DateTime.Parse(fila["fecha_examen"].ToString());
                oExamen.DocenteExamen.IdDocente = int.Parse(fila["id_docente"].ToString());
                oExamen.DocenteExamen.Nombre = fila["nom_docente"].ToString();
                oExamen.DocenteExamen.Apellido = fila["ape_docente"].ToString();
                oExamen.MateriaExamen.IdMateria = int.Parse(fila["id_materia"].ToString());
                oExamen.MateriaExamen.NombreMateria = fila["nom_materia"].ToString();
            }
            DataTable tablaDet = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DETALLES_EXAMEN", lParam);
            foreach(DataRow filaDet in tablaDet.Rows)
            {
                DetalleAlumnoExamen det = new DetalleAlumnoExamen();
                det.IdDetalleAlumnoExamen = int.Parse(filaDet["id_detalle_alumno_examen"].ToString());
                det.NotaDetalle = int.Parse(filaDet["nota"].ToString());
                det.AlumnoDetalle.IdAlumno = int.Parse(filaDet["id_alumno"].ToString());
                det.AlumnoDetalle.Nombre = filaDet["nom_alumno"].ToString();
                det.AlumnoDetalle.Apellido = filaDet["ape_alumno"].ToString();
                oExamen.DetallesExamen.Add(det);
            }
            return oExamen;
        }
        public List<Examen> TraerExamenes(List<Parametro> lParam)
        {
            List<Examen> lExamenes = new List<Examen>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_EXAMENES", lParam);
            foreach(DataRow fila in tabla.Rows)
            {
                Examen oExamen = new Examen();
                oExamen.IdExamen = int.Parse(fila["id_examen"].ToString());
                oExamen.FechaExamen = DateTime.Parse(fila["fecha_examen"].ToString());
                oExamen.DocenteExamen.IdDocente = int.Parse(fila["id_docente"].ToString());
                oExamen.DocenteExamen.Nombre = fila["nom_docente"].ToString();
                oExamen.DocenteExamen.Apellido = fila["ape_docente"].ToString();
                oExamen.MateriaExamen.IdMateria = int.Parse(fila["id_materia"].ToString());
                oExamen.MateriaExamen.NombreMateria = fila["nom_materia"].ToString();
                lExamenes.Add(oExamen);
            }
            return lExamenes;
        }

        public List<Materia> TraerMaterias()
        {
            List<Materia> lMaterias = new List<Materia>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_MATERIAS");
            foreach(DataRow fila in tabla.Rows)
            {
                Materia oMateria = new Materia();
                oMateria.IdMateria = int.Parse(fila["id_materia"].ToString());
                oMateria.NombreMateria = fila["nom_materia"].ToString();
                oMateria.TecnicaturaMateria.IdTecnicatura = int.Parse(fila["id_tecnicatura"].ToString());
                oMateria.TecnicaturaMateria.TituloTecnicatura = fila["nom_tecnicatura"].ToString();
                lMaterias.Add(oMateria);
            }
            return lMaterias;
        }
        public List<Docente> TraerDocentesExamen(List<Parametro> lParam)
        {
            List<Docente> lDocentes = new List<Docente>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DOCENTES_MATERIA", lParam);
            foreach (DataRow fila in tabla.Rows)
            {
                Docente oDocente = new Docente();
                oDocente.IdDocente = int.Parse(fila["id_docente"].ToString());
                oDocente.Nombre = fila["nom_docente"].ToString();
                oDocente.Apellido = fila["ape_docente"].ToString();
                int idTit = int.Parse(fila["id_titulo"].ToString());
                string tit = fila["titulo"].ToString();
                Titulo auxTitulo = new Titulo(idTit, tit);
                oDocente.TituloDocente = auxTitulo;
                lDocentes.Add(oDocente);
            }
            return lDocentes;
        }
        public List<Alumno> TraerAlumnosExamen(List<Parametro> lParam)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_ALUMNOS_EXAMEN", lParam);
            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Alumno oAlumno = new Alumno();
                    oAlumno.IdAlumno = int.Parse(fila["id_alumno"].ToString());
                    oAlumno.Nombre = fila["nom_alumno"].ToString();
                    oAlumno.Apellido = fila["ape_alumno"].ToString();
                    lAlumnos.Add(oAlumno);
                }
            }
            return lAlumnos;
        }
    }
}
