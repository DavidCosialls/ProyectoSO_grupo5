namespace Version1
{
    partial class Consultas
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
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.GamesWonButton = new System.Windows.Forms.RadioButton();
            this.MoreGamesButton = new System.Windows.Forms.RadioButton();
            this.PlayersListButton = new System.Windows.Forms.RadioButton();
            this.SendButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username of the player you want to know about:\r\n(Only necessary for the first con" +
                "sultation)";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(311, 91);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(183, 20);
            this.UsernameBox.TabIndex = 1;
            this.UsernameBox.Text = "g";
            // 
            // GamesWonButton
            // 
            this.GamesWonButton.AutoSize = true;
            this.GamesWonButton.Location = new System.Drawing.Point(311, 140);
            this.GamesWonButton.Name = "GamesWonButton";
            this.GamesWonButton.Size = new System.Drawing.Size(84, 17);
            this.GamesWonButton.TabIndex = 2;
            this.GamesWonButton.TabStop = true;
            this.GamesWonButton.Text = "Games won ";
            this.GamesWonButton.UseVisualStyleBackColor = true;
            // 
            // MoreGamesButton
            // 
            this.MoreGamesButton.AutoSize = true;
            this.MoreGamesButton.Location = new System.Drawing.Point(311, 164);
            this.MoreGamesButton.Name = "MoreGamesButton";
            this.MoreGamesButton.Size = new System.Drawing.Size(202, 17);
            this.MoreGamesButton.TabIndex = 3;
            this.MoreGamesButton.TabStop = true;
            this.MoreGamesButton.Text = "Day that more games have been won";
            this.MoreGamesButton.UseVisualStyleBackColor = true;
            // 
            // PlayersListButton
            // 
            this.PlayersListButton.AutoSize = true;
            this.PlayersListButton.Location = new System.Drawing.Point(311, 188);
            this.PlayersListButton.Name = "PlayersListButton";
            this.PlayersListButton.Size = new System.Drawing.Size(191, 17);
            this.PlayersListButton.TabIndex = 4;
            this.PlayersListButton.TabStop = true;
            this.PlayersListButton.Text = "Players registered in the application";
            this.PlayersListButton.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(372, 222);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 5;
            this.SendButton.Text = "SEND";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(72, 33);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 6;
            this.ConnectButton.Text = "CONNECT";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(152, 33);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(88, 23);
            this.DisconnectButton.TabIndex = 7;
            this.DisconnectButton.Text = "DISCONNECT";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Id});
            this.dataGridView1.Location = new System.Drawing.Point(32, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 290);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.PlayersListButton);
            this.Controls.Add(this.MoreGamesButton);
            this.Controls.Add(this.GamesWonButton);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.Name = "Consultas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.RadioButton GamesWonButton;
        private System.Windows.Forms.RadioButton MoreGamesButton;
        private System.Windows.Forms.RadioButton PlayersListButton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}

