using MySql.Data.MySqlClient;

namespace Setor
{
    public partial class Setor : Form
    {
        public Setor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGrind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals(""))
                {
                    MetodoSetor metodos = new MetodoSetor();
                    metodos.Nome = txtNome.Text;

                    if (metodos.InserirSetor())
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnListarPnome_Click(object sender, EventArgs e)
        {

        }

        private void btnListarTodos_Click(object sender, EventArgs e)
        {

        }
    }
}
