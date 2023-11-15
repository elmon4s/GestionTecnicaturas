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
            if (dgvDocentes.CurrentCell.RowIndex == 5)
            {
                int nro = Convert.ToInt32(dgvDocentes.CurrentRow.Cells["cIdDocente"].Value);
                new FrmGestorDocente(nro).ShowDialog();  //llamada con constructor con parámetro.
            }
        }

        private void FrmConsultaDocentes_Load(object sender, EventArgs e)
        {
            CargarBarrios();
            CargarTitulos();
        }
        private async void CargarBarrios()
        {
            string url = "https://localhost:7031/barrios"; //agregar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Barrio> lBarrio = JsonConvert.DeserializeObject<List<Barrio>>(dtosJson);
            cboBarrio.DataSource = lBarrio;
            cboBarrio.ValueMember = "IdBarrio";
            cboBarrio.DisplayMember = "NombreBarrio";

        }
        private async void CargarTitulos()
        {
            string url = "https://localhost:7031/titulos"; //agegar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Titulo> lTitulo = JsonConvert.DeserializeObject<List<Titulo>>(dtosJson);
            cboTitulo.DataSource = lTitulo;
            cboTitulo.ValueMember = "IdTitulo";
            cboTitulo.DisplayMember = "DescripcionTitulo";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //validar campos de carga!!!
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@titulo", int.Parse(cboTitulo.SelectedValue.ToString())));
            lst.Add(new Parametro("@barrio", int.Parse(cboBarrio.SelectedValue.ToString())));
            lst.Add(new Parametro("@nombre", txtNom.Text));

            consultarAsync(lst);
        }
        private string UrlCompleta(string location)
        {
            return Properties.Resources.URL + location;
        }
        private async void consultarAsync(List<Parametro> lst) //ahhhhhhhhhhhh
        {
            int t = int.Parse(cboTitulo.SelectedValue.ToString());
            int b = int.Parse(cboBarrio.SelectedValue.ToString());
            string n = txtNom.Text;
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(UrlCompleta($"/lstDocentes?nombre={txtNom.Text}&titulo={t}&barrio={b}"));
            List<Docente> lDocente = JsonConvert.DeserializeObject<List<Docente>>(dtosJson);
            if (lDocente != null)
            {
                foreach (Docente d in lDocente)
                {
                    dgvDocentes.Rows.Add(new object[]
                    {
                 d.IdDocente, d.ToString(), d.TituloDocente, d.Telefono, d.Email, "Gestionar"
                    });
                }
            }
            else MessageBox.Show("No se encontro ningun docente con esas caracteristicas");
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

        }
    }
}
