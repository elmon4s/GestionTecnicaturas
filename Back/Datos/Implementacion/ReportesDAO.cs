using Back.Datos.Interfaz;
using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Implementacion
{
    internal class ReportesDAO : IReportesDAO
    {
        public List<Comision> TraerComisiones()
        {
            List<Comision> lComisiones = new List<Comision> ();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_COMISIONES");
            foreach (DataRow fila in tabla.Rows)
            {
                Comision oComision = new Comision();
                oComision.IdComision = int.Parse(fila["id_comision"].ToString());
                oComision.DescripcionComision = fila["descripcion_comision"].ToString();
                lComisiones.Add(oComision);
            }
            return lComisiones;
        }

        public List<Tecnicatura> TraerTecnicaturas()
        {
            List<Tecnicatura> lTecnicaturas = new List<Tecnicatura>();
            DataTable tabla = HelperDAO.ObtenerInstancia().Consultar("PA_CONSULTAR_TECNICATURAS");
            foreach (DataRow fila in tabla.Rows)
            {
                Tecnicatura oTecnicatura = new Tecnicatura();
                oTecnicatura.IdTecnicatura = int.Parse(fila["id_tecnicatura"].ToString());
                oTecnicatura.NombreTecnicatura = fila["nom_tecnicatura"].ToString();
                oTecnicatura.TituloTecnicatura = fila["titulo_tecnicatura"].ToString();
                lTecnicaturas.Add(oTecnicatura);
            }
            return lTecnicaturas;
        }
    }
}
