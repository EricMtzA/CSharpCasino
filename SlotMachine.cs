using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace CSharpCasino
{
    public partial class SlotMachine : Form
    {
        public SlotMachine()
        {
            InitializeComponent();
        }

        int bal = Global.balance;

        // Pull button
        private void button2_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Please place your bet!", "Gamble Amount", "$$$", -1, -1);

            if (Int32.TryParse(result, out int resultInt))
            {
                Console.WriteLine(resultInt);

                

                if (resultInt <= bal)
                {

                }

            }
            else
            {
                Console.WriteLine("Could not parse!");
            }
        }

        // Back button on the slot machine window
        private void button1_Click(object sender, EventArgs e)
        {
            Menu mf = new Menu();
            mf.Show();

            this.Hide();
        }
    }
}
