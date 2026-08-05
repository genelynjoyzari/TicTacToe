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
    public partial class Form3 : Form
    {
        string[,] board = new string[3, 3];
        bool isPlayerX = true;
        Random rnd = new Random();
        public Form3()
        {
            InitializeComponent();
            InitBoard();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void InitBoard()
        {
            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    board[r, c] = "";

            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";

            isPlayerX = true;
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

        private void ComputerMove()
        {
            List<int[]> empty = new List<int[]>();

            for (int r = 0; r < 3; r++)
                for (int c = 0; c < 3; c++)
                    if (board[r, c] == "")
                        empty.Add(new int[] { r, c });

            if (empty.Count == 0) return;

            int[] chosen = empty[rnd.Next(empty.Count)];
            board[chosen[0], chosen[1]] = "O";

            Button[] buttons = { button1, button2, button3,
                                 button4, button5, button6,
                                 button7, button8, button9 };
            buttons[chosen[0] * 3 + chosen[1]].Text = "O";

            string winner = CheckWinner();
            if (winner != "")
            {
                MessageBox.Show("Computer Wins!");
                InitBoard();
                return;
            }

            if (CheckDraw())
            {
                MessageBox.Show("It's a Draw!");
                InitBoard();
                return;
            }

            label1.Text = "Player X's Turn";
        }

        private void PlaceMove(Button btn, int row, int col)
        {
            if (board[row, col] != "") return;

            board[row, col] = "X";
            btn.Text = "X";

            string winner = CheckWinner();
            if (winner != "")
            {
                MessageBox.Show("Player X Wins!");
                InitBoard();
                return;
            }

            if (CheckDraw())
            {
                MessageBox.Show("It's a Draw!");
                InitBoard();
                return;
            }

            label1.Text = "Computer's Turn...";
            ComputerMove();
        }

        private void button1_Click_1(object sender, EventArgs e) { PlaceMove(button1, 0, 0); }
        private void button2_Click(object sender, EventArgs e) { PlaceMove(button2, 0, 1); }
        private void button3_Click_1(object sender, EventArgs e) { PlaceMove(button3, 0, 2); }
        private void button4_Click_1(object sender, EventArgs e) { PlaceMove(button4, 1, 0); }
        private void button5_Click_1(object sender, EventArgs e) { PlaceMove(button5, 1, 1); }
        private void button6_Click_1(object sender, EventArgs e) { PlaceMove(button6, 1, 2); }
        private void button7_Click_1(object sender, EventArgs e) { PlaceMove(button7, 2, 0); }
        private void button8_Click_1(object sender, EventArgs e) { PlaceMove(button8, 2, 1); }
        private void button9_Click_1(object sender, EventArgs e) { PlaceMove(button9, 2, 2); }



        private void btn_restart_Click_1(object sender, EventArgs e){ InitBoard(); }

        private void btn_back2menu_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}