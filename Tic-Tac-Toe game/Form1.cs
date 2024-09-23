using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_game.Properties;

namespace Tic_Tac_Toe_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);
            Pen pen = new Pen(white);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            //horisotal

            e.Graphics.DrawLine(pen, 500, 100, 500, 400);
            e.Graphics.DrawLine(pen, 375, 100, 375, 400);
            //virtical

            e.Graphics.DrawLine(pen, 260, 200, 625, 200);
            e.Graphics.DrawLine(pen, 265, 295, 640, 295);
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        stGameStatus GameStatus;
        enPlayer PlayerTrun = enPlayer.Player1;
        enum enWinner
        {
            player1,
            player2,
            Draw,
            GameinProgress
        }
        struct stGameStatus
        {
            public enWinner Winner ;
            public bool GameOver;
            public short PlayCount;
        }
        void EndGamge()
        {
            lblTurn.Text = "Game over";
            switch(GameStatus.Winner)
            {
               
                case enWinner.player1:
                    lblWinner.Text = "Player1";
                    break;
                case enWinner.player2:
                    lblWinner.Text = "Player2";
                    break;

                default:
                    lblWinner.Text = "Draw";
                    break;
                    
            }
            MessageBox.Show("Game Over", "Game Over",MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        enum enPlayer{Player1,Player2}
        bool checkValues(Button btn1, Button btn2, Button btn3)
        {
            if (btn1.Tag.ToString()!="?"&&btn1.Tag.ToString()==btn2.Tag.ToString()&&btn1.Tag.ToString()==btn3.Tag.ToString())
            {
                btn1.BackColor = Color.GreenYellow; 
                btn2.BackColor = Color.GreenYellow; 
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString()=="X")
                {
                    GameStatus.Winner = enWinner.player1;
                    GameStatus.GameOver= true;
                    EndGamge();
                    return true;
                }
                else
                {
                    GameStatus.Winner=enWinner.player2;
                    GameStatus.GameOver= true;
                    EndGamge();
                    return true;
                }

            }

            GameStatus.GameOver = false;
            return false;
        }
        void checkWinner()
        {
            if (checkValues(button2,button4,button5))
            {
                return;
            }
            if (checkValues(button3, button6, button7))
            {
                return;
            }
            if (checkValues(button8, button9, button10))
            {
                return;
            }


            if (checkValues(button2, button3, button8))
            {
                return;
            }
            if (checkValues(button4, button6, button9))
            {
                return;
            }
            if (checkValues(button5, button7, button10))
            {
                return;
            }
            if (checkValues(button2, button6, button10))
            {
                return;
            }
            if (checkValues(button5, button6, button8))
            {
                return;
            }

        }
        void changeImage(Button btn)
        {
            if(btn.Tag.ToString()=="?")
            {
                switch(PlayerTrun)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.x2;
                        PlayerTrun = enPlayer.Player2;
                        lblPlayer.Text = "Player2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        checkWinner();
                        break;
                    case enPlayer.Player2 :
                        btn.Image = Resources.o5;
                        PlayerTrun = enPlayer.Player1;
                        lblPlayer.Text = "Player1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        checkWinner();
                        break;


                }

            }
            else
            {
                MessageBox.Show("Wrong Chois", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            if (GameStatus.PlayCount==9)
            {
                GameStatus.GameOver = true;
                GameStatus.Winner = enWinner.Draw;
                EndGamge();
            }
        }
        void RestButton(Button btn)
        {
            btn.Image = Resources.question2;
            btn.Tag = "?";
            btn.BackColor= Color.Transparent;
        }
        void RestartGame()
        {
            RestButton(button2);
            RestButton(button4);
            RestButton(button3);
            RestButton(button5);
            RestButton(button6);
            RestButton(button7);
            RestButton(button8);
            RestButton(button9);
            RestButton(button10);

            PlayerTrun=enPlayer.Player1;
            lblPlayer.Text = "player 1";
            GameStatus.PlayCount = 0;
            GameStatus.Winner = enWinner.GameinProgress;
            GameStatus.GameOver = false;
            lblWinner.Text = "in Progress";
        }
        private void button_Click(object sender, EventArgs e)
        {
            changeImage((Button) sender);
        }
       
       

        private void lblRestGame_Click(object sender, EventArgs e)
        {
             RestartGame();
        }
    }
}
