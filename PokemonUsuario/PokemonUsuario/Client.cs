using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace PokemonUsuario
{
    class Client
    {
        Socket myClient;
        Personaje player;
        Pokemon pokemon;
        static int healthPokemonEnemy=0;

        public static Label hp;
        public static Label ATMax;
        public static Label ATMin;

        public Client(Personaje player, Pokemon pokemonSeleccionado, Label hp, Label ATMax, Label ATMin)
        {
            this.player = player;
            this.pokemon = pokemonSeleccionado;
            getConnection();
            sendSprite();
            receiveHealthPokemonEnemy();
            sendHealthPokemon();
            Client.hp = hp;
            Client.ATMax = ATMax;
            Client.ATMin = ATMin;
            setLabelsDefault();
        }
        private void setLabelsDefault()
        {
            Client.hp.Text = this.pokemon.CantVida.ToString();
            Client.ATMax.Text = this.pokemon.ATmax.ToString();
            Client.ATMin.Text = this.pokemon.ATmin.ToString();
        }
        public void getConnection()
        {
            myClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint address = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4044);
            try
            {
                myClient.Connect(address);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void sendSprite()
        {
            byte[] aBytes = Encoding.Default.GetBytes(pokemon.UrlImage);
            myClient.Send(aBytes);
        }

        public void attackEnemy()
        {
            string sendAttack = "" + pokemon.doAttack();
            MessageBox.Show("El jugador hizo " + sendAttack + " de ataque al enemigo");
            byte[] abytes = Encoding.Default.GetBytes(sendAttack);
            myClient.Send(abytes);
            receiveHealthPokemonEnemy();
            seeingHisHealth();

        }
        public void receiveAttack()
        {
            byte[] bytesRecibidos = new byte[255];
            int cantBytes = myClient.Receive(bytesRecibidos, 0, bytesRecibidos.Length, 0);
            Array.Resize(ref bytesRecibidos, cantBytes);
            string messageReceive = Encoding.Default.GetString(bytesRecibidos);
            int attackReceive = int.Parse(messageReceive);
            pokemon.receiveAttack(attackReceive);
            Client.hp.Text = pokemon.CantVida.ToString();
            sendHealthPokemon();
            seeingMyHealth();
        }


        public void sendHealthPokemon()
        {
            byte[] abytes = Encoding.Default.GetBytes(pokemon.CantVida.ToString());
            myClient.Send(abytes);
        }
        public void receiveHealthPokemonEnemy()
        {
            byte[] abytes = new byte[255];
            int cantbytes = myClient.Receive(abytes, 0, abytes.Length, 0);
            Array.Resize(ref abytes, cantbytes);
            healthPokemonEnemy = int.Parse(Encoding.Default.GetString(abytes));

        }
    
        public void seeingHisHealth()
        {
            if (healthPokemonEnemy <= 0)
            {
                MessageBox.Show(player.NombrePersonaje + " gano la partida");
                PerspectivaUsuario.partidaTerminada = true;
                PerspectivaUsuario.gano = true;
            }
        }
        public void seeingMyHealth()
        {
            if (pokemon.CantVida <= 0)
            {
                MessageBox.Show("La partida termino");
                PerspectivaUsuario.partidaTerminada = true;
                PerspectivaUsuario.perdio = true;
            }
        }


        public void closeConnection()
        {
            myClient.Close();
        }


        public Pokemon MiPokemon
        {
            get => this.pokemon;
            set => this.pokemon = value;
        }
    }
}
