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
    public partial class PerspectivaUsuario : Form
    {
        public static bool boolAttack;
        public static bool boolReceive;

        static Client cliente;
        static Inventario miInventario;

        public static bool partidaTerminada;
        static int enviarNotificacion = 1;
        public static bool gano = false;
        public static bool perdio = false;

        public static int cantidadInventario = 1;
        public PerspectivaUsuario(string nombre,Object pokemon)
        {
            InitializeComponent();
            boolAttack = false;
            boolReceive = true;
            cliente = new Client(new Personaje(nombre),(Pokemon)pokemon,labelHP, labelATMaximo, labelATMinimo);
            labelAnuncio.Text = "Espere el turno del Enemigo";
            pictureBox1.Image = Image.FromFile(cliente.MiPokemon.UrlImage);
            PerspectivaUsuario.partidaTerminada = false;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if(partidaTerminada != true)
            {
                if (boolAttack == true)
                {
                    cliente.attackEnemy();
                    boolAttack = false;
                    boolReceive = true;
                    btnAtacar.Enabled = false;
                    btnInventario.Enabled = false;
                    this.labelAnuncio.Text = "Espere el turno del Enemigo";

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


        private void PerspectivaUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if(partidaTerminada != true)
            {
                if (boolReceive == true)
                {
                    this.labelAnuncio.Text = "Espere el turno del Enemigo";
                    btnAtacar.Enabled = false;
                    btnInventario.Enabled = false;
                    cliente.receiveAttack();
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
                if(enviarNotificacion == 1)
                {
                    if (gano == true)
                        labelAnuncio.Text = "Ganaste";
                    if (perdio == true)
                        labelAnuncio.Text = "Usted perdio";
                    enviarNotificacion--;
                    cliente.closeConnection();
                }
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int x, y;

        private void buttonBag_Click(object sender, EventArgs e)
        {
          if (partidaTerminada != true)
          {
                if(boolAttack == true && cantidadInventario == 1)
                {
                    miInventario = new Inventario(cliente.MiPokemon, labelHP,labelATMaximo,
                        labelATMinimo);
                    miInventario.Show();
                    cantidadInventario = 0;
                }
                else if(cantidadInventario != 1)
                {
                    MessageBox.Show("No se puede abrir 2 o mas ventanas");
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
