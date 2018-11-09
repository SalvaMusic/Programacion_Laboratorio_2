﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int id;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Persona(string nombre, string apellido, int id)
            : this(nombre,apellido)
        {
            this.ID = id;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
    }
}