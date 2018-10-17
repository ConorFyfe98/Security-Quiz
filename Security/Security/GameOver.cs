using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
            failMessage();
        }

        private void gameoverLabel_Click(object sender, EventArgs e)
        {

        }

        private void failMessage()
        {
            failMessageLabel.Text = Main.FailMessage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mm = new Main();
            mm.Show();
        }
    }
}
