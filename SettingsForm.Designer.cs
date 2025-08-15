namespace FruitNinjaWinFormsApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            backButton = new Button();
            showLabel = new Label();
            hScrollBar1 = new HScrollBar();
            dificultLabel = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(32, 32, 32);
            backButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(255, 128, 0);
            backButton.Location = new Point(659, 382);
            backButton.Name = "backButton";
            backButton.Size = new Size(129, 56);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.BackColor = Color.FromArgb(64, 64, 64);
            showLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.FromArgb(255, 128, 0);
            showLabel.Location = new Point(95, 45);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(200, 45);
            showLabel.TabIndex = 5;
            showLabel.Text = "Сложность:";
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(311, 45);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(211, 45);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // dificultLabel
            // 
            dificultLabel.AutoSize = true;
            dificultLabel.BackColor = Color.FromArgb(64, 64, 64);
            dificultLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dificultLabel.ForeColor = Color.Lime;
            dificultLabel.Location = new Point(543, 45);
            dificultLabel.Name = "dificultLabel";
            dificultLabel.Size = new Size(112, 45);
            dificultLabel.TabIndex = 7;
            dificultLabel.Text = "Легко";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Red;
            clearButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            clearButton.ForeColor = Color.White;
            clearButton.Location = new Point(311, 382);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(240, 56);
            clearButton.TabIndex = 8;
            clearButton.Text = "Удалить весь прогресс";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(clearButton);
            Controls.Add(dificultLabel);
            Controls.Add(hScrollBar1);
            Controls.Add(showLabel);
            Controls.Add(backButton);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Label showLabel;
        private HScrollBar hScrollBar1;
        private Label dificultLabel;
        private Button clearButton;
    }
}