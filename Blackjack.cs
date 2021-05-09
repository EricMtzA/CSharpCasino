using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace CSharpCasino
{
    public partial class Blackjack : Form
    {
        public Blackjack()
        {
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        // Back button on the blackjack window
        private void button1_Click(object sender, EventArgs e)
        {
            Menu mf = new Menu();
            mf.Show();

            this.Hide();
        }

        int bal = Global.balance;

        int pHandOne;
        int dHandOne;
        int pHandTwo;
        int dHandTwo;
        int pHandOld;
        int dHandOld;
        int pHandNext;
        int dHandNext;

        int gambleAmount;

        int clicks = 0;

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

        // method to get a random card number
        private int cardNumber()
        {
            Random rand = new Random();
            int card = rand.Next(1, 14);

            return card;
        }

        // compare the player and dealers hands, determines if player wins, loses or can continue to hit
        private void compareHands(int pHand, int dHand)
        {
            if(pHand == 21 || dHand > 21)
            {
                DialogResult res = MessageBox.Show("You won!", "Winner!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (res == DialogResult.OK)
                {
                    bal = gambleWin(gambleAmount);
                    MessageBox.Show("New balance: " + bal, "Balance");

                    resetGame();

                }

            } 
            else if(dHand == 21 || pHand > 21)
            {
                DialogResult res = MessageBox.Show("You lost!", "Loser!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (res == DialogResult.OK)
                {
                    bal = gambleLose(gambleAmount);
                    MessageBox.Show("New balance: " + bal,"Balance");

                    resetGame();

                }
            } 
            else
            {
                DialogResult res = MessageBox.Show("Your Hand: " + pHand + "\n Dealer's Hand: " + dHand, "Current Hands!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (res == DialogResult.OK)
                {
                    MessageBox.Show("Good luck!", "Hit or Fold?");

                }
            }

        }

        // method to reset the black jack game
        private void resetGame()
        {
            // enable bet button, disable hit and fold button
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;

            //reset clicks
            clicks = 0;

            //clear the labels
            pHand1.Text = " ";
            pHand2.Text = " ";
            pHand3.Text = " ";
            pHand4.Text = " ";


            dHand1.Text = " ";
            dHand2.Text = " ";
            dHand3.Text = " ";
            dHand4.Text = " ";
        }


        // Bet button to place bet and enable hit and fold buton
        private void button2_Click(object sender, EventArgs e)
        {
                string result = Interaction.InputBox("Please place your bet!", "Gamble Amount", "$$$", -1, -1);

                if (Int32.TryParse(result, out int resultInt))
                {
                // enable Hit Button and Fold Button
                    button2.Enabled = false;
                    button3.Enabled = true;
                    button4.Enabled = true;

                    gambleAmount = resultInt;
                    Console.WriteLine(resultInt);
                }
                else
                {
                    Console.WriteLine("Could not parse!");
                }
            
        }



        // Hit button to get player cards
        private void button3_Click(object sender, EventArgs e)
        {
            switch (clicks)
            {
                case 0:
                    // get random number
                    pHandOne = cardNumber();
                    dHandOne = cardNumber();

                    // increment clicks
                    clicks++;

                    // set text of labels to corresponding number
                    pHand1.Text = pHandOne.ToString();
                    dHand1.Text = dHandOne.ToString();

                    break;

                case 1:

                    // get random number
                    pHandTwo = cardNumber();
                    dHandTwo= cardNumber();

                    // increment clicks
                    clicks++;

                    // set text of labels to corresponding number
                    pHand2.Text = pHandTwo.ToString();
                    dHand2.Text = dHandTwo.ToString();

                    
                    pHandOld = pHandOne + pHandTwo;
                    dHandOld = dHandOne + dHandTwo;

                    compareHands(pHandOld, dHandOld);

                    break;

                case 2:
                    // get random number
                    pHandNext = cardNumber();
                    dHandNext = cardNumber();

                    // increment clicks
                    clicks++;

                    // set text of third labels
                    pHand3.Text = pHandNext.ToString();
                    dHand3.Text = dHandNext.ToString();

                    pHandOld = pHandOld + pHandNext;
                    dHandOld = dHandOld + dHandNext;

                    compareHands(pHandOld, dHandOld);

                    break;

                case 3:
                    // get random number
                    pHandNext = cardNumber();
                    dHandNext = cardNumber();

                    // increment clicks
                    clicks++;

                    // set text of four labels
                    pHand4.Text = pHandNext.ToString();
                    dHand4.Text = dHandNext.ToString();

                    pHandOld = pHandOld + pHandNext;
                    dHandOld = dHandOld + dHandNext;

                    compareHands(pHandOld, dHandOld);

                    break;
                default:
                    MessageBox.Show("More than 4 cards required.", "Limit");
                    break;
            }
        }

        // Fold button to lose game and reset
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You lost!", "Loser!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (res == DialogResult.OK)
            {
                bal = gambleLose(gambleAmount);
                MessageBox.Show("New balance: " + bal, "Balance");

                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

    }
}
