using PccAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Web.Script.Serialization;

namespace PccAPI.Controllers
{
    public class LoginController : ApiController
    {
        private static List<Login> logins = new List<Login>();
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        public string Get()
        {
            return "{'estatos':'OK'}";
        }

        //public string Post(string cpf, string senha)
        //{
        //    if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
        //    {
        //        string acesso = "";

        //        string query = "SELECT * FROM tb_login WHERE cpf = " + cpf + " AND senha = " + senha + ";";
        //        using (MySqlConnection conexao = new MySqlConnection(myconn))
        //        {
        //            MySqlCommand command = new MySqlCommand(query, conexao);

        //            conexao.Open();

        //            reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    acesso = Convert.ToString(reader["acesso"]);
        //                }
        //                if (acesso == "nutricionista")
        //                {
        //                    return @"{""acesso"":""nutricionista""}";
        //                }
        //                else if (acesso == "atendente")
        //                {
        //                    return @"{""acesso"":""atendente""}";
        //                }
        //                else
        //                {
        //                    return @"{""acesso"": ""VAZIO""}";
        //                }
        //            }
        //            else
        //            {
        //                return @"{""acesso"": ""INVALIDO""}";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return @"{""estatos"":""RUIM""}";
        //    }
        //}


        public string Post(string nome, string email, string comentario, string assunto)
        {
            if (!string.IsNullOrEmpty(comentario) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(assunto))
            {
                try
                {

                    string query = "INSERT INTO tb_comentarios (nome, email, comentario, assunto) values (@Nome, @Email, @Coment, @Assunto)";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Comentario", comentario);
                        command.Parameters.AddWithValue("@Assunto", assunto);

                        conexao.Open();
                        reader = command.ExecuteReader();
                        conexao.Close();

                        return @"{""Status"":""OK""}";
                    }
                }catch
                {
                    return @"{""Status"":""ERRO""}";
                }
            }
            else
            {
                return @"{""Status"":""Campos Vazios""}";
            }
        }

        

        public List<string> Get(string assunto)
        {
            List<string> list = new List<string>();
            if (!string.IsNullOrEmpty(assunto))
            {
                try
                {
                    string query = "SELECT * FROM tb_comentarios WHERE assunto = @Assunto;";
                    using (MySqlConnection conexao = new MySqlConnection(myconn))
                    {
                        MySqlCommand command = new MySqlCommand(query, conexao);
                        command.Parameters.AddWithValue("@Assunto", assunto);

                        conexao.Open();
                        reader = command.ExecuteReader();
                        
                        return list.Add(reader.Read());

                        conexao.Close();

                          
                    }
                }
                catch
                {
                    return @"{""Status"":""ERRO""}";
                }
            }
            else
            {
                return @"{""Status"":""Campos Vazios""}";
            }
        }
    }
}
