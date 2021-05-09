
namespace CSharpCasino
{
    partial class Blackjack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pHand1 = new System.Windows.Forms.Label();
            this.pHand2 = new System.Windows.Forms.Label();
            this.dHand1 = new System.Windows.Forms.Label();
            this.dHand2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pHand3 = new System.Windows.Forms.Label();
            this.dHand3 = new System.Windows.Forms.Label();
            this.pHand4 = new System.Windows.Forms.Label();
            this.dHand4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(515, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(240, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pHand1
            // 
            this.pHand1.AutoSize = true;
            this.pHand1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pHand1.ForeColor = System.Drawing.Color.Green;
            this.pHand1.Location = new System.Drawing.Point(145, 50);
            this.pHand1.Name = "pHand1";
            this.pHand1.Size = new System.Drawing.Size(0, 15);
            this.pHand1.TabIndex = 2;
            // 
            // pHand2
            // 
            this.pHand2.AutoSize = true;
            this.pHand2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pHand2.ForeColor = System.Drawing.Color.Green;
            this.pHand2.Location = new System.Drawing.Point(145, 84);
            this.pHand2.Name = "pHand2";
            this.pHand2.Size = new System.Drawing.Size(0, 17);
            this.pHand2.TabIndex = 3;
            // 
            // dHand1
            // 
            this.dHand1.AccessibleName = "dHand1";
            this.dHand1.AutoSize = true;
            this.dHand1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dHand1.ForeColor = System.Drawing.Color.Green;
            this.dHand1.Location = new System.Drawing.Point(359, 50);
            this.dHand1.Name = "dHand1";
            this.dHand1.Size = new System.Drawing.Size(0, 17);
            this.dHand1.TabIndex = 4;
            // 
            // dHand2
            // 
            this.dHand2.AccessibleName = "dHand1";
            this.dHand2.AutoSize = true;
            this.dHand2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dHand2.ForeColor = System.Drawing.Color.Green;
            this.dHand2.Location = new System.Drawing.Point(359, 84);
            this.dHand2.Name = "dHand2";
            this.dHand2.Size = new System.Drawing.Size(0, 17);
            this.dHand2.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(240, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Hit!";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(240, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 26);
            this.button4.TabIndex = 7;
            this.button4.Text = "Fold";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pHand3
            // 
            this.pHand3.AutoSize = true;
            this.pHand3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pHand3.ForeColor = System.Drawing.Color.Green;
            this.pHand3.Location = new System.Drawing.Point(145, 120);
            this.pHand3.Name = "pHand3";
            this.pHand3.Size = new System.Drawing.Size(0, 17);
            this.pHand3.TabIndex = 8;
            //is.pHand3.Click += new System.EventHandler(this.pHand3_Click);
            // 
            // dHand3
            // 
            this.dHand3.AutoSize = true;
            this.dHand3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dHand3.ForeColor = System.Drawing.Color.Green;
            this.dHand3.Location = new System.Drawing.Point(359, 120);
            this.dHand3.Name = "dHand3";
            this.dHand3.Size = new System.Drawing.Size(0, 17);
            this.dHand3.TabIndex = 9;
            // 
            // pHand4
            // 
            this.pHand4.AutoSize = true;
            this.pHand4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pHand4.ForeColor = System.Drawing.Color.Green;
            this.pHand4.Location = new System.Drawing.Point(145, 155);
            this.pHand4.Name = "pHand4";
            this.pHand4.Size = new System.Drawing.Size(0, 17);
            this.pHand4.TabIndex = 10;
            //is.pHand4.Click += new System.EventHandler(this.pHand4_Click);
            // 
            // dHand4
            // 
            this.dHand4.AutoSize = true;
            this.dHand4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dHand4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dHand4.Location = new System.Drawing.Point(359, 155);
            this.dHand4.Name = "dHand4";
            this.dHand4.Size = new System.Drawing.Size(0, 17);
            this.dHand4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "Player\'s Cards";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 8.999999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(325, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "Dealer\'s Cards";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dHand4);
            this.Controls.Add(this.pHand4);
            this.Controls.Add(this.dHand3);
            this.Controls.Add(this.pHand3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dHand2);
            this.Controls.Add(this.dHand1);
            this.Controls.Add(this.pHand2);
            this.Controls.Add(this.pHand1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Blackjack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blackjack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label pHand1;
        private System.Windows.Forms.Label pHand2;
        private System.Windows.Forms.Label dHand1;
        private System.Windows.Forms.Label dHand2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label pHand3;
        private System.Windows.Forms.Label dHand3;
        private System.Windows.Forms.Label pHand4;
        private System.Windows.Forms.Label dHand4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}