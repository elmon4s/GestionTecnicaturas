﻿using Back.Datos.Interfaz;
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
    public class AlumnosDAO:IAlumnosDAO
    {
        public bool ConfirmarAlumno(Alumno oAlumno)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_INSERTAR_ALUMNO", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_alumno", oAlumno.IdAlumno);
                comando.Parameters.AddWithValue("@nom_alumno", oAlumno.Nombre);
                comando.Parameters.AddWithValue("@ape_alumno", oAlumno.Apellido);
                comando.Parameters.AddWithValue("@direccion", oAlumno.Direccion);
                comando.Parameters.AddWithValue("@altura", oAlumno.Altura);
                comando.Parameters.AddWithValue("@nro_tel", oAlumno.Telefono);
                comando.Parameters.AddWithValue("@email", oAlumno.Email);
                comando.Parameters.AddWithValue("@id_barrio", oAlumno.Barrio.IdBarrio);
                comando.Parameters.AddWithValue("@id_situacion_laboral", oAlumno.SituacionAlumno.IdSituacion);
                comando.Parameters.AddWithValue("@id_estado_civil", oAlumno.EstadoCivilAlumno.IdEstadoCivil);
                comando.ExecuteNonQuery();
                foreach(DetalleAlumnoMateria det in oAlumno.DetallesAlumno)
                {
                    SqlCommand comandoDet = new SqlCommand("PA_INSERTAR_DETALLE_ALUMNO", conexion,transaccion);
                    comandoDet.CommandType = CommandType.StoredProcedure;
                    comandoDet.Parameters.AddWithValue("@id_alumno",oAlumno.IdAlumno);
                    comandoDet.Parameters.AddWithValue("@id_detalle_mat_com", det.DetalleMateriaComision.IdDetalleMateriaComision);
                    comandoDet.Parameters.AddWithValue("@id_estado_acad", det.EstadoDetalle.IdEstadoAcademico);
                    comandoDet.Parameters.AddWithValue("@fecha_inscr", det.FechaInscripcionDetalle);
                    comandoDet.Parameters.AddWithValue("@fecha_estado", det.FechaEstadoDetalle);
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
        public bool ActualizarAlumno(Alumno oAlumno)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_ACTUALIZAR_ALUMNO", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_alumno", oAlumno.IdAlumno);
                comando.Parameters.AddWithValue("@nom_alumno", oAlumno.Nombre);
                comando.Parameters.AddWithValue("@ape_alumno", oAlumno.Apellido);
                comando.Parameters.AddWithValue("@direccion", oAlumno.Direccion);
                comando.Parameters.AddWithValue("@altura", oAlumno.Altura);
                comando.Parameters.AddWithValue("@nro_tel", oAlumno.Telefono);
                comando.Parameters.AddWithValue("@email", oAlumno.Email);
                comando.Parameters.AddWithValue("@id_barrio", oAlumno.Barrio.IdBarrio);
                comando.Parameters.AddWithValue("@id_situacion_laboral", oAlumno.SituacionAlumno.IdSituacion);
                comando.Parameters.AddWithValue("@id_estado_civil", oAlumno.EstadoCivilAlumno.IdEstadoCivil);
                comando.ExecuteNonQuery();
                foreach (DetalleAlumnoMateria det in oAlumno.DetallesAlumno)
                {
                    SqlCommand comandoDet = new SqlCommand("PA_INSERTAR_DETALLE_ALUMNO", conexion, transaccion);
                    comandoDet.CommandType = CommandType.StoredProcedure;
                    comandoDet.Parameters.AddWithValue("@id_alumno", oAlumno.IdAlumno);
                    comandoDet.Parameters.AddWithValue("@id_detalle_mat_com", det.DetalleMateriaComision.IdDetalleMateriaComision);
                    comandoDet.Parameters.AddWithValue("@id_estado_acad", det.EstadoDetalle.IdEstadoAcademico);
                    comandoDet.Parameters.AddWithValue("@fecha_inscr", det.FechaInscripcionDetalle);
                    comandoDet.Parameters.AddWithValue("@fecha_estado", det.FechaEstadoDetalle);
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
        public bool BorrarAlumno(int nroAlumno)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_BORRAR_ALUMNO", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_alumno", nroAlumno);
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

        public Alumno TraerAlumno(int nroAlumno)
        {
            Alumno oAlumno = new Alumno();
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@id_alumno", nroAlumno));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_ALUMNO", lParam);
            foreach (DataRow fila in tabla.Rows)
            {
                oAlumno.IdAlumno = int.Parse(fila["id_alumno"].ToString());
                oAlumno.Nombre = fila["nom_alumno"].ToString();
                oAlumno.Apellido = fila["ape_alumno"].ToString();
                oAlumno.Direccion = fila["direccion"].ToString();
                oAlumno.Altura = int.Parse(fila["altura"].ToString());
                oAlumno.Telefono = fila["nro_tel"].ToString();
                oAlumno.Email = fila["email"].ToString();
                int idEst = int.Parse(fila["id_estado_civil"].ToString());
                string est = fila["estado_civil"].ToString();
                EstadoCivil auxEstado = new EstadoCivil(idEst, est);
                oAlumno.EstadoCivilAlumno = auxEstado;
                int idSit = int.Parse(fila["id_situacion_laboral"].ToString());
                string sit = fila["situacion_laboral"].ToString();
                SituacionLaboral auxSituacion = new SituacionLaboral(idSit, sit);
                oAlumno.SituacionAlumno = auxSituacion;
                int idBar = int.Parse(fila["id_barrio"].ToString());
                string bar = fila["barrio"].ToString();
                Barrio auxBarrio = new Barrio(idBar, bar, new Ciudad());
                int idCiud = int.Parse(fila["id_ciudad"].ToString());
                string ciud = fila["ciudad"].ToString();
                Ciudad auxCiudad = new Ciudad(idCiud, ciud);
                auxBarrio.CiudadBarrio = auxCiudad;
                oAlumno.Barrio = auxBarrio;
            }
            List<Parametro> lParamDet = new List<Parametro>();
            lParamDet.Add(new Parametro("@id_alumno",oAlumno.IdAlumno));
            DataTable tablaDet = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DETALLES_ALUMNO", lParamDet);
            foreach(DataRow filaDet in tablaDet.Rows)
            {
                DetalleAlumnoMateria det = new DetalleAlumnoMateria();
                det.IdDetalleAlumnoMateria = int.Parse(filaDet["id_detalle_alumno_materia"].ToString());
                det.FechaInscripcionDetalle = Convert.ToDateTime(filaDet["fecha_inscripcion"].ToString());
                det.FechaEstadoDetalle = Convert.ToDateTime(filaDet["fecha_estado"].ToString());
                EstadoAcademico auxEst = new EstadoAcademico();
                auxEst.IdEstadoAcademico = int.Parse(filaDet["id_estado_academico"].ToString());
                auxEst.DescEstadoAcademico = filaDet["estado_academico"].ToString();
                det.EstadoDetalle = auxEst;
                DetalleMateriaComision auxDetMC = new DetalleMateriaComision();
                auxDetMC.IdDetalleMateriaComision = int.Parse(filaDet["id_detalle_materia_comision"].ToString());
                auxDetMC.MateriaDetalle.IdMateria = int.Parse(filaDet["id_materia"].ToString());
                auxDetMC.MateriaDetalle.NombreMateria = filaDet["nom_materia"].ToString();
                auxDetMC.ComisionDetalle.IdComision = int.Parse(filaDet["id_comision"].ToString());
                auxDetMC.ComisionDetalle.DescripcionComision = filaDet["descripcion_comision"].ToString();
                auxDetMC.DocenteMateriaComision.IdDocente = int.Parse(filaDet["id_docente"].ToString());
                auxDetMC.DocenteMateriaComision.Nombre = filaDet["nom_docente"].ToString();
                auxDetMC.DocenteMateriaComision.Apellido = filaDet["ape_docente"].ToString();
                det.DetalleMateriaComision = auxDetMC;
                oAlumno.DetallesAlumno.Add(det);
            }
            return oAlumno;
        }
        public List<Alumno> TraerAlumnos(List<Parametro> lParam)
        {
            List<Alumno> lAlumnos = new List<Alumno>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_ALUMNOS", lParam);
            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    int id = int.Parse(fila["id_alumno"].ToString());
                    string nom = fila["nom_alumno"].ToString();
                    string ape = fila["ape_alumno"].ToString();
                    string dir = fila["direccion"].ToString();
                    int alt = int.Parse(fila["altura"].ToString());
                    string tel = fila["nro_tel"].ToString();
                    string mail = fila["email"].ToString();
                    Alumno oAlumno = new Alumno(id, new SituacionLaboral(), new EstadoCivil(), new List<DetalleAlumnoMateria>(), nom, ape, dir, alt, tel, mail, new Barrio());
                    int idEst = int.Parse(fila["id_estado_civil"].ToString());
                    string est = fila["estado_civil"].ToString();
                    EstadoCivil auxEstado = new EstadoCivil(idEst, est);
                    oAlumno.EstadoCivilAlumno = auxEstado;
                    int idSit = int.Parse(fila["id_situacion_laboral"].ToString());
                    string sit = fila["situacion_laboral"].ToString();
                    SituacionLaboral auxSituacion = new SituacionLaboral(idSit, sit);
                    oAlumno.SituacionAlumno = auxSituacion;
                    int idBar = int.Parse(fila["id_barrio"].ToString());
                    string bar = fila["barrio"].ToString();
                    Barrio auxBarrio = new Barrio(idBar, bar, new Ciudad());
                    int idCiud = int.Parse(fila["id_ciudad"].ToString());
                    string ciud = fila["ciudad"].ToString();
                    Ciudad auxCiudad = new Ciudad(idCiud, ciud);
                    auxBarrio.CiudadBarrio = auxCiudad;
                    oAlumno.Barrio = auxBarrio;
                    lAlumnos.Add(oAlumno);
                }
            }
            return lAlumnos;
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
        public List<SituacionLaboral> TraerSituacionesLaborales()
        {
            List<SituacionLaboral> lSituaciones = new List<SituacionLaboral>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_TRAER_SITUACIONES");
            foreach(DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_situacion_laboral"].ToString());
                string sit = fila["situacion_laboral"].ToString();

                SituacionLaboral oSituacion = new SituacionLaboral(id, sit);

                lSituaciones.Add(oSituacion);
            }
            return lSituaciones;
        }
        public List<EstadoCivil> TraerEstadosCiviles()
        {
            List<EstadoCivil> lEstados = new List<EstadoCivil>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_TRAER_ESTADOS_CIVILES");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_estado_civil"].ToString());
                string est = fila["estado_civil"].ToString();

                EstadoCivil oEstado = new EstadoCivil(id, est);

                lEstados.Add(oEstado);
            }
            return lEstados;
        }

        public List<DetalleMateriaComision> TraerMateriaComision(List<Parametro> lParam)
        {
            List<DetalleMateriaComision> lDetalles = new List<DetalleMateriaComision>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DMC_ALUMNOS",lParam);
            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    DetalleMateriaComision oDetalle = new DetalleMateriaComision();
                    int id = int.Parse(fila["id_detalle_materia_comision"].ToString());
                    int year = int.Parse(fila["año_lectivo"].ToString());
                    int idMat = int.Parse(fila["id_materia"].ToString());
                    string mat = fila["nom_materia"].ToString();
                    int idCom = int.Parse(fila["id_comision"].ToString());
                    string com = fila["descripcion_comision"].ToString();
                    lDetalles.Add(oDetalle);
                }
            }
            return lDetalles;
        }

        public List<DetalleMateriaComision> TraerMateriaComisionFiltrado(List<Parametro> lParam)
        {
            List<DetalleMateriaComision> lDetalles = new List<DetalleMateriaComision>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_DMC_ALUMNOS_FILT", lParam);
            if (tabla.Rows.Count != 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    int id = int.Parse(fila["id_detalle_materia_comision"].ToString());
                    int year = int.Parse(fila["año_lectivo"].ToString());
                    int idMat = int.Parse(fila["id_materia"].ToString());
                    string mat = fila["nom_materia"].ToString();
                    int idCom = int.Parse(fila["id_comision"].ToString());
                    string com = fila["descripcion_comision"].ToString();
                    string nomDocente = fila["nom_docente"].ToString();
                    string apeDocente = fila["ape_docente"].ToString();
                    Docente oDocente = new Docente();
                    oDocente.Nombre = nomDocente;
                    oDocente.Apellido = apeDocente;
                    Materia oMateria = new Materia();
                    oMateria.IdMateria = idMat;
                    oMateria.NombreMateria = mat;
                    Comision oComision = new Comision(idCom, com);
                    DetalleMateriaComision oDetalle = new DetalleMateriaComision(id, oDocente, oMateria, oComision, year);
                    lDetalles.Add(oDetalle);
                }
            }
            return lDetalles;
        }

        public List<EstadoAcademico> TraerEstadosAcademicos()
        {
            List<EstadoAcademico> lEstados = new List<EstadoAcademico>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_TRAER_ESTADOS_ACADEMICOS");
            foreach (DataRow fila in tabla.Rows)
            {
                int id = int.Parse(fila["id_estado_academico"].ToString());
                string est = fila["estado_academico"].ToString();

                EstadoAcademico oEstado = new EstadoAcademico(id, est);

                lEstados.Add(oEstado);
            }
            return lEstados;
        }
    }
}
