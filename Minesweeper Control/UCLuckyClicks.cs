using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuckyClicks
{
    public partial class UCLuckyClicks: UserControl
    {
        public Button[] tile;
        public UCLuckyClicks()
        {
            InitializeComponent();
            LocalInit();

        }
        private void LocalInit()
        {
            int r = 0;
            int c = 0;
            tile = new Button[100];
            for (int i = 0; i < 100; i++)
            {
                tile[i] = new System.Windows.Forms.Button();
                tile[i].Width = 40;
                tile[i].Height = 40;
                tile[i].TabStop = false;
                tile[i].Name = Convert.ToString(i);
                if (c == 10)
                {
                    c = 0;
                    r++;
                }
                TLPGame.Controls.Add(tile[i], r, c);
                c++;
                tile[i].Click += new System.EventHandler(tile_Click);
            }
        }
        public void tile_Click(object sender, EventArgs e)
        {
            Button btile = (Button)sender;
        }
        public void disable_all_button()
        {
            for (int i = 0; i < 100; i++)
            {
                tile[i].BackColor = Color.AliceBlue;
                tile[i].Enabled = false;
            }
        }
    }
}
