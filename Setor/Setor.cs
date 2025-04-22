using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

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

            btnCancelar.Visible = false;

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

                    if (metodos.InserirSetor() == true)
                    {

                        MessageBox.Show("Usuário cadatrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            MetodoSetor setor = new MetodoSetor();

            setor.ListarTodosSetores(dataGrind);

        }

        private void DataGrind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGrind.BeginEdit(false);

            txtID.Text = dataGrind.CurrentRow.Cells[0].Value.ToString();
            txtNomeSetor.Text = dataGrind.CurrentRow.Cells[1].Value.ToString();

            txtID.Enabled = false;
            btnCancelar.Visible = true; 
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtID.Clear();
            txtNomeSetor.Clear();

            txtID.Enabled = true;
            btnCancelar.Visible = false;
        }
    }
}
