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

namespace ClientApp
{
    public partial class Home : Form
    {
        int attemps = 0;
        private Socket clientSocket;
        private delegate void btnControl(int t);

        public Home()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txbName.Text != "")
            {
                if (btnConnect.Text == "Connect")
                {
                    lblCheckConnection.Text = "Looking for Server";
                    lblCheckConnection.Visible = true;
                    Thread serverloop = new Thread(new ThreadStart(() => this.ServerLoopConnect(txbName.Text)));
                    serverloop.Start();
                    btnConnect.Text = "Abort";
                }
                else if (btnConnect.Text == "Abort")
                {
                    lblCheckConnection.Visible = false;
                    attemps = 12;
                    btnConnect.Enabled = false;
                    Thread.Sleep(1000);
                    btnConnect.Enabled = true;
                    btnConnect.Text = "Connect";
                }
            }
            else
            {
                MessageBox.Show("Error! Enter Name!!");
            }
        }
        private void ServerLoopConnect(string name)
        {
            attemps = 0;
            while (attemps < 11)
            {
                try
                {
                    attemps++;
                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSocket.Connect(new IPEndPoint(IPAddress.Loopback, 100));
                    if (clientSocket.Connected)
                    {
                        attemps = 100;
                        btnConnect.Invoke(new btnControl(Control), attemps);
                        Thread gameThread = new Thread(new ThreadStart(() => this.gameStart(name)));
                        gameThread.Start();
                    }
                }
                catch(SocketException)
                {
                    try
                    {
                        btnConnect.Invoke(new btnControl(Control), attemps);
                    }
                    catch(Exception ex)
                    {
                        this.Close();
                    }
                }
            }
            
            
        }
        private void Control(int attemp)
        {
            if (attemp == 10)
            {
                btnConnect.Text = "Connect";
                lblCheckConnection.Visible = true;
                lblCheckConnection.Text = "No Server Found! Try Again";
            }
            else if (attemp == 12)
            { }
            else
            {
                lblCheckConnection.Visible = true;
                lblCheckConnection.Text = "Looking for Server..." + attemp + "/10";
            }
            if(attemp == 100)
            {
                btnConnect.Text = "Connect";
                lblCheckConnection.Visible = false;
            }
        }
        private void gameStart(string name)
        {
            Game game = new Game(clientSocket,name);
            game.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            attemps = 12;
            this.Close();
            Application.Exit();
        }
    }
}
