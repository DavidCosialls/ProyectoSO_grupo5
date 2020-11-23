using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Version1
{
    public partial class Login : Form
    {
        Socket server;
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
            this.CenterToScreen();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string pwd = textBox2.Text;


            IPAddress direc = IPAddress.Parse("192.168.56.101");//DireccionIP de la Maquina Virtual
            IPEndPoint ipep = new IPEndPoint(direc, 9030); //Le pasamos el acceso y el puerto que asignamos en el codigo del servidor

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//Parámetros estándard
            try
            {
                server.Connect(ipep); //Intentamos conectar el socket
                this.BackColor = Color.Green;
                //MessageBox.Show("conectado");
            }
            catch (SocketException ex)
            {
                //Si hay excepción imprimimos error y salimos del programa con return
                MessageBox.Show("No se ha podido conectar con el servidor");
                return;
            }


            string mensaje = "4/" + usuario;
            //Envimos al servidor el nombre tecleado
            //Cogemos el string creado y lo convertimos en un vector de Bytes
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Recibimos la respuesta del servidor
            //Recibimos un vector de bytes y lo convertimos a string
            byte[] msg2 = new byte[30];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0]; //El split sirve para quedarme solo con el string que quiero
            //lo demás se considera basura
            if (pwd == mensaje)
            {
                MessageBox.Show("Log in Correcto");

                //Mensaje de desconexión
                mensaje = "0/";

                msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);

                //Nos desconectamos
                this.BackColor = Color.Gray;
                server.Shutdown(SocketShutdown.Both);
                server.Close();

                Consultas consulta = new Consultas();
                consulta.ShowDialog();


            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                textBox2.Text = " "; 

            }
                

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
