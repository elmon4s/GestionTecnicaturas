using Back.Datos;
using Back.Dominio;
using Front.Cliente;
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

namespace Front.Presentacion.Examenes
{
    public partial class FrmConsultarExamenes : Form
    {
        private List<Examen> lstExamenes;
        public FrmConsultarExamenes()
        {
            InitializeComponent();
            lstExamenes = new List<Examen>();
        }
        private async void FrmConsultarExamenes_Load(object sender, EventArgs e)
        {
            pnlFechas.Enabled = false;
            dtpFechaDesde.Value = DateTime.Now.AddYears(-1);
            dtpFechaHasta.Value = DateTime.Now;
            await CargarDatosAsync<Materia>($"{Properties.Resources.URL}/materias", cboMaterias, "NombreMateria", "IdMateria");
        }

        #region Cargar Combos y Acivar/Desactivar fechas
        private async Task CargarDatosAsync<T>(string apiUrl, ComboBox comboBox, string displayMember, string valueMember)
        {
            var resultado = await ClienteSingleton.GetInstance().GetAsync(apiUrl);
            List<T> lst = JsonConvert.DeserializeObject<List<T>>(resultado);

            comboBox.DataSource = lst;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
        private async void cboMaterias_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboMaterias.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una Materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idMateria = Convert.ToInt32(cboMaterias.SelectedValue.ToString());
            await CargarDatosAsync<Docente>($"{Properties.Resources.URL}/docentesExamen?materia={idMateria}", cboDocentes, "Apellido", "IdDocente");
        }

        private void ckbActivar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbActivar.Checked)
            {
                pnlFechas.Enabled = true;
                ckbActivar.Text = "Desactivar Fechas";
            }
            else
            {
                pnlFechas.Enabled = false;

                ckbActivar.Text = "Activar Fechas";
            }
        }
        #endregion

        #region Boton Consultar examenes
        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Parametro> lstParametros = new List<Parametro>();
                if (!(cboMaterias.SelectedIndex == -1))
                    lstParametros.Add(new Parametro("@id_materia", Convert.ToInt32(cboMaterias.SelectedValue.ToString())));
                if (!(cboDocentes.SelectedIndex == -1))
                    lstParametros.Add(new Parametro("@id_docente", Convert.ToInt32(cboDocentes.SelectedValue.ToString())));
                if (pnlFechas.Enabled)
                {
                    lstParametros.Add(new Parametro("@fecha_desde", dtpFechaDesde.Value.ToString("yyyy-MM-dd")));
                    lstParametros.Add(new Parametro("@fecha_hasta", dtpFechaHasta.Value.ToString("yyyy-MM-dd")));
                }

                if (lstParametros.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar una al menos una condicion de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string endpoint = $"{Properties.Resources.URL}/lstexamenes";
                string lstParametrosJson = JsonConvert.SerializeObject(lstParametros);
                var dataJson = await ClienteSingleton.GetInstance().PostAsync(endpoint, lstParametrosJson);

                lstExamenes.Clear();
                lstExamenes = JsonConvert.DeserializeObject<List<Examen>>(dataJson) ?? new List<Examen>();

                dgvExamenes.Rows.Clear();
                foreach (Examen examen in lstExamenes)
                {
                    dgvExamenes.Rows.Add(new object[] { examen.IdExamen, examen.FechaExamen,
                    $"{examen.DocenteExamen.Nombre},{examen.DocenteExamen.Apellido}"});
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Boton eliminar examenes
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvExamenes.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvExamenes.SelectedRows[0];

                if (MessageBox.Show("¿Desea borrar este examen? No se pueden deshacer los cambios", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int nro = Convert.ToInt32(filaSeleccionada.Cells["ColIdExamen"].Value.ToString());


                    if (await EliminarExamenAsync(nro))
                    {
                        MessageBox.Show("Se elimino el examen!!!");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el examen...");
                    }
                    dgvExamenes.Rows.Remove(filaSeleccionada);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada para eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async Task<bool> EliminarExamenAsync(int nro)
        {
            string url = $"{Properties.Resources.URL}/examen?nroExamen={nro}";
            var dataJson = await ClienteSingleton.GetInstance().DeleteAsync(url);

            return dataJson.Equals("true");
        }
        #endregion

        #region Editar examenes
        private async void dgvExamenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvExamenes.CurrentCell.ColumnIndex == 3)
            {
                int nro = Convert.ToInt32(dgvExamenes.CurrentRow.Cells["ColIdExamen"].Value.ToString());
                Examen oExamen = await TraerExamenAsync(nro);
                new FrmGestorExamen(oExamen).ShowDialog();
            }
        }

        private async Task<Examen> TraerExamenAsync(int nro)
        {
            var url = $"{Properties.Resources.URL}/examen/{nro}";
            var resultado = await ClienteSingleton.GetInstance().GetAsync(url);
            Examen e = JsonConvert.DeserializeObject<Examen>(resultado) ?? new Examen();
            return e;
        }
        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                this.Dispose();
        }


    }
}