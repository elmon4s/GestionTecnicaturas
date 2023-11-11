using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Back.Datos
{
    internal class HelperDAO
    {
        private SqlConnection conexion;
        private static HelperDAO? instancia;
        private HelperDAO()
        {
            conexion = new SqlConnection(Properties.Resources.CadenaConexion);//stringConexion);
        }

        public static HelperDAO ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDAO();
            }
            return instancia;
        }

        public SqlConnection ObtenerConexion()
        {
            return this.conexion;
        }

        public int ObtenerEscalar(string sentencia, string nomParam)
        {
            int aux = 0;
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = sentencia;
            SqlParameter param = new SqlParameter(nomParam, SqlDbType.Int);
            param.Direction = ParameterDirection.Output;
            comando.Parameters.Add(param);
            comando.ExecuteNonQuery();
            conexion.Close();
            aux = (int)param.Value;
            return aux;
        }

        internal DataTable Consultar(string nombreSP)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();
            return tabla;
        }

        internal DataTable Consultar(string nombreSP, List<Parametro> lParams)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = nombreSP;
                foreach (Parametro p in lParams)
                {
                    comando.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
                tabla.Load(comando.ExecuteReader());
            }
            finally
            {
                conexion.Close();
            }
            return tabla;
        }
    }
}