namespace ServerApp
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
            this.lblLogo1 = new System.Windows.Forms.Label();
            this.lblLogo2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCheckConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogo1
            // 
            this.lblLogo1.AutoSize = true;
            this.lblLogo1.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo1.ForeColor = System.Drawing.Color.Red;
            this.lblLogo1.Location = new System.Drawing.Point(41, 27);
            this.lblLogo1.Name = "lblLogo1";
            this.lblLogo1.Size = new System.Drawing.Size(282, 58);
            this.lblLogo1.TabIndex = 4;
            this.lblLogo1.Text = "Lucky Clicks";
            // 
            // lblLogo2
            // 
            this.lblLogo2.AutoSize = true;
            this.lblLogo2.Font = new System.Drawing.Font("Jokerman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo2.ForeColor = System.Drawing.Color.Blue;
            this.lblLogo2.Location = new System.Drawing.Point(76, 85);
            this.lblLogo2.Name = "lblLogo2";
            this.lblLogo2.Size = new System.Drawing.Size(215, 49);
            this.lblLogo2.TabIndex = 4;
            this.lblLogo2.Text = "Multiplayer";
            // 
            // txbName
            // 
            this.txbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbName.Location = new System.Drawing.Point(85, 243);
            this.txbName.MaxLength = 10;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(211, 28);
            this.txbName.TabIndex = 0;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.Location = new System.Drawing.Point(53, 196);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(292, 33);
            this.lblEnterName.TabIndex = 4;
            this.lblEnterName.Text = "Enter Your Gaming Name";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(136, 306);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 49);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(136, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCheckConnection
            // 
            this.lblCheckConnection.AutoSize = true;
            this.lblCheckConnection.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckConnection.Location = new System.Drawing.Point(92, 274);
            this.lblCheckConnection.Name = "lblCheckConnection";
            this.lblCheckConnection.Size = new System.Drawing.Size(204, 23);
            this.lblCheckConnection.TabIndex = 5;
            this.lblCheckConnection.Text = "Looking for connection....";
            this.lblCheckConnection.Visible = false;
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
            this.Text = "Home - Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogo1;
        private System.Windows.Forms.Label lblLogo2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCheckConnection;
    }
}

