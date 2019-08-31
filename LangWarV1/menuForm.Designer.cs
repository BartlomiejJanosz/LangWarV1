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
            this.CheckIfSomeoneSetUpAnewGameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // createGameButton
            // 
            this.createGameButton.Enabled = false;
            this.createGameButton.Location = new System.Drawing.Point(43, 174);
            this.createGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createGameButton.Name = "createGameButton";
            this.createGameButton.Size = new System.Drawing.Size(701, 124);
            this.createGameButton.TabIndex = 0;
            this.createGameButton.Text = "Stwórz grę";
            this.createGameButton.UseVisualStyleBackColor = true;
            this.createGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // joinToGameButton
            // 
            this.joinToGameButton.Enabled = false;
            this.joinToGameButton.Location = new System.Drawing.Point(43, 329);
            this.joinToGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.joinToGameButton.Name = "joinToGameButton";
            this.joinToGameButton.Size = new System.Drawing.Size(701, 124);
            this.joinToGameButton.TabIndex = 1;
            this.joinToGameButton.Text = "Dołącz do gry";
            this.joinToGameButton.UseVisualStyleBackColor = true;
            this.joinToGameButton.Click += new System.EventHandler(this.JoinToGameButton_Click);
            // 
            // isConnectedLabel
            // 
            this.isConnectedLabel.AutoSize = true;
            this.isConnectedLabel.Location = new System.Drawing.Point(37, 33);
            this.isConnectedLabel.Name = "isConnectedLabel";
            this.isConnectedLabel.Size = new System.Drawing.Size(93, 32);
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
            this.playerNameTextBox.Location = new System.Drawing.Point(275, 107);
            this.playerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(463, 38);
            this.playerNameTextBox.TabIndex = 3;
            this.playerNameTextBox.TextChanged += new System.EventHandler(this.PlayerNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
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
            this.CheckIfSomeoneJoinedToGameTimer.Interval = 10;
            this.CheckIfSomeoneJoinedToGameTimer.Tick += new System.EventHandler(this.CheckIfSomeoneJoinedToGameTimer_Tick);
            // 
            // CheckIfSomeoneSetUpAnewGameTimer
            // 
            this.CheckIfSomeoneSetUpAnewGameTimer.Enabled = true;
            this.CheckIfSomeoneSetUpAnewGameTimer.Interval = 10;
            this.CheckIfSomeoneSetUpAnewGameTimer.Tick += new System.EventHandler(this.CheckIfSomeoneSetUpAnewGame_Tick);
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.isConnectedLabel);
            this.Controls.Add(this.joinToGameButton);
            this.Controls.Add(this.createGameButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Timer CheckIfSomeoneSetUpAnewGameTimer;
    }
}

