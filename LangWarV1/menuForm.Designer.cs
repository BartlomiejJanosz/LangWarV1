namespace LangWarV1
{
    partial class menuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createGameButton = new System.Windows.Forms.Button();
            this.joinToGameButton = new System.Windows.Forms.Button();
            this.isConnectedLabel = new System.Windows.Forms.Label();
            this.isConnectedTimer = new System.Windows.Forms.Timer(this.components);
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.waitForOtherPlayerTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckIfSomeoneJoinedToGameTimer = new System.Windows.Forms.Timer(this.components);
            this.CheckIfSomeoneSetUpAnewGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // createGameButton
            // 
            this.createGameButton.Enabled = false;
            this.createGameButton.Location = new System.Drawing.Point(16, 73);
            this.createGameButton.Margin = new System.Windows.Forms.Padding(1);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(263, 52);
            this.createGameButton.TabIndex = 0;
            this.createGameButton.Text = "Stwórz grę";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // joinToGameButton
            // 
            this.joinToGameButton.Enabled = false;
            this.joinToGameButton.Location = new System.Drawing.Point(16, 138);
            this.joinToGameButton.Margin = new System.Windows.Forms.Padding(1);
            this.joinToGameButton.Name = "joinToGameButton";
            this.joinToGameButton.Size = new System.Drawing.Size(263, 52);
            this.joinToGameButton.TabIndex = 1;
            this.joinToGameButton.Text = "Dołącz do gry";
            this.joinToGameButton.UseVisualStyleBackColor = true;
            this.joinToGameButton.Click += new System.EventHandler(this.JoinToGameButton_Click);
            // 
            // isConnectedLabel
            // 
            this.isConnectedLabel.AutoSize = true;
            this.isConnectedLabel.Location = new System.Drawing.Point(14, 14);
            this.isConnectedLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.isConnectedLabel.Name = "isConnectedLabel";
            this.isConnectedLabel.Size = new System.Drawing.Size(35, 13);
            this.isConnectedLabel.TabIndex = 2;
            this.isConnectedLabel.Text = "label1";
            // 
            // isConnectedTimer
            // 
            this.isConnectedTimer.Enabled = true;
            this.isConnectedTimer.Tick += new System.EventHandler(this.IsConnectedTimer_Tick);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(103, 45);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(176, 20);
            this.playerNameTextBox.TabIndex = 3;
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.PlayerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NazwaGracza";
            // 
            // waitForOtherPlayerTimer
            // 
            this.waitForOtherPlayerTimer.Interval = 1000;
            this.waitForOtherPlayerTimer.Tick += new System.EventHandler(this.WaitForOtherPlayerTimer_Tick);
            // 
            // CheckIfSomeoneJoinedToGameTimer
            // 
            this.CheckIfSomeoneJoinedToGameTimer.Tick += new System.EventHandler(this.CheckIfSomeoneJoinedToGameTimer_Tick);
            // 
            // CheckIfSomeoneSetUpAnewGame
            // 
            this.CheckIfSomeoneSetUpAnewGame.Enabled = true;
            this.CheckIfSomeoneSetUpAnewGame.Tick += new System.EventHandler(this.CheckIfSomeoneSetUpAnewGame_Tick);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.isConnectedLabel);
            this.Controls.Add(this.joinToGameButton);
            this.Controls.Add(this.createGameButton);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "menuForm";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.menuForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createGameButton;
        private System.Windows.Forms.Button joinToGameButton;
        private System.Windows.Forms.Label isConnectedLabel;
        private System.Windows.Forms.Timer isConnectedTimer;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer waitForOtherPlayerTimer;
        private System.Windows.Forms.Timer CheckIfSomeoneJoinedToGameTimer;
        private System.Windows.Forms.Timer CheckIfSomeoneSetUpAnewGame;
    }
}

