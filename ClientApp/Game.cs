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
    public partial class Game : Form
    {
        String Msg;
        Socket clientSocket;
        private delegate void InvokeControl();
        public Game(Socket clientSocket,string name)
        {
            this.clientSocket = clientSocket;
            InitializeComponent();
            LocalInit();
            lblYou.Text = name;
            Thread dataRecieve = new Thread(new ThreadStart(() => this.recieveData(clientSocket)));
            dataRecieve.Start();
            sendData("name," + name);
        }
        private void LocalInit()
        {
            
            for (int i = 0; i < 100; i++)
                ucLuckyClicksGame.tile[i].Click += new System.EventHandler(TileClicked);


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TileClicked(object sender, EventArgs e)
        {
            Button btile = (Button)sender;
            btile.BackColor = Color.AliceBlue;
            btile.Enabled = false;
            sendData("tile," + btile.Name);
        }
        private void recieveData(Socket clientSocket)
        {
            Thread.Sleep(50);
            try
            {
                while (true)
                {
                    byte[] MsgFromServer = new byte[1024];
                    int size = clientSocket.Receive(MsgFromServer);
                    Msg = Encoding.ASCII.GetString(MsgFromServer, 0, size);
                    lblOpponent.Invoke(new InvokeControl(invokeControls));
                }
            }
            catch (Exception ex)
            {
                Msg = "disconnected";
                lblOpponent.Invoke(new InvokeControl(invokeControls));
            }
        }
        private void invokeControls()
        {
            string[] words = Msg.Split(',');
            if (words[0] == "name")
            {
                lblOpponent.Text = words[1];
            }
            if (words[0] == "tile")
            {
                int i = Convert.ToInt32(words[1]);
                ucLuckyClicksGame.tile[i].BackColor = Color.AliceBlue;
                ucLuckyClicksGame.tile[i].Enabled = false;
                if (words[2] == "0")
                {
                    ucLuckyClicksGame.tile[i].Text = "B";
                    ucLuckyClicksGame.tile[i].BackColor = Color.AliceBlue;
                    ucLuckyClicksGame.disable_all_button();
                    MessageBox.Show("You Win!! Opponent Click on Bomb!");
                }
                else
                {
                    ucLuckyClicksGame.tile[i].Text = words[2];
                    lblScoreOpp.Text = Convert.ToString(Convert.ToInt32(lblScoreOpp.Text) + Convert.ToInt32(words[2]));
                }
                

                
                
            }
            if (words[0] == "tileBack")
            {
                int i = Convert.ToInt32(words[1]);
                
                if (words[2] == "0")
                {
                    ucLuckyClicksGame.tile[i].Text = "B";
                }
                else
                {
                    ucLuckyClicksGame.tile[i].Text = words[2];
                    lblYouScore.Text = Convert.ToString(Convert.ToInt32(lblYouScore.Text) + Convert.ToInt32(words[2]));
                }
                
                
                checkYou(words[2]);
            }
            if (Msg == "disconnected")
            {
                MessageBox.Show("lblOpponent left! Closing now!");
                this.Close();
            }

        }
        private void checkYou(string num)
        {
            if (num == "0")
            {
                ucLuckyClicksGame.disable_all_button();
                MessageBox.Show("You clicked on Bomb!! You lose!");


            }
        }

        private void sendData(string data)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(data), 0, data.Length, SocketFlags.None);
        }

        
    }
}
