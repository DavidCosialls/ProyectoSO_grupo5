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
    public partial class Consultas : Form
    {
        Socket server;

        public Consultas()
        {
            InitializeComponent();
            if (this.BackColor != Color.Green)
                SendButton.Enabled = false; 
        }

        private void Consultas_Load(object sender, EventArgs e)
        {
            Login l = new Login();
            
            this.CenterToScreen();

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor
            //al que deseamos conectarnos

            IPAddress direc = IPAddress.Parse("192.168.56.101");//DireccionIP de la Maquina Virtual
            IPEndPoint ipep = new IPEndPoint(direc, 9030); //Le pasamos el acceso y el puerto que asignamos en el codigo del servidor

            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//Parámetros estándard
            try
            {
                server.Connect(ipep); //Intentamos conectar el socket
                this.BackColor = Color.Green;
                SendButton.Enabled = true;
                //MessageBox.Show("conectado");
            }
            catch (SocketException ex)
            {
                //Si hay excepción imprimimos error y salimos del programa con return
                MessageBox.Show("No se ha podido conectar con el servidor");
                return;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
                if(GamesWonButton.Checked)
                {

                     
                    string mensaje = "1/" + UsernameBox.Text;
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
                    

                    MessageBox.Show("El numero de partidas ganadas por el usuario son: " + mensaje);
                }

                if(MoreGamesButton.Checked)
                {

                    
                    string mensaje1 = "2/ALGO";
                    //Envimos al servidor el nombre tecleado
                    //Cogemos el string creado y lo convertimos en un vector de Bytes
                    byte[] msg3 = System.Text.Encoding.ASCII.GetBytes(mensaje1);
                    server.Send(msg3);
                    byte[] msg4 = new byte[30];
                    server.Receive(msg4);
                    mensaje1 = Encoding.ASCII.GetString(msg4).Split('\0')[0]; //El split sirve para quedarme solo con el string que quiero
                    //lo demás se considera basura

                    

                    MessageBox.Show("El dia que se han jugado mas partidas es: " + mensaje1);

                }

                if(PlayersListButton.Checked)
                {

                    
                    string mensaje = "3/1/IDMAX";
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

                    

                    int i = 1;

                    while (i <= Convert.ToInt32(mensaje))
                    {
                       

                        string istr = Convert.ToString(i);
                        string message = "15/"+ istr;
                        //Envimos al servidor el nombre tecleado
                        //Cogemos el string creado y lo convertimos en un vector de Bytes
                        msg = System.Text.Encoding.ASCII.GetBytes(message);
                        
                        server.Send(msg);

                        //Recibimos la respuesta del servidor
                        //Recibimos un vector de bytes y lo convertimos a string
                        msg2 = new byte[30];
                        server.Receive(msg2);
                        message = Encoding.ASCII.GetString(msg2).Split('\0')[0]; //El split sirve para quedarme solo con el string que quiero
                        //lo demás se considera basura

                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = message;
                        dataGridView1.Rows[n].Cells[1].Value = istr;
                        dataGridView1.Refresh();

                        i++;

                        

                        
                    }

                }

        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            this.BackColor = Color.Gray;
            SendButton.Enabled = false;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
        }
    }

