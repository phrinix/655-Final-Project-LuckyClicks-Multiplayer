namespace ClientApp
{
    partial class Home
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
            this.lblCheckConnection = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblLogo2 = new System.Windows.Forms.Label();
            this.lblLogo1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCheckConnection
            // 
            this.lblCheckConnection.AutoSize = true;
            this.lblCheckConnection.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckConnection.Location = new System.Drawing.Point(104, 270);
            this.lblCheckConnection.Name = "lblCheckConnection";
            this.lblCheckConnection.Size = new System.Drawing.Size(163, 23);
            this.lblCheckConnection.TabIndex = 12;
            this.lblCheckConnection.Text = "Looking for Server...";
            this.lblCheckConnection.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(134, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 49);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(134, 302);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 49);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(51, 192);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(292, 33);
            this.lblEnterName.TabIndex = 9;
            this.lblEnterName.Text = "Enter Your Gaming Name";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(83, 239);
            this.txbName.MaxLength = 10;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(211, 28);
            this.txbName.TabIndex = 6;
            // 
            // lblLogo2
            // 
            this.lblLogo2.AutoSize = true;
            this.lblLogo2.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo2.ForeColor = System.Drawing.Color.Blue;
            this.lblLogo2.Location = new System.Drawing.Point(74, 81);
            this.lblLogo2.Name = "lblLogo2";
            this.lblLogo2.Size = new System.Drawing.Size(215, 49);
            this.lblLogo2.TabIndex = 10;
            this.lblLogo2.Text = "Multiplayer";
            // 
            // lblLogo1
            // 
            this.lblLogo1.AutoSize = true;
            this.lblLogo1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo1.ForeColor = System.Drawing.Color.Red;
            this.lblLogo1.Location = new System.Drawing.Point(47, 23);
            this.lblLogo1.Name = "lblLogo1";
            this.lblLogo1.Size = new System.Drawing.Size(282, 58);
            this.lblLogo1.TabIndex = 11;
            this.lblLogo1.Text = "Lucky Clicks";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.lblCheckConnection);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblLogo2);
            this.Controls.Add(this.lblLogo1);
            this.Name = "Home";
            this.Text = "Home - Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCheckConnection;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblLogo2;
        private System.Windows.Forms.Label lblLogo1;
    }
}

