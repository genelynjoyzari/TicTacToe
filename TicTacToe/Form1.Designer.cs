namespace TicTacToe
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Button();
            this.computer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 49.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(138, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic-Tac-Toe";
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(308, 224);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(165, 33);
            this.player2.TabIndex = 1;
            this.player2.Text = "2 Player";
            this.player2.UseVisualStyleBackColor = true;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // computer
            // 
            this.computer.BackColor = System.Drawing.Color.White;
            this.computer.Location = new System.Drawing.Point(308, 278);
            this.computer.Name = "computer";
            this.computer.Size = new System.Drawing.Size(165, 33);
            this.computer.TabIndex = 2;
            this.computer.Text = "vs Computer";
            this.computer.UseVisualStyleBackColor = false;
            this.computer.Click += new System.EventHandler(this.computer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.computer);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button player2;
        private System.Windows.Forms.Button computer;
    }
}

