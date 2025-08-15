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
            Hide();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().Show();
            Hide();
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            new ResultsForm().Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
