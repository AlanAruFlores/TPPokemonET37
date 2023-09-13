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
    public partial class Form1 : Form
    {
        static InicioForm inicioForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            inicioForm = new InicioForm();
            inicioForm.Show();
            this.Hide();
        }
        int x, y;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
