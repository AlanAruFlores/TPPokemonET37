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
    public partial class Form1 : Form
    {
        static Server server;
        public static bool boolAttack;
        public static bool boolReceive;
        public static bool comienzo;
        public static string sprite;

        public static bool partidaTerminada = false;
        public static int enviarNotificacion = 1;
        public static bool gano = false;
        public static bool perdio = false;

        static Inventario miInventario;
        public static int cantInventario = 1;

        public Form1()
        {
            InitializeComponent();
            server = new Server(labelHP,labelATMaximo,labelATMinimo);
            boolAttack = true;
            boolReceive = false;
            comienzo = true;
            this.labelAnuncio.Text = "Tu turno";
            pictureBox2.Image = Image.FromFile(sprite);
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if(partidaTerminada != true)
            {
                if (boolAttack == true)
                {
                    server.attackEnemy();
                    boolAttack = false;
                    boolReceive = true;
                    btnAtacar.Enabled = false;
                    btnInventario.Enabled = false;
                    this.labelAnuncio.Text = "Espere el turno del Jugador";
                }
                else
                {
                    MessageBox.Show("No puede atacar, no es su turno todavia");
                }
            }
            else
            {
                MessageBox.Show("La partida termino");
            }


        }

        int x, y;



        private void bunifuThinButton21_MouseMove(object sender, EventArgs e)
        {


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (partidaTerminada != true)
            {
                if (boolReceive == true)
                {
                    this.labelAnuncio.Text = "Espere el turno del Jugador";
                    btnAtacar.Enabled = false;
                    btnInventario.Enabled = false;
                    server.receiveAttack();
                    boolReceive = false;
                    boolAttack = true;
                    //this.labelAnuncio.Text = "Tu turno";
                }
                else
                {
                    this.labelAnuncio.Text = "Tu turno";
                    btnAtacar.Enabled = true;
                    btnInventario.Enabled = true;
                }
            }
            else
            {
                if (enviarNotificacion == 1)
                {
                    if (gano == true)
                        labelAnuncio.Text = "Ganaste al Jugador";
                    else
                        labelAnuncio.Text = "Perdio contra el Jugador";
                    enviarNotificacion--;
                    server.closeConnection();
                }
            }
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            if (partidaTerminada != true)
            {
                if (boolAttack == true && cantInventario == 1)
                {
                    miInventario = new Inventario(server.MiPokemon, labelHP, labelATMaximo,
                        labelATMinimo);
                    miInventario.Show();
                    cantInventario = 0;
                }
                else if(cantInventario != 1)
                {
                    MessageBox.Show("No puede tener 2 o mas ventanas");
                }
                else
                {
                    MessageBox.Show("No puede abrir el inventario, no es su turno aun");
                }

            }


            else
            {
                MessageBox.Show("La partida termino");
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
