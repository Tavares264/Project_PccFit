using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PccFit
{
    
    class Atendente : Pessoa
    {
        
        private string myconn = ConfigurationManager.AppSettings["msconn"];

        Pessoa ps = new Pessoa();
        
        MySqlDataReader reader = 
        

        public void CadastrarFunc(string Cpf, string Nome, string Email, string Cep, string Logradouro, string Numero, string Bairro, string Cidade, string Estado, string Telefone, string Dt_inicio, string Dt_final)
        {
            string sqlquery = String.Format("INSERT INTO tb_funcionarios (cpf, nome, email, cep, logradouro, numero, bairro, cidade, estado, telefone, dt_inicio, dt_final) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11});", Cpf, Nome, Email, Cep, Logradouro, Numero, Bairro, Cidade, Estado, Telefone, Convert.ToDateTime(Dt_inicio), Convert.ToDateTime(Dt_final));

            using (MySqlConnection conexao = new MySqlConnection(myconn))
            {
                MySqlCommand command = new MySqlCommand(String.Format("select * from cpf = {1};",Cpf) ,conexao);
                Console.WriteLine(command.ExecuteReader());
            }
        }

        new void Pesquisar(string n1)
        {
            string sqlquery = String.Format("SELECT * from  tb_funcionarios cpf = {1};", Convert.ToDateTime(Dt_final));

            using (MySqlConnection conexao = new MySqlConnection(myconn))
            {
                MySqlCommand command = new MySqlCommand(sqlquery, conexao);
                Console.WriteLine(command.ExecuteReader());
            }
        }


    }
}
