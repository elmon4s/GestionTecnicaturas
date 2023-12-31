﻿using Back.Datos;
using Back.Datos.Implementacion;
using Back.Datos.Interfaz;
using Back.Dominio;
using Back.Fachada.Interfaz;
using Back.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        IAlumnosDAO alumnosDAO;
        IDocentesDAO docentesDAO;
        IExamenesDAO examenesDAO;
        IUsuariosDAO usuariosDAO;
        IReportesDAO reportesDAO;

        public Aplicacion()
        {
            alumnosDAO = new AlumnosDAO();
            docentesDAO = new DocentesDAO();
            examenesDAO = new ExamenesDAO();
            usuariosDAO = new UsuariosDAO();
            reportesDAO = new ReportesDAO();
        }

        public bool CheckNombreUsuario(Usuario oUsuario)
        {
            return usuariosDAO.ComprobarNombreUsuario(oUsuario);
        }

        public bool CheckUsuario(Usuario oUsuario)
        {
            return usuariosDAO.ComprobarUsuario(oUsuario);
        }

        public bool DeleteAlumno(int nroAlumno)
        {
            return alumnosDAO.BorrarAlumno(nroAlumno);
        }

        public bool DeleteDocente(int nroDocente)
        {
            return docentesDAO.BorrarDocente(nroDocente);
        }

        public bool DeleteExamen(int nroExamen)
        {
            return examenesDAO.BorrarExamen(nroExamen);
        }

        public Alumno GetAlumno(int nroAlumno)
        {
            return alumnosDAO.TraerAlumno(nroAlumno);
        }

        public List<Alumno> GetAlumnos(List<Parametro> lParam)
        {
            return alumnosDAO.TraerAlumnos(lParam);
        }

        public List<Alumno> GetAlumnosExamen(List<Parametro> lParam)
        {
            return examenesDAO.TraerAlumnosExamen(lParam);
        }

        public List<Barrio> GetBarrios()
        {
            return docentesDAO.TraerBarrios();
        }

        public List<Comision> GetComisiones()
        {
            return reportesDAO.TraerComisiones();
        }

        public Docente GetDocente(int nroDocente)
        {
            return docentesDAO.TraerDocente(nroDocente);
        }

        public List<Docente> GetDocentes(List<Parametro> lParam)
        {
            return docentesDAO.TraerDocentes(lParam);
        }

        public List<Docente> GetDocentesExamen(List<Parametro> lParam)
        {
            return examenesDAO.TraerDocentesExamen(lParam);
        }

        public List<EstadoAcademico> GetEstadosAcademicos()
        {
            return alumnosDAO.TraerEstadosAcademicos();
        }

        public List<EstadoCivil> GetEstadosCiviles()
        {
            return alumnosDAO.TraerEstadosCiviles();
        }

        public Examen GetExamen(int nroExamen)
        {
            return examenesDAO.TraerExamen(nroExamen);
        }

        public List<Examen> GetExamenes(List<Parametro> lParam)
        {
            return examenesDAO.TraerExamenes(lParam);
        }

        public List<DetalleMateriaComision> GetMateriaComision(List<Parametro> lParam)
        {
            return alumnosDAO.TraerMateriaComision(lParam);
        }

        public List<DetalleMateriaComision> GetMateriaComisionFiltrado(List<Parametro> lParam)
        {
            return alumnosDAO.TraerMateriaComisionFiltrado(lParam);
        }

        public List<Materia> GetMaterias()
        {
            return examenesDAO.TraerMaterias();
        }

        public int GetProximoExamen()
        {
            return examenesDAO.ObtenerProximoExamen();
        }

        public List<SituacionLaboral> GetSituacionesLaborales()
        {
            return alumnosDAO.TraerSituacionesLaborales();
        }

        public List<Tecnicatura> GetTecnicaturas()
        {
            return reportesDAO.TraerTecnicaturas();
        }

        public List<Titulo> GetTitulos()
        {
            return docentesDAO.TraerTitulos();
        }

        public bool SaveAlumno(Alumno oAlumno)
        {
            return alumnosDAO.ConfirmarAlumno(oAlumno);
        }

        public bool SaveDocente(Docente oDocente)
        {
            return docentesDAO.CrearDocente(oDocente);
        }

        public bool SaveExamen(Examen oExamen)
        {
            return examenesDAO.ConfirmarExamen(oExamen);
        }

        public bool SaveUsuario(Usuario nuevoUsuario)
        {
            return usuariosDAO.CrearUsuario(nuevoUsuario);
        }

        public bool UpdateAlumno(Alumno oAlumno)
        {
            return alumnosDAO.ActualizarAlumno(oAlumno);
        }

        public bool UpdateDocente(Docente oDocente)
        {
            return docentesDAO.ActualizarDocente(oDocente);
        }

        public bool UpdateExamen(Examen oExamen)
        {
            return examenesDAO.ActualizarExamen(oExamen);
        }
    }
}
