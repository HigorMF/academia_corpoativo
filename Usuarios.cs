using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia_corpoativo
{
    public class Usuarios
    {
        public string Email { get; set;}
        public string Senha { get; set; }

        public Usuarios (string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
