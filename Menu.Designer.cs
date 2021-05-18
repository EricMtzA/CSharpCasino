
namespace CSharpCasino
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Selection = new System.Windows.Forms.Label();
            this.blackjackgame = new System.Windows.Forms.Button();
            this.slotmachinegame = new System.Windows.Forms.Button();
            this.quitoption = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Font = new System.Drawing.Font("Unispace", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Selection.Location = new System.Drawing.Point(173, 37);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(223, 29);
            this.Selection.TabIndex = 0;
            this.Selection.Text = "Select a game!";
            // 
            // blackjackgame
            // 
            this.blackjackgame.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blackjackgame.Location = new System.Drawing.Point(247, 122);
            this.blackjackgame.Name = "blackjackgame";
            this.blackjackgame.Size = new System.Drawing.Size(85, 24);
            this.blackjackgame.TabIndex = 1;
            this.blackjackgame.Text = "Blackjack";
            this.blackjackgame.UseVisualStyleBackColor = true;
            this.blackjackgame.Click += new System.EventHandler(this.blackjackgame_Click);
            // 
            // slotmachinegame
            // 
            this.slotmachinegame.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.slotmachinegame.Location = new System.Drawing.Point(235, 152);
            this.slotmachinegame.Name = "slotmachinegame";
            this.slotmachinegame.Size = new System.Drawing.Size(112, 23);
            this.slotmachinegame.TabIndex = 2;
            this.slotmachinegame.Text = "Slot Machine";
            this.slotmachinegame.UseVisualStyleBackColor = true;
            this.slotmachinegame.Click += new System.EventHandler(this.slotmachinegame_Click);
            // 
            // quitoption
            // 
            this.quitoption.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quitoption.Location = new System.Drawing.Point(519, 326);
            this.quitoption.Name = "quitoption";
            this.quitoption.Size = new System.Drawing.Size(53, 23);
            this.quitoption.TabIndex = 3;
            this.quitoption.Text = "Quit";
            this.quitoption.UseVisualStyleBackColor = true;
            this.quitoption.Click += new System.EventHandler(this.quitoption_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(247, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(29F, 58F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.quitoption);
            this.Controls.Add(this.slotmachinegame);
            this.Controls.Add(this.blackjackgame);
            this.Controls.Add(this.Selection);
            this.Font = new System.Drawing.Font("Unispace", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Button blackjackgame;
        private System.Windows.Forms.Button slotmachinegame;
        private System.Windows.Forms.Button quitoption;
        private System.Windows.Forms.Button slotmachinebutton;
        private System.Windows.Forms.Button button1;
    }
}