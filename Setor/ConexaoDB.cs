using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setor
{
    public class ConexaoDB
    {
        private string conexaoBanco = "Server=localhost; Database=lista15; Uid=root; pwd='';";

        public MySqlConnection Conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;
        }
    }
}
