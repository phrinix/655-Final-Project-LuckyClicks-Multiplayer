namespace ServerApp
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.lblYou = new System.Windows.Forms.Label();
            this.lblOpponent = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblVs = new System.Windows.Forms.Label();
            this.lblYouScore = new System.Windows.Forms.Label();
            this.lblScoreOpp = new System.Windows.Forms.Label();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblRulesDes = new System.Windows.Forms.Label();
            this.ucLuckyClicksGame = new LuckyClicks.UCLuckyClicks();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblYou.Location = new System.Drawing.Point(421, 41);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(159, 36);
            this.lblYou.TabIndex = 1;
            this.lblYou.Text = "Characters";
            // 
            // lblOpponent
            // 
            this.lblOpponent.AutoSize = true;
            this.lblOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOpponent.Location = new System.Drawing.Point(690, 41);
            this.lblOpponent.Name = "lblOpponent";
            this.lblOpponent.Size = new System.Drawing.Size(159, 36);
            this.lblOpponent.TabIndex = 2;
            this.lblOpponent.Text = "Characters";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblVs
            // 
            this.lblVs.AutoSize = true;
            this.lblVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVs.Location = new System.Drawing.Point(600, 29);
            this.lblVs.Name = "lblVs";
            this.lblVs.Size = new System.Drawing.Size(73, 51);
            this.lblVs.TabIndex = 4;
            this.lblVs.Text = "Vs";
            // 
            // lblYouScore
            // 
            this.lblYouScore.AutoSize = true;
            this.lblYouScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblYouScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouScore.Location = new System.Drawing.Point(472, 90);
            this.lblYouScore.Name = "lblYouScore";
            this.lblYouScore.Size = new System.Drawing.Size(49, 32);
            this.lblYouScore.TabIndex = 5;
            this.lblYouScore.Text = "00";
            // 
            // lblScoreOpp
            // 
            this.lblScoreOpp.AutoSize = true;
            this.lblScoreOpp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblScoreOpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreOpp.Location = new System.Drawing.Point(749, 90);
            this.lblScoreOpp.Name = "lblScoreOpp";
            this.lblScoreOpp.Size = new System.Drawing.Size(49, 32);
            this.lblScoreOpp.TabIndex = 6;
            this.lblScoreOpp.Text = "00";
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(592, 196);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(97, 29);
            this.lblRules.TabIndex = 8;
            this.lblRules.Text = "RULES";
            // 
            // lblRulesDes
            // 
            this.lblRulesDes.AutoSize = true;
            this.lblRulesDes.Location = new System.Drawing.Point(420, 225);
            this.lblRulesDes.Name = "lblRulesDes";
            this.lblRulesDes.Size = new System.Drawing.Size(431, 119);
            this.lblRulesDes.TabIndex = 9;
            this.lblRulesDes.Text = resources.GetString("lblRulesDes.Text");
            // 
            // ucLuckyClicksGame
            // 
            this.ucLuckyClicksGame.Location = new System.Drawing.Point(12, 41);
            this.ucLuckyClicksGame.Name = "ucLuckyClicksGame";
            this.ucLuckyClicksGame.Size = new System.Drawing.Size(403, 400);
            this.ucLuckyClicksGame.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 461);
            this.Controls.Add(this.lblRulesDes);
            this.Controls.Add(this.lblRules);
            this.Controls.Add(this.lblScoreOpp);
            this.Controls.Add(this.lblYouScore);
            this.Controls.Add(this.lblVs);
            this.Controls.Add(this.lblOpponent);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.ucLuckyClicksGame);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game - Server";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LuckyClicks.UCLuckyClicks ucLuckyClicksGame;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblOpponent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblVs;
        private System.Windows.Forms.Label lblYouScore;
        private System.Windows.Forms.Label lblScoreOpp;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblRulesDes;
    }
}