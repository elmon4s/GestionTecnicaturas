using Back.Datos.Interfaz;
using Back.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Implementacion
{
    public class UsuariosDAO:IUsuariosDAO
    {
        public bool CrearUsuario(Usuario nuevoUsuario)
        {
            bool aux = true;
            SqlTransaction transaccion = null;
            SqlConnection conexion = HelperDAO.ObtenerInstancia().ObtenerConexion();
            string contHasheada = BCrypt.Net.BCrypt.HashPassword(nuevoUsuario.ContUsuario);
            nuevoUsuario.ContUsuario = contHasheada;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("SP_NUEVO_USER", conexion, transaccion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@usuario", nuevoUsuario.NomUsuario);
                comando.Parameters.AddWithValue("@contraseña", nuevoUsuario.ContUsuario);
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
                    conexion.Close();
            }
            return aux;
        }


        public bool ComprobarUsuario(Usuario oUsuario)
        {
            bool aux = false;
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@usuario", oUsuario.NomUsuario));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CHECK_USER", lParam);
            foreach (DataRow r in tabla.Rows)
            {
                aux = BCrypt.Net.BCrypt.Verify(oUsuario.ContUsuario, r["contraseña"].ToString());
            }
            return aux;
        }

        public bool ComprobarNombreUsuario(Usuario oUsuario)
        {
            bool aux = true;
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@usuario", oUsuario.NomUsuario));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("SP_CHECK_USER", lParam);
            if (tabla.Rows.Count == 0)
            {
                aux = false;
            }
            return aux;
        }
    }
}
