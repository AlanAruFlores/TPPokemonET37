using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonUsuario
{
    class Personaje
    {
        private string nombrePersonaje;

        public Personaje(string nombrePersonaje)
        {
            this.nombrePersonaje = nombrePersonaje;
        }
        public string NombrePersonaje
        {
            get => this.nombrePersonaje;
            set => this.nombrePersonaje = value;
        }
    }
}
