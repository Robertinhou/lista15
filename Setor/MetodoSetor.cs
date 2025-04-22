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
                    string sqlInsert = "INSERT INTO setores (nome) VALUES (@nome)";

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
                    string sqlUpdate = "INSERT INTO setores (nome) VALUES (@nome)";

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
        public bool ExcluirSetor()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja apagar este setor?", "Exlusão de setor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                    {
                        string sqlDelete = "DELETE INTO setores (nome) VALUES (@nome)";

                        MySqlCommand comandoSQL = new MySqlCommand(sqlDelete, conexaoBanco);

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
                } else
                {
                    MessageBox.Show("Cancelado");
                    return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cancelar -> {ex.Message}");
                return false;
            }
            
        }
        public bool ListarTodosSetores(DataGridView DataGrind)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoDB().Conectar())
                {

                    string sqlSelect = "SELECT * FROM setores";

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
                return false;
            }
        }

       // public bool ListarSetorNome() { }
    }
}
