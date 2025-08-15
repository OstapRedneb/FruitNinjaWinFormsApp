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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            switch (e.NewValue) // Добавь потом логику
            {
                case < 33: break;
                case > 33 and < 66: break;
                case < 66: break;

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены, что хотите удалить все результаты?\nПрогресс всех игроков будет безвозвратно утерян", "Предупреждение!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (answer == DialogResult.OK)
                FileWorker.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            Close();
        }
    }
}
