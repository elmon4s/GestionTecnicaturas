using Back.Dominio;
using Front.Cliente;
using Front.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Presentacion.Alumnos
{
    public partial class FrmConsultarDetalleMateriaComision : Form
    {
        public DetalleMateriaComision Result;

        private List<DetalleMateriaComision> lMateriaComision = new List<DetalleMateriaComision>();
        public FrmConsultarDetalleMateriaComision()
        {
            InitializeComponent();

        }

        async private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            string materiaString = await ClienteSingleton.GetInstance().GetAsync(Properties.Resources.URL + $"/materiacomisionfiltrados?docente={txtDocente.Text}&comision={txtComision.Text}&materia={txtMateria.Text}");
            lMateriaComision = JsonConvert.DeserializeObject<List<DetalleMateriaComision>>(materiaString);

            foreach (DetalleMateriaComision dmc in lMateriaComision)
            {
                dgvDetalles.Rows.Add(new object[]
                {
                    dmc.IdDetalleMateriaComision.ToString(),
                    dmc.DocenteMateriaComision.Apellido + " " + dmc.DocenteMateriaComision.Nombre,
                    dmc.MateriaDetalle.NombreMateria,
                    dmc.ComisionDetalle.DescripcionComision,
                    "Seleccionar"
                });
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentCell.ColumnIndex == 4)
            {
                foreach (DetalleMateriaComision dmc in lMateriaComision)
                {
                    if (dmc.IdDetalleMateriaComision == Convert.ToInt32(dgvDetalles.CurrentRow.Cells[0].Value))
                    {
                        Result = dmc;
                        break;
                    }
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
