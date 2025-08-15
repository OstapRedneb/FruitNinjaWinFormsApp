using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitNinjaWinFormsApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            // Пропиши логику имени
            new GameForm().Show();
            Hide();
        }
    }
}
