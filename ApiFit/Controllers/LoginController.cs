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
using System.Text;
using Newtonsoft.Json;

namespace PccAPI.Controller
{
    public class LoginController : ApiController
    {
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;

        public string Get()
        {
            return "{'estatos':'OK'}";
        }

        public string Post(string cpf, string senha)
        {
            if (!string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(senha))
            {
                string acesso = "";

                string query = "SELECT * FROM tb_login WHERE cpf = " + cpf + " AND senha = " + senha + ";";
                using (MySqlConnection conexao = new MySqlConnection(myconn))
                {
                    MySqlCommand command = new MySqlCommand(query, conexao);

                    conexao.Open();

                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            acesso = Convert.ToString(reader["acesso"]);
                        }
                        if (acesso == "nutricionista")
                        {
                            return @"{""acesso"":""nutricionista""}";
                        }
                        else if (acesso == "atendente")
                        {
                            return @"{""acesso"":""atendente""}";
                        }
                        else
                        {
                            return @"{""acesso"": ""VAZIO""}";
                        }
                    }
                    else
                    {
                        return @"{""acesso"": ""INVALIDO""}";
                    }
                }
            }
            else
            {
                return @"{""estatos"":""RUIM""}";
            }
        }
    }
}
