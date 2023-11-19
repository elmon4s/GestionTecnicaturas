using Back.Datos;
using Back.Dominio;
using Front.Cliente;
using Newtonsoft.Json;

namespace Front.Presentacion.Docentes
{
    public partial class FrmConsultaDocentes : Form
    {
        //TODO: Completar Forumlario
        public FrmConsultaDocentes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocentes.CurrentCell.ColumnIndex == 5)
            {
                int nro = Convert.ToInt32(dgvDocentes.CurrentRow.Cells["cIdDocente"].Value);
                new FrmGestorDocente(nro).ShowDialog();  //llamada con constructor con parámetro.
            }
        }

        private async void FrmConsultaDocentes_Load(object sender, EventArgs e)
        {
            await CargarBarrios();
            await CargarTitulos();
        }
        private async Task CargarBarrios()
        {
            string url = "https://localhost:7031/barrios"; //agregar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Barrio> lBarrio = JsonConvert.DeserializeObject<List<Barrio>>(dtosJson);
            cboBarrio.DataSource = lBarrio;
            cboBarrio.ValueMember = "IdBarrio";
            cboBarrio.DisplayMember = "NombreBarrioCompleto";
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private async Task CargarTitulos()
        {
            string url = "https://localhost:7031/titulos"; //agegar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Titulo> lTitulo = JsonConvert.DeserializeObject<List<Titulo>>(dtosJson);
            cboTitulo.DataSource = lTitulo;
            cboTitulo.ValueMember = "IdTitulo";
            cboTitulo.DisplayMember = "DescripcionTitulo";
            cboTitulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            //validar campos de carga!!!
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@titulo", int.Parse(cboTitulo.SelectedValue.ToString())));
            lst.Add(new Parametro("@barrio", int.Parse(cboBarrio.SelectedValue.ToString())));
            lst.Add(new Parametro("@nombre", txtNom.Text));

            await consultarAsync(lst);
        }
        private string UrlCompleta(string location)
        {
            return Properties.Resources.URL + location;
        }
        private async Task consultarAsync(List<Parametro> lst) //ahhhhhhhhhhhh
        {
            int t = int.Parse(cboTitulo.SelectedValue.ToString());
            int b = int.Parse(cboBarrio.SelectedValue.ToString());
            string n = txtNom.Text;
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta($"/lstdocentes?nombre={n}&titulo={t}&barrio={b}"));
            List<Docente> lDocente = JsonConvert.DeserializeObject<List<Docente>>(dtosJson);
            if (lDocente != null)
            {
                dgvDocentes.Rows.Clear();
                foreach (Docente d in lDocente)
                {
                    dgvDocentes.Rows.Add(new object[]
                    {
                 d.IdDocente, d.ToString(), d.TituloDocente, d.Email, d.Telefono, "Gestionar"
                    });
                }
            }
            else
            {
                MessageBox.Show("No se encontro ningun docente con esas caracteristicas");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void FrmConsultaDocentes_Load_1(object sender, EventArgs e)
        {
            cboBarrio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTitulo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}