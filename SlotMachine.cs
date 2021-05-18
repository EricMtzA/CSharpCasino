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
        int slotOne;
        int slotTwo;
        int slotThree;

        // Pull button
        private void button2_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Please place your bet!", "Gamble Amount", "$$$", -1, -1);

            if (Int32.TryParse(result, out int resultInt))
            {
                Console.WriteLine(resultInt);

                slotOne = slotNumber();
                slotTwo = slotNumber();
                slotThree = slotNumber();

                firstNum.Text = slotOne.ToString();
                secondNum.Text = slotTwo.ToString();
                threeNum.Text = slotThree.ToString();


                if (slotOne == slotTwo && slotTwo == slotThree)
                {
                    DialogResult res = MessageBox.Show("You Won!", "Winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK)
                    {
                        bal = gambleWin(resultInt);
                        MessageBox.Show("New balance: " + bal, "Balance");
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("You lost!", "Loser!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (res == DialogResult.OK)
                    {
                        bal = gambleLose(resultInt);
                        MessageBox.Show("New balance: " + bal, "Balance");
                    }
                    else
                    {
                        Console.WriteLine("Could not parse!");
                    }
                }
            }
        }

        // Back button on the slot machine window
        private void button1_Click(object sender, EventArgs e)
        {
            Menu mf = new Menu();
            mf.Show();

            this.Hide();
        }

        // method to change balance when player wins
        private int gambleWin(int gambleAmount)
        {
            bal = bal - gambleAmount;
            int winnings = gambleAmount * 2;

            bal = bal + winnings;

            return bal;
        }

        // method to change balance when player loses
        private int gambleLose(int gambleAmount)
        {
            bal = bal - gambleAmount;

            return bal;
        }

        // method to get a random slot machine number
        private int slotNumber()
        {
            Random rand = new Random();
            int slotNum = rand.Next(1, 4);

            return slotNum;
        }
    }
}
