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

namespace FruitNinjaWinFormsApp
{
    public enum Difficult 
    {
        Easy,
        Middle,
        Hard
    }
    public partial class GameForm : Form
    {
        public static Difficult difficult = Difficult.Easy;
        public static User user;
        public GameForm()
        {
            InitializeComponent();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {

        }
    }
}
