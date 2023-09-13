using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonEnemigo
{
    public partial class Inventario : Form
    {
        static Charmander charmander;
        static int cantidadPociones = 1;
        static int cantidadPocionesFuerza = 1;

        static Label hp;
        static Label ATMax;
        static Label ATMin;
        public Inventario(Object charmander, Label hp, Label ATMax, Label ATMin)
        {
            InitializeComponent();
            labelCantidad.Text = cantidadPociones.ToString();
            labelFuerza.Text = cantidadPocionesFuerza.ToString();
            Inventario.hp = hp;
            Inventario.ATMax = ATMax;
            Inventario.ATMin = ATMin;

            Inventario.charmander = (Charmander)charmander;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(labelCantidad.Text);
            if (cantidad > 0)
            {
                charmander.receiveHealth(10);
                MessageBox.Show("Pokemon del Jugador tiene 10 hp más");
                Inventario.hp.Text = charmander.CantVida.ToString();
                cantidadPociones--;
                labelCantidad.Text = cantidadPociones.ToString();
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Form1.cantInventario = 1;
            this.Hide();

        }

        private int x, y;

        private void btnPocionFuerza_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(labelFuerza.Text);
            if (cantidad > 0)
            {
                charmander.upgradeAttack(10, 10);
                MessageBox.Show("Incremento la fuerza del pokemon Jugador");
                Inventario.ATMax.Text = charmander.ATMax.ToString();
                Inventario.ATMin.Text = charmander.ATMin.ToString();
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
