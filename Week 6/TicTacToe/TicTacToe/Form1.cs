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
    public partial class Form1 : Form
    {
        bool turn = true;
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Caleb Miller for GCU.");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;
            turnCount++;
            checkWinner();
        }

        private void checkWinner()
        {
            bool theWinner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                theWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                theWinner = true;

            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                theWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                theWinner = true;

            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                theWinner = true;

            if (theWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Is the Winner!", "Winner");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("There is no winner, its a draw!");
            }
            
        }

        private void disableButtons()
        {
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }

            catch { }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
            }

            catch { }
        }

        public void initializeBoard()
        {

            int n = 0;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    n++;
                    //board[i, j] = n.ToString();
                }
            }
            posn = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        private char[,] board;
        private char[] posn;

       //private bool startGame()
       // {
         //   int n = 0;
           // for (int i = 0; i < 3; i++)
            //{

              //  for (int j = 0; j < 3; j++)
                //{
                  //  n++;
                    //board[i, j] = n.ToString();
                //}
            //}
            //posn = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //}

        public bool checkForWin()
        {
            return (checkRowsForWin() || checkColumnsForWin() || checkDiagonalsForWin());
        }


        private bool checkRowsForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (checkRowCol(board[i, 0], board[i, 1], board[i, 2]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkColumnsForWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (checkRowCol(board[0, i], board[1, i], board[2, i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private bool checkDiagonalsForWin()
        {
            return ((checkRowCol(board[0, 0], board[1, 1], board[2, 2]) == true) || (checkRowCol(board[0, 2], board[1, 1], board[2, 0]) == true));
        }

        private bool checkRowCol(char c1, char c2, char c3)
        {
            return ((c1 != '-') && (c1 == c2) && (c2 == c3));
        }

    }
}
