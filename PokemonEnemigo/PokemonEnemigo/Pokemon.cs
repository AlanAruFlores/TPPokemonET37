using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonEnemigo
{
    abstract class Pokemon
    {
        private string nombre;
        private int cantVida;
        private int cantAtaque;
        private Tipo tipoPokemon;
        private string urlImage;

        private int atmax;
        private int atmin;

        public Pokemon(string nombre, int cantVida, Tipo tipoPokemon, int cantAtaque, string image)
        {
            this.nombre = nombre;
            this.cantVida = cantVida;
            this.tipoPokemon = tipoPokemon;
            this.cantAtaque = cantAtaque;
            this.urlImage = image;

            this.atmin = 10;
            this.atmax = 20;
        }


        public void upgradeAttack(int atmin, int atmax)
        {
            this.atmin += atmin;
            this.atmax += atmax;
        }
        public void receiveAttack(int daño)
        {
            if (daño > cantVida)
            {
                this.cantVida = 0;
            }
            else
            {
                this.cantVida -= daño;
            }
        }
        public void receiveHealth(int health)
        {
            if (health > 0)
            {
                this.cantVida += health;
                MessageBox.Show("Cantidad de vida del " + this.nombre + ": " + this.cantVida);
            }
        }

        public int doAttack() => new Random().Next(atmin, atmax);

        /*Getters and Setters*/
        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public int CantVida
        {
            get => this.cantVida;
            set => this.cantVida = value;
        }
        public Tipo TipoPokemon
        {
            get => this.tipoPokemon;
            set => this.tipoPokemon = value;
        }
        public int CantAtaque
        {
            get => this.cantAtaque;
            set => this.cantAtaque = value;
        }
        public string UrlImage
        {
            get => this.urlImage;
            set => this.urlImage = value;
        }
        public int ATMin
        {
            get => this.atmin;
            set => this.atmin = value;
        }
        public int ATMax
        {
            get => this.atmax;
            set => this.atmax = value;
        }
    }
}
