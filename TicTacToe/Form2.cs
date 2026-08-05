using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        string[,] board = new string[3, 3];
        bool isplayerX = true;
        public Form2()
        {
            InitializeComponent();
            InitBoard();
        }
        private void InitBoard()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    board[r, c] = "";

            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";

            isplayerX = true;
            label1.Text = "Player X's Turn";
        }

        private string CheckWinner()
        {
            for (int r = 0; r < 3; r++)
                if (board[r, 0] != "" && board[r, 0] == board[r, 1] && board[r, 1] == board[r, 2])
                    return board[r, 0];

            for (int c = 0; c < 3; c++)
                if (board[0, c] != "" && board[0, c] == board[1, c] && board[1, c] == board[2, c])
                    return board[0, c];

            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                return board[0, 0];
            if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
                return board[0, 2];

            return "";
        }

        private bool CheckDraw()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    if (board[r, c] == "") return false;
            return true;
        }

        private void PlaceMove(Button btn, int row, int col)
        {
            if (board[row, col] != "") return;

            string current = isplayerX ? "X" : "O";
            board[row, col] = current;
            btn.Text = current;

            string winner = CheckWinner();
            if (winner != "")
            {
                MessageBox.Show("Player " + winner + " Wins!");
                InitBoard();
                return;
            }

            if (CheckDraw())
            {
                MessageBox.Show("It's a Draw!");
                InitBoard();
                return;
            }

            isplayerX = !isplayerX;
            label1.Text = isplayerX ? "Player X's Turn" : "Player O's Turn";
        }

        private void button1_Click_1(object sender, EventArgs e) { PlaceMove(button1, 0, 0); }
        private void button2_Click_1(object sender, EventArgs e) { PlaceMove(button2, 0, 1); }
        private void button3_Click_1(object sender, EventArgs e) { PlaceMove(button3, 0, 2); }
        private void button4_Click_1(object sender, EventArgs e) { PlaceMove(button4, 1, 0); }
        private void button5_Click_1(object sender, EventArgs e) { PlaceMove(button5, 1, 1); }
        private void button6_Click_1(object sender, EventArgs e) { PlaceMove(button6, 1, 2); }
        private void button7_Click_1(object sender, EventArgs e) { PlaceMove(button7, 2, 0); }
        private void button8_Click_1(object sender, EventArgs e) { PlaceMove(button8, 2, 1); }
        private void button9_Click_1(object sender, EventArgs e) { PlaceMove(button9, 2, 2); }

        
        

        
        private void button10_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e){ InitBoard(); }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
    