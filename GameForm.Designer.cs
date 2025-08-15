namespace FruitNinjaWinFormsApp
{
    partial class GameForm
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
            finishButton = new Button();
            showLabel = new Label();
            scoreLabel = new Label();
            SuspendLayout();
            // 
            // finishButton
            // 
            finishButton.BackColor = Color.Red;
            finishButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            finishButton.ForeColor = Color.Transparent;
            finishButton.Location = new Point(666, 12);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(122, 44);
            finishButton.TabIndex = 3;
            finishButton.Text = "Завершить";
            finishButton.UseVisualStyleBackColor = false;
            finishButton.Click += finishButton_Click;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.Location = new Point(12, 18);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(84, 35);
            showLabel.TabIndex = 4;
            showLabel.Text = "Очки:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            scoreLabel.Location = new Point(102, 18);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(30, 35);
            scoreLabel.TabIndex = 5;
            scoreLabel.Text = "0";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(scoreLabel);
            Controls.Add(showLabel);
            Controls.Add(finishButton);
            Name = "GameForm";
            Text = "GameForm";
            MouseDown += GameForm_MouseDown;
            MouseMove += GameForm_MouseMove;
            MouseUp += GameForm_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button finishButton;
        private Label showLabel;
        private Label scoreLabel;
    }
}