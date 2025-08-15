namespace FruitNinjaWinFormsApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            new UserForm().Show();
            Close();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            Close();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            new ResultsForm().Show();
            Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
