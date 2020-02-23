namespace WFTicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Standartlabel = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.EndLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayerXlabel = new System.Windows.Forms.Label();
            this.PlayerOlabel = new System.Windows.Forms.Label();
            this.ZeroScoreBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Standartlabel
            // 
            this.Standartlabel.AutoSize = true;
            this.Standartlabel.Location = new System.Drawing.Point(481, 28);
            this.Standartlabel.Name = "Standartlabel";
            this.Standartlabel.Size = new System.Drawing.Size(75, 13);
            this.Standartlabel.TabIndex = 9;
            this.Standartlabel.Text = "Текущий ход:";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Location = new System.Drawing.Point(495, 57);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(35, 13);
            this.PlayerLabel.TabIndex = 10;
            this.PlayerLabel.Text = "label1";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(471, 346);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(95, 49);
            this.RestartButton.TabIndex = 11;
            this.RestartButton.Text = "Рестарт";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(481, 57);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(82, 13);
            this.EndLabel.TabIndex = 12;
            this.EndLabel.Text = "Игра окончена";
            this.EndLabel.Visible = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(506, 121);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(35, 13);
            this.ScoreLabel.TabIndex = 13;
            this.ScoreLabel.Text = "Очки:";
            // 
            // PlayerXlabel
            // 
            this.PlayerXlabel.AutoSize = true;
            this.PlayerXlabel.Location = new System.Drawing.Point(492, 147);
            this.PlayerXlabel.Name = "PlayerXlabel";
            this.PlayerXlabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerXlabel.TabIndex = 14;
            // 
            // PlayerOlabel
            // 
            this.PlayerOlabel.AutoSize = true;
            this.PlayerOlabel.Location = new System.Drawing.Point(492, 169);
            this.PlayerOlabel.Name = "PlayerOlabel";
            this.PlayerOlabel.Size = new System.Drawing.Size(0, 13);
            this.PlayerOlabel.TabIndex = 15;
            // 
            // ZeroScoreBtn
            // 
            this.ZeroScoreBtn.Location = new System.Drawing.Point(471, 313);
            this.ZeroScoreBtn.Name = "ZeroScoreBtn";
            this.ZeroScoreBtn.Size = new System.Drawing.Size(95, 27);
            this.ZeroScoreBtn.TabIndex = 16;
            this.ZeroScoreBtn.Text = "Сбросить очки";
            this.ZeroScoreBtn.UseVisualStyleBackColor = true;
            this.ZeroScoreBtn.Click += new System.EventHandler(this.ZeroScoreBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 407);
            this.Controls.Add(this.ZeroScoreBtn);
            this.Controls.Add(this.PlayerOlabel);
            this.Controls.Add(this.PlayerXlabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.Standartlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TicTacToe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Standartlabel;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label PlayerXlabel;
        private System.Windows.Forms.Label PlayerOlabel;
        private System.Windows.Forms.Button ZeroScoreBtn;
    }
}

