namespace FruitNinjaWinFormsApp
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            showLabel = new Label();
            textBox1 = new TextBox();
            beginButton = new Button();
            SuspendLayout();
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.BackColor = Color.FromArgb(0, 32, 0);
            showLabel.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            showLabel.ForeColor = Color.FromArgb(192, 255, 192);
            showLabel.Location = new Point(273, 89);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(303, 45);
            showLabel.TabIndex = 0;
            showLabel.Text = "Введите своё имя";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.PaleGreen;
            textBox1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.FromArgb(0, 32, 0);
            textBox1.Location = new Point(306, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 52);
            textBox1.TabIndex = 1;
            // 
            // beginButton
            // 
            beginButton.BackColor = Color.FromArgb(0, 32, 0);
            beginButton.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold);
            beginButton.ForeColor = Color.FromArgb(192, 255, 192);
            beginButton.Location = new Point(363, 382);
            beginButton.Name = "beginButton";
            beginButton.Size = new Size(129, 56);
            beginButton.TabIndex = 2;
            beginButton.Text = "Начать";
            beginButton.UseVisualStyleBackColor = false;
            beginButton.Click += beginButton_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(851, 450);
            Controls.Add(beginButton);
            Controls.Add(textBox1);
            Controls.Add(showLabel);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label showLabel;
        private TextBox textBox1;
        private Button beginButton;
    }
}