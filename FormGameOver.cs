using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis
{
    public partial class FormGameOver : Form
    {
        public FormGameOver()
        {
            InitializeComponent();
        }

        // установка значения счета в поле
        public int SetScore { set { labelScore.Text += value.ToString(); } }

        // начать новю игру
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Close();
        }

        // завершить приложение
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
