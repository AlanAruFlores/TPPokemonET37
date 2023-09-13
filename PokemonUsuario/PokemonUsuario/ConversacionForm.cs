using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonUsuario
{
    public partial class ConversacionForm : Form
    {
        static PerspectivaUsuario usuarioBattle;
        private string nombreJugador;
        private Pokemon pokemonSeleccionado;
        public ConversacionForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void setPersonaje(string name)
        {
            this.nombreJugador = name;
        }
        public void setPokemon(string name) {

            if (name.Contains("pikachu"))
            {
                this.pokemonSeleccionado = new Pikachu();
            } else if (name.Contains("treecko"))
            {
                this.pokemonSeleccionado = new Treecko();
            }
            else
            {
                this.pokemonSeleccionado = new Charmander();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            usuarioBattle = new PerspectivaUsuario(nombreJugador, pokemonSeleccionado);
            usuarioBattle.Show();
            this.Hide();
        }

        int x, y;

        private void panelInicio_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                this.Left += e.X - x;
                this.Top += e.Y - y;
            }
        }
    }
}
