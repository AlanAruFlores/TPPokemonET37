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
    public partial class InicioForm : Form
    {
        static SeleccionForm ventanaSeleccionPokemon;
        public InicioForm()
        {
            InitializeComponent();
        }
         
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0)
            {
                if(txtName.Text.Contains(" ") != true)
                {
                    ventanaSeleccionPokemon = new SeleccionForm();
                    ventanaSeleccionPokemon.establecerPersonaje(txtName.Text);
                    ventanaSeleccionPokemon.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se acepta espacios en blanco", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Su nombre debe tener mas al menos un caracter y maximo 8", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int x, y;

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

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
