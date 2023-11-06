using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Login
{
    internal class Usuario
    {
        public string NomUsuario { get; set; }
        public string ContUsuario { get; set; }

        public Usuario()
        {
            NomUsuario=string.Empty;
            ContUsuario=string.Empty;
        }

        public Usuario(string n, string c)
        {
            NomUsuario = n;
            ContUsuario=c;
        }
    }
}
