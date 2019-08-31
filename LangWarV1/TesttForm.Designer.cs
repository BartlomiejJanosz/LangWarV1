namespace LangWarV1
{
    partial class TesttForm
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
            this.AddBattleInfoToTableButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddBattleInfoToTableButton
            // 
            this.AddBattleInfoToTableButton.Location = new System.Drawing.Point(557, 226);
            this.AddBattleInfoToTableButton.Name = "AddBattleInfoToTableButton";
            this.AddBattleInfoToTableButton.Size = new System.Drawing.Size(339, 108);
            this.AddBattleInfoToTableButton.TabIndex = 0;
            this.AddBattleInfoToTableButton.Text = "Dodaj BattleInfo";
            this.AddBattleInfoToTableButton.UseVisualStyleBackColor = true;
            this.AddBattleInfoToTableButton.Click += new System.EventHandler(this.AddBattleInfoToTableButton_Click);
            // 
            // TesttForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 615);
            this.Controls.Add(this.AddBattleInfoToTableButton);
            this.Name = "TesttForm";
            this.Text = "TesttForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBattleInfoToTableButton;
    }
}