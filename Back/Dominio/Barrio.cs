﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Barrio
    {
        //Este se utiliza solo para poder cargar el displaymember de los combos
        public string NombreBarrioCompleto
        {
            get { return $"{NombreBarrio} - {CiudadBarrio.NombreCiudad}"; }
        }

        public int IdBarrio { get; set; }
        public string NombreBarrio { get; set; }
        public Ciudad CiudadBarrio { get; set; }

        public Barrio()
        {
            IdBarrio = 0;
            NombreBarrio = string.Empty;
            CiudadBarrio = new Ciudad();
        }

        public Barrio(int id, string nom, Ciudad ciudad)
        {
            IdBarrio = id;
            NombreBarrio = nom;
            CiudadBarrio = ciudad;
        }

        public override string ToString()
        {
            return NombreBarrio+" - "+CiudadBarrio.NombreCiudad;
        }
    }
}
