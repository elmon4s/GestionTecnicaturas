using Back.Datos;
using Back.Dominio;
using Back.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Fachada.Interfaz
{
    public interface IAplicacion
    {
        //Alumnos
        public bool SaveAlumno(Alumno oAlumno);
        public bool UpdateAlumno(Alumno oAlumno);
        public bool DeleteAlumno(int nroAlumno);
        public Alumno GetAlumno(int nroAlumno);
        public List<Alumno> GetAlumnos(List<Parametro> lParam);
        public List<SituacionLaboral> GetSituacionesLaborales();
        public List<EstadoCivil> GetEstadosCiviles();
        public List<DetalleMateriaComision> GetMateriaComision(List<Parametro> lParam);

        //Para Docentes y Alumnos
        public List<Barrio> GetBarrios();

        //Examenes
        public int GetProximoExamen();
        public bool SaveExamen(Examen oExamen);
        public bool UpdateExamen(Examen oExamen);
        public bool DeleteExamen(int nroExamen);
        public Examen GetExamen(int nroExamen);
        public List<Examen> GetExamenes(List<Parametro> lParam);
        public List<Materia> GetMaterias();
        public List<Docente> GetDocentesExamen(List<Parametro> lParam);
        public List<Alumno> GetAlumnosExamen(List<Parametro> lParam);

        //Docentes
        public bool SaveDocente(Docente oDocente);
        public bool UpdateDocente(Docente oDocente);
        public bool DeleteDocente(int nroDocente);
        public List<Docente> GetDocentes(List<Parametro> lParam);
        public Docente GetDocente(int nroDocente);
        public List<Titulo> GetTitulos();

        //Usuarios

        public bool SaveUsuario(Usuario nuevoUsuario);
        public bool CheckUsuario(Usuario oUsuario);
    }
}
