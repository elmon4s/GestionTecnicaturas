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

namespace Front.Presentacion.Alumnos
{
    public partial class FrmConsultaAlumnos : Form
    {
        public FrmConsultaAlumnos()
        {
            InitializeComponent();
        }

        async private void FrmConsultaAlumnos_Load(object sender, EventArgs e)
        {
            await CargarComboAsync<EstadoCivil>(UrlCompleta("/estadosciviles"), cboEstadoCivil);
            await CargarComboAsync<SituacionLaboral>(UrlCompleta("/situacioneslab"), cboSituacionLaboral);
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSituacionLaboral.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async Task CargarComboAsync<T>(string url, ComboBox comboBox)
        {
            var res = await ClienteSingleton.GetInstance().GetAsync(url);

            List<T> lst = JsonConvert.DeserializeObject<List<T>>(res);

            comboBox.DataSource = lst;
        }

        private string UrlCompleta(string location)
        {
            return Properties.Resources.URL + location;
        }

        private async void ActualizarDgv()
        {
            dgvAlumnos.Rows.Clear();
            int situacionLab = ((SituacionLaboral)cboSituacionLaboral.SelectedItem).IdSituacion;
            int estadoCivil = ((EstadoCivil)cboEstadoCivil.SelectedItem).IdEstadoCivil;
            string alumnosString = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta($"/lstalumnos?nombre={txtNombre.Text}&situacionLab={situacionLab}&estadoCivil={estadoCivil}"));
            List<Alumno> lAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(alumnosString);

            foreach (Alumno a in lAlumnos)
            {
                dgvAlumnos.Rows.Add(new object[]
                {
                    a.IdAlumno.ToString(),
                    a.Nombre,
                    a.Apellido,
                    a.SituacionAlumno.Situacion,
                    a.EstadoCivilAlumno.DescripcionEstadoCivil,
                    "Editar",
                    "Borrar"
                });
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDgv();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnos.CurrentCell.ColumnIndex == 5)
            {
                new FrmGestorAlumno(Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value)).ShowDialog();
            }
            else if (dgvAlumnos.CurrentCell.ColumnIndex == 6)
            {
                if (MessageBox.Show("¿Seguro que quiere eliminar este alumno?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string confirmar = await ClienteSingleton.GetInstance().DeleteAsync(UrlCompleta($"/alumno?nroAlumno={dgvAlumnos.CurrentRow.Cells[0].Value}"));

                    if (JsonConvert.DeserializeObject<bool>(confirmar))
                    {
                        MessageBox.Show("Alumno borrado con éxito", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarDgv();
                    }
                    else
                        MessageBox.Show("Error al borrar alumno", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
