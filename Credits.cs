using System;
using System.Windows.Forms;

namespace CSharpCasino
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        
        // The back button goes back to the Menu
        private void button1_Click(object sender, EventArgs e)
        {
            Menu mu = new Menu();
            mu.Show();

            this.Hide();
        }

    }
}
