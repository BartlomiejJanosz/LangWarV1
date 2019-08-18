namespace LangWarV1
{
    partial class battleForm
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
            this.nameOfOpponentPlayerLabel = new System.Windows.Forms.Label();
            this.additionalInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameOfOpponentPlayerLabel
            // 
            this.nameOfOpponentPlayerLabel.AutoSize = true;
            this.nameOfOpponentPlayerLabel.Location = new System.Drawing.Point(290, 101);
            this.nameOfOpponentPlayerLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nameOfOpponentPlayerLabel.Name = "nameOfOpponentPlayerLabel";
            this.nameOfOpponentPlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.nameOfOpponentPlayerLabel.TabIndex = 0;
            this.nameOfOpponentPlayerLabel.Text = "label1";
            // 
            // additionalInfoLabel
            // 
            this.additionalInfoLabel.AutoSize = true;
            this.additionalInfoLabel.Location = new System.Drawing.Point(30, 157);
            this.additionalInfoLabel.Name = "additionalInfoLabel";
            this.additionalInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.additionalInfoLabel.TabIndex = 1;
            this.additionalInfoLabel.Text = "label1";
            // 
            // battleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 338);
            this.Controls.Add(this.additionalInfoLabel);
            this.Controls.Add(this.nameOfOpponentPlayerLabel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "battleForm";
            this.Text = "battleForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.battleForm_FormClosed);
            this.Load += new System.EventHandler(this.BattleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfOpponentPlayerLabel;
        private System.Windows.Forms.Label additionalInfoLabel;
    }
}