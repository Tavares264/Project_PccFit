using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PccAPI.Models
{
    public class Login
    {
        public string CPF { get; set; }
        public string Senha { get; set; }

        public Login(string r1, string r2, string r3, string r4)
        {
            this.CPF = r1;
            this.Senha = r2;
        }
    }
}