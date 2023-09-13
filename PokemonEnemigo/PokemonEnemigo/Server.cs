using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace PokemonEnemigo
{
    class Server
    {
        Socket socketServer;
        Socket socketCliente;
        Trainer trainer;
        Pokemon pokemonCharmander = new Charmander();
        static int healthPlayerPokemon = 0;

        static Label hp;
        static Label ATMax;
        static Label ATMin;

        public Server(Label hp, Label atmax, Label atmin)
        {
            getConnection();
            this.trainer = new Trainer();
            receivePokemon();
            sendHealthPokemon();
            receiveHealthPokemonPlayer();
            Server.hp = hp;
            Server.ATMax = atmax;
            Server.ATMin = atmin;
            setLabelsDefault();
        }
        private void setLabelsDefault()
        {
            Server.hp.Text = this.MiPokemon.CantVida.ToString();
            Server.ATMax.Text = this.MiPokemon.ATMax.ToString();
            Server.ATMin.Text = this.MiPokemon.ATMin.ToString();
        }

        public void getConnection()
        {
            this.socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint address = new IPEndPoint(IPAddress.Any, 4044);
            try
            {
                this.socketServer.Bind(address);
                this.socketServer.Listen(1);
                this.socketCliente = socketServer.Accept();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void receivePokemon()
        {
            byte[] arraySprite = new byte[255];
            int cantBytes = socketCliente.Receive(arraySprite, 0, arraySprite.Length, 0);
            Array.Resize(ref arraySprite, cantBytes);
            string urlSpritePokemon = Encoding.Default.GetString(arraySprite);
            Form1.sprite = urlSpritePokemon;
        }

        public void attackEnemy()
        {
            string attackMessage = "" + pokemonCharmander.doAttack();
            MessageBox.Show("El enemigo hizo " + attackMessage + " de ataque al jugador");
            byte[] aBytesTrainer = Encoding.Default.GetBytes(attackMessage);
            socketCliente.Send(aBytesTrainer);
            receiveHealthPokemonPlayer();
            seeingHisHealth();
        }
        public void receiveAttack()
        {
            byte[] aBytes = new byte[255];
            int cantBytes = socketCliente.Receive(aBytes, 0, aBytes.Length, 0);
            Array.Resize(ref aBytes, cantBytes);

            string messageReceive = Encoding.Default.GetString(aBytes);
            int attackReceive = int.Parse(messageReceive);
            pokemonCharmander.receiveAttack(attackReceive);
            Server.hp.Text = pokemonCharmander.CantVida.ToString();
            sendHealthPokemon();
            seeingMyHealth();
        }

        public void sendHealthPokemon()
        {
            byte[] abytes = Encoding.Default.GetBytes(pokemonCharmander.CantVida.ToString());
            socketCliente.Send(abytes);

        }
        public void receiveHealthPokemonPlayer()
        {
            byte[] abytes = new byte[255];
            int cantbytes = socketCliente.Receive(abytes, 0, abytes.Length, 0);
            Array.Resize(ref abytes, cantbytes);
            healthPlayerPokemon = int.Parse(Encoding.Default.GetString(abytes));
        }


        public void seeingMyHealth()
        {
            if (pokemonCharmander.CantVida <= 0)
            {
                MessageBox.Show("La partida termino");
                Form1.partidaTerminada = true;
                Form1.perdio = true;
            }
        }
        public void seeingHisHealth()
        {
            if (healthPlayerPokemon <= 0)
            {
                Form1.partidaTerminada = true;
                Form1.gano = true;
            }
        }

        public void closeConnection()
        {
            socketCliente.Close();
            socketServer.Close();
        }


        public Pokemon MiPokemon
        {
            get => this.pokemonCharmander;
            set => this.pokemonCharmander = value;
        }
    }
}
