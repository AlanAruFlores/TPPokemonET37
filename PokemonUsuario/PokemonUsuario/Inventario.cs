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
    public partial class Inventario : Form
    {
        static Pokemon pokemon;
        static int cantidadPociones = 1;


        static int cantidadPocionesFuerza = 1;

        //Estadisticas
        static Label hp;
        static Label ATMax;
        static Label ATMin;
        public Inventario(Object pokemon,Label hp, Label ATMax, Label ATMin)
        {
            InitializeComponent();
            Inventario.pokemon = (Pokemon)pokemon;
            labelCantidad.Text = cantidadPociones.ToString();
            labelFuerza.Text = cantidadPocionesFuerza.ToString();
            Inventario.hp = hp;
            Inventario.ATMax = ATMax;
            Inventario.ATMin = ATMin;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(labelCantidad.Text);
            if(cantidad > 0)
            {
                pokemon.receiveHealth(10);
                MessageBox.Show("Pokemon del Jugador tiene 10 hp más");
                Inventario.hp.Text = pokemon.CantVida.ToString();
                cantidadPociones--;
                labelCantidad.Text = cantidadPociones.ToString();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            PerspectivaUsuario.cantidadInventario = 1;
            this.Hide();
        }

        private int x, y;

        private void btnPocionFuerza_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(labelFuerza.Text);
            if (cantidad > 0)
            {
                pokemon.upgradeAttack(10,10);
                MessageBox.Show("Incremento la fuerza del pokemon Jugador");
                Inventario.ATMax.Text = pokemon.ATmax.ToString();
                Inventario.ATMin.Text = pokemon.ATmin.ToString();
                cantidadPocionesFuerza--;
                labelFuerza.Text = cantidadPocionesFuerza.ToString();
            }
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
