using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace PccFit
{
    class Conexao
    {
        string myconn = ConfigurationManager.AppSettings["msconn"];
        MySqlDataReader reader;
        
        public string conectar()
        {
            return myconn;
        }
    }
}
