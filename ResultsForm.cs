using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048ClassLibrary;
using FruitNinjaWinFormsApp;

namespace FruitNinjaWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
            List<User> users = FileWorker.GetUsersList();
            users.Sort();
            users.Reverse();
            resultsLabel.Text = string.Join("\n", users);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Hide();
        }
    }
}
