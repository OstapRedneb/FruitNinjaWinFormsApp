namespace FruitNinjaWinFormsApp
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            showLabel = new Label();
            resultsLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.BackColor = Color.FromArgb(64, 0, 64);
            showLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.White;
            showLabel.Location = new Point(12, 9);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(368, 30);
            showLabel.TabIndex = 0;
            showLabel.Text = "Результаты предыдущих игроков:";
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.BackColor = SystemColors.ActiveCaptionText;
            resultsLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsLabel.ForeColor = Color.Purple;
            resultsLabel.Location = new Point(12, 55);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(0, 27);
            resultsLabel.TabIndex = 1;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(0, 0, 64);
            backButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            backButton.ForeColor = Color.Fuchsia;
            backButton.Location = new Point(336, 382);
            backButton.Name = "backButton";
            backButton.Size = new Size(129, 56);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(backButton);
            Controls.Add(resultsLabel);
            Controls.Add(showLabel);
            DoubleBuffered = true;
            Name = "ResultsForm";
            Text = "ResultsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLabel;
        private Label resultsLabel;
        private Button backButton;
    }
}