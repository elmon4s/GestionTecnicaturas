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
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand comando = new SqlCommand("PA_NUEVO_USER", conexion, transaccion);
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

        public Usuario TraerUsuario(string nombreUsuario)
        {
            Usuario oUsuario = new Usuario();
            List<Parametro> lParam = new List<Parametro>();
            lParam.Add(new Parametro("@usuario",nombreUsuario));
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CHECK_USER", lParam);
            foreach(DataRow fila in tabla.Rows)
            {
                oUsuario.NomUsuario = fila["usuario"].ToString();
                oUsuario.ContUsuario = fila["contraseña"].ToString();
            }
            return oUsuario;
        }
    }
}
