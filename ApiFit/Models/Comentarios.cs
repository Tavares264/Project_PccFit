using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PccAPI.Models
{
    public class Comentarios
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Comentario { get; set; }
        public string Assunto { get; set; }

        public Comentarios(string r1, string r2, string r3, string r4)
        {
            this.Nome = r1;
            this.Email = r2;
            this.Comentario = r3;
            this.Assunto = r4;
        }
    }
}