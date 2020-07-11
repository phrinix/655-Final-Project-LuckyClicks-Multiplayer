using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;


namespace ServerApp
{
    public partial class Home : Form
    {
        bool exit = false;
        bool connect = false;
        private Socket clientsSocket = default(Socket);
        private Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Socket clientSocket;
        private Thread serverThread;
        private delegate void btnControl();

        public Home()
        {
            InitializeComponent();
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txbName.Text != "")
            {
                if (btnConnect.Text == "Connect")
                {
                    lblCheckConnection.Visible = true;
                    btnConnect.Text = "Abort";
                    serverThread = new Thread(new ThreadStart(() => this.SetupServer(txbName.Text)));
                    serverThread.Start();
                }
                else if (btnConnect.Text == "Abort")
                {
                    exit = true;
                    if (connect == true)
                    {
                        lblCheckConnection.Visible = false;
                        clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        clientSocket.Connect(new IPEndPoint(IPAddress.Loopback, 100));
                    }
                    btnConnect.Text = "Connect";
                }
            }
            else
            {
                MessageBox.Show("Error! Enter Name!!");
            }
}
        private void SetupServer(String name)
        {
            try
            {
                connect = true;
                serverSocket.Listen(1);
                clientsSocket = serverSocket.Accept();
                connect = false;
                if (exit == false)
                {
                    Thread gameThread = new Thread(new ThreadStart(() => this.gameStart(clientsSocket, name)));
                    gameThread.Start();
                    btnConnect.Invoke(new btnControl(enableButton));
                }
                exit = false;
            }
            catch (ThreadAbortException ex)
            {
 
            }
        }
        private void enableButton()
        {
            btnConnect.Text = "Connect";
            lblCheckConnection.Visible = false;
 
        }
        private void gameStart(Socket clientSocket, String name)
        {
            Game game = new Game(clientSocket, name);
            game.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exit = true;
            if (connect == true)
            {
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                clientSocket.Connect(new IPEndPoint(IPAddress.Loopback, 100));
            }
            this.Close();
            Application.Exit();
        }
    }
}
