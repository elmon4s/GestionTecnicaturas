﻿using Back.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Interfaz
{
    public interface IUsuariosDAO
    {
        public bool CrearUsuario(Usuario nuevoUsuario);
        public Usuario TraerUsuario(string nombreUsuario);
    }
}
