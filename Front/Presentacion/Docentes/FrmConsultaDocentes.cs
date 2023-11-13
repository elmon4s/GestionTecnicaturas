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

        private async void consultarAsync(List<Parametro> lst) //ahhhhhhhhhhhh
        {
            int t = int.Parse(cboTitulo.SelectedValue.ToString());
            int b = int.Parse(cboBarrio.SelectedValue.ToString());
            string n = txtNom.Text;
            string url = "https://localhost:7031/lstdocentes?lParam=%7B%0A%20%20%22titulo%22%3A%20%22titulo%22%2C%0A%20%20%22int%22%3A%20%22" + t + "%22%0A%7D&lParam=%7B%0A%20%20%22barrio%22%3A%20%22barrio%22%2C%0A%20%20%22int%22%3A%20%22" + b + "%22%0A%7D&lParam=%7B%0A%20%20%22nombre%22%3A%20%22nombre%22%2C%0A%20%20%22string%22%3A%20%22" + n + "%22%0A%7D"; //agregar url de api
            var dtosJson = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Docente> lDocente = JsonConvert.DeserializeObject<List<Docente>>(dtosJson);
            if (lDocente != null)
            {
                foreach (Docente d in lDocente)
                {
                    dgvDocentes.Rows.Add(new object[]
                    {
                 d.IdDocente, d.Nombre, d.Apellido, d.TituloDocente, d.Direccion, d.Altura, d.Barrio, d.Telefono, d.Email, "Gestionar"
                    });
                }
            }
            else MessageBox.Show("No se encontro ningun docente con esas caracteristicas");
        }
    }
}
