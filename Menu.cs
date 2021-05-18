using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCasino
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Quit button[]
        private void quitoption_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        // Button to lead to Slot machine game
        private void slotmachinegame_Click(object sender, EventArgs e)
        {
            SlotMachine sm = new SlotMachine();
            sm.Show();

            this.Hide();
        }

        // Button to lead to Black jack game
        private void blackjackgame_Click(object sender, EventArgs e)
        {
            Blackjack bj = new Blackjack();
            bj.Show();

            this.Hide();

        }

        // Button to lead to credits
        private void button1_Click(object sender, EventArgs e)
        {
            Credits cd = new Credits();
            cd.Show();

            this.Hide();
        }
    }
}
