using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setor
{
    class MetodoSetor
    {
        private int id;
        private string nome;

        public int Id
        {
            get { return id; }
            set { id = value; }

        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool InserirSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string sqlInsert = "INSERT INTO setor (nome) VALUES (@nome)";

                    MySqlCommand comandoSQL = new MySqlCommand(sqlInsert, conexaoBanco);

                    comandoSQL.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comandoSQL.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar setor -> {ex.Message}" + "ERRO" + MessageBoxIcon.Exclamation);
                return false;

            }
        }

        public bool EditarSetor()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {
                    string sqlUpdate = "INSERT INTO setor (nome) VALUES (@nome)";

                    MySqlCommand comandoSQL = new MySqlCommand(sqlUpdate, conexaoBanco);

                    comandoSQL.Parameters.AddWithValue("@nome", Nome);

                    int resultado = comandoSQL.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar setor -> {ex.Message}" + "ERRO" + MessageBoxIcon.Exclamation);
                return false;

            }
        }
       public bool ExcluirSetor() { }
        public bool ListarTodosSetores(DataGridView DataGrind) {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar()) {

                    string sqlSelect = "SELECT * FROM Setor";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlSelect, conexaoBanco);

                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);

                    DataGrind.AllowUserToAddRows = false;
                    DataGrind.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    DataGrind.DataSource = dataTable;
                    DataGrind.AutoResizeColumns();

                    if (DataGrind.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    DataGrind.ClearSelection();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Erro ao listar todos os objetos -> {ex.Message}");

            }
        }

        public bool ListarSetorNome() { } 
    }
}
