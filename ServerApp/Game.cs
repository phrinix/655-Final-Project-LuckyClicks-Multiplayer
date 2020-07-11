using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace ServerApp
{
    public partial class Game : Form
    {
        Socket clientSocket;
        private int[] pointArry = new int[100];
        private delegate void InvokeControl();
        String Msg;
        public Game(Socket clientSocket, String name)
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
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                ucLuckyClicksGame.tile[i].Click += new System.EventHandler(TileClicked);
                pointArry[i] = rnd.Next(1, 4);
            }
            for (int i = 0; i < 10; i++)
            {
                int i2 = rnd.Next(0, 99);
                pointArry[i2] = 0;
            }

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
            int num = Convert.ToInt32(btile.Name);
            if (0 == pointArry[num])
            {
                btile.Text = "B";
                sendData("tile," + btile.Name+ ","+ Convert.ToString(pointArry[num]));
                ucLuckyClicksGame.disable_all_button();
                MessageBox.Show("You clicked on Bomb!! You lose!");
            }
            else
            {
                btile.Text = pointArry[num].ToString();
                sendData("tile," + btile.Name + "," + Convert.ToString(pointArry[num]));
                lblYouScore.Text = (Convert.ToInt32(lblYouScore.Text) + pointArry[num]).ToString();
            }
            
        }
        
        private void recieveData(Socket clientSocket)
        {
            Thread.Sleep(50);
            try
            {
                while (true)
                {
                    byte[] MsgFromClient = new byte[1024];
                    int size = clientSocket.Receive(MsgFromClient);
                    Msg = Encoding.ASCII.GetString(MsgFromClient, 0, size);
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
                int num = Convert.ToInt32(words[1]);
                ucLuckyClicksGame.tile[num].BackColor = Color.AliceBlue;
                ucLuckyClicksGame.tile[num].Enabled = false;
                checkOpp(num);
            }
            if (Msg == "disconnected")
            {
                MessageBox.Show("lblOpponent left! Closing now!");
                this.Close();
            }
        }
        private void checkOpp(int num)
        {
            if (pointArry[num] == 0)
            {
                ucLuckyClicksGame.tile[num].Text = "B";
                ucLuckyClicksGame.disable_all_button();
                MessageBox.Show("You Win!! Opponent Click on Bomb!");
                

            }
            else
            {
                ucLuckyClicksGame.tile[num].Text = pointArry[num].ToString();
                lblScoreOpp.Text = Convert.ToString(Convert.ToInt32(lblScoreOpp.Text) + pointArry[num]);
            }
            sendData("tileBack," +Convert.ToString(num)+","+pointArry[num].ToString());
        }
        private void sendData(string data)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(data), 0, data.Length, SocketFlags.None);
        }
    }
}
