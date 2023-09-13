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
    public partial class SeleccionForm : Form
    {
        private static ConversacionForm ventanaConversacion;
        public SeleccionForm()
        {
            InitializeComponent();
        }
        
        public void establecerPersonaje(string nombre)
        {
            labelPersonaje.Text = nombre;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void buttonPikachu_Click(object sender, EventArgs e)
        {
            ventanaConversacion = new ConversacionForm();
            ventanaConversacion.Show();
            ventanaConversacion.setPersonaje(labelPersonaje.Text);
            ventanaConversacion.setPokemon("pikachu");
            this.Hide();
        }

        private void buttonTreecko_Click(object sender, EventArgs e)
        {

            ventanaConversacion = new ConversacionForm();
            ventanaConversacion.Show();
            ventanaConversacion.setPersonaje(labelPersonaje.Text);
            ventanaConversacion.setPokemon("treecko");
            this.Hide();
        }

        private void buttonCharizard_Click(object sender, EventArgs e)
        {
            ventanaConversacion = new ConversacionForm();
            ventanaConversacion.Show();
            ventanaConversacion.setPersonaje(labelPersonaje.Text);
            ventanaConversacion.setPokemon("charizard");
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
