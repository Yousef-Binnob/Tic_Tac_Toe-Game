using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        stGameInfo Info;
        private enPlayer PlayerTurn;


        enum enPlayer : byte
        {
            enPlayer1,
            enPlayer2,
            enGameOver
        }
        enum enWinner : byte
        {
            enPlayer1,
            enPlayer2,
            enInProgress,
            enDraw
        }
        struct stGameInfo
        {
            public bool GameOver;
            public enWinner Winner;
            public byte Counter;

        }
        public Form1()
        {
            InitializeComponent();
            PlayerTurn = enPlayer.enPlayer1;
            Info.GameOver = false;
            Info.Winner = enWinner.enInProgress;
            Info.Counter = 0;
        }
        private void UpdateWinner()
        {
            switch (Info.Winner)
            {
                case enWinner.enPlayer1:
                    lblWinner.Text = "Player 1";
                    break;
                case enWinner.enPlayer2:
                    lblWinner.Text = "Player 2";
                    break;
                case enWinner.enInProgress:
                    lblWinner.Text = "In Progress";
                    break;
                case enWinner.enDraw:
                    lblWinner.Text = "Draw";
                    break;
                default:
                    lblWinner.Text = "In progress";
                    break;
            }
        }
        private void UpdatePlayerTurn()
        {
            switch (PlayerTurn)
            {
                case enPlayer.enPlayer1:
                    lblTurn.Text = "Player 1";
                    break;
                case enPlayer.enPlayer2:
                    lblTurn.Text = "Player 2";
                    break;
                case enPlayer.enGameOver:
                    lblTurn.Text = "Game over";
                    break;
            }
        }
        private void EndGame()
        {
            Info.GameOver = true;
            PlayerTurn = enPlayer.enGameOver;
            UpdateWinner();
            UpdatePlayerTurn();
            MessageBox.Show("Game over");
        }
        void SetBackColor(Button Button1, Button Button2, Button Button3)
        {
            Button1.BackColor = Color.GreenYellow;
            Button2.BackColor = Color.GreenYellow;
            Button3.BackColor = Color.GreenYellow;
        }
        private bool CheckButtons(Button btn1, Button btn2, Button btn3)
        {
            return (btn1.Tag.ToString() != "?" && btn1.Tag.ToString() == btn2.Tag.ToString() && btn1.Tag.ToString() == btn3.Tag.ToString());
        }
        private bool CheckWinner()
        {
            if (CheckButtons(btnBox1, btnBox2, btnBox3))
            {
                SetBackColor(btnBox1, btnBox2, btnBox3);
                return true;
            }
            
            if (CheckButtons(btnBox4, btnBox5, btnBox6))
            {
                SetBackColor(btnBox4, btnBox5, btnBox6);
                return true;
            }

            if (CheckButtons(btnBox7, btnBox8, btnBox9))
            {
                SetBackColor(btnBox7, btnBox8, btnBox9);
                return true;
            }

            if (CheckButtons(btnBox1, btnBox4, btnBox7))
            {
                SetBackColor(btnBox1, btnBox4, btnBox7);
                return true;
            }

            if (CheckButtons(btnBox2, btnBox5, btnBox8))
            {
                SetBackColor(btnBox2, btnBox5, btnBox8);
                return true;
            }

            if (CheckButtons(btnBox3, btnBox6, btnBox9))
            {
                SetBackColor(btnBox3, btnBox6, btnBox9);
                return true;
            }

            if (CheckButtons(btnBox1, btnBox5, btnBox9))
            {
                SetBackColor(btnBox1, btnBox5, btnBox9);
                return true;
            }

            if (CheckButtons(btnBox3, btnBox5, btnBox7))
            {
                SetBackColor(btnBox3, btnBox5, btnBox7);
                return true;
            }
            return false;
        }
        private void ChangeImage(Button Box)
        {
            if (Info.GameOver)
            {
                MessageBox.Show("Game over");
                return;
            }
            else if (Box.Tag.ToString() == "?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.enPlayer1:
                       Box.BackgroundImage = Resources.x;
                       Box.Tag = "x";
                        if (CheckWinner())
                        {
                            Info.Winner = enWinner.enPlayer1;
                            EndGame();
                            return;
                        }
                        else
                        {
                            PlayerTurn = enPlayer.enPlayer2;
                            UpdatePlayerTurn();
                        }
                        break;
                    case enPlayer.enPlayer2:
                        Box.BackgroundImage = Resources.o;
                        Box.Tag = "o";
                        if (CheckWinner())
                        {
                            Info.Winner = enWinner.enPlayer1;
                            EndGame();
                            return;
                        }
                        else
                        {
                            PlayerTurn = enPlayer.enPlayer1;
                            UpdatePlayerTurn();
                        }
                        break;
                }
                Info.Counter++;
            }
            else if (Box.Tag.ToString() != "?" && Info.Counter != 9)
            {
                MessageBox.Show("Wrong choice", "Error");
            }
            if (Info.Counter == 9)
            {
                Info.Winner = enWinner.enDraw;
                EndGame();
            }
        }
        private void btnBox_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.FromArgb(255, 255, 255);
            Pen Pen = new Pen(White);
            Pen.Width = 8;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 396, 100, 396, 390);
            e.Graphics.DrawLine(Pen, 492, 100, 492, 390);
            e.Graphics.DrawLine(Pen, 300, 196, 590, 196);
            e.Graphics.DrawLine(Pen, 300, 292, 590, 292);
        }

        private void ResetButton(Button button)
        {
            button.BackgroundImage = Resources.question_mark;
            button.Tag = "?";
            button.BackColor = Color.Transparent;
        }

        private void RestartGame()
        {
            ResetButton(btnBox1);
            ResetButton(btnBox2);
            ResetButton(btnBox3);
            ResetButton(btnBox4);
            ResetButton(btnBox5);
            ResetButton(btnBox6);
            ResetButton(btnBox7);
            ResetButton(btnBox8);
            ResetButton(btnBox9);

            PlayerTurn = enPlayer.enPlayer1;
            Info.Winner = enWinner.enInProgress;
            Info.GameOver = false;
            Info.Counter = 0;

            UpdatePlayerTurn();
            UpdateWinner();
        }
        private void btnRestartGame_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
