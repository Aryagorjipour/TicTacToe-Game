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
        private bool _isTurn = true;
        private int _turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            button.Text = "X";
            Value();

            _isTurn = !_isTurn;

            button.Enabled = false;

            _turnCount++;
            Win();
        }

        private void Win()
        {
            bool IsWin = false;


            if ((btn1.Text == btn2.Text) && (btn2.Text == btn3.Text) && (!btn1.Enabled))
                IsWin = true;
            else if ((btn4.Text == btn5.Text) && (btn5.Text == btn6.Text) && (!btn4.Enabled))
                IsWin = true;
            else if ((btn7.Text == btn8.Text) && (btn8.Text == btn9.Text) && (!btn7.Enabled))
                IsWin = true;
            //-----------------------------------------------------------------
            if ((btn1.Text == btn4.Text) && (btn4.Text == btn7.Text) && (!btn1.Enabled))
                IsWin = true;
            else if ((btn2.Text == btn5.Text) && (btn5.Text == btn8.Text) && (!btn2.Enabled))
                IsWin = true;
            else if ((btn3.Text == btn6.Text) && (btn6.Text == btn9.Text) && (!btn3.Enabled))
                IsWin = true;
            //----------------------------------------------------------------------------
            if ((btn1.Text == btn5.Text) && (btn5.Text == btn9.Text) && (!btn1.Enabled))
                IsWin = true;
            else if ((btn3.Text == btn5.Text) && (btn5.Text == btn7.Text) && (!btn3.Enabled))
                IsWin = true;



            if (IsWin)
            {
                string Win;

                if (_isTurn)
                    Win = "X";
                else
                    Win = "O";

                txtShow.Text = "Player " + Win + " Is Win !!!";

                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
            }
            else
            {
                if (_turnCount == 5)
                {
                    txtShow.Text = " OH!! Nooooo!! Draw !!!";
                }
            }
        }
        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            btn1.Enabled = true;
            btn1.Text = "";
            btn2.Enabled = true;
            btn2.Text = "";
            btn3.Enabled = true;
            btn3.Text = "";
            btn4.Enabled = true;
            btn4.Text = "";
            btn5.Enabled = true;
            btn5.Text = "";
            btn6.Enabled = true;
            btn6.Text = "";
            btn7.Enabled = true;
            btn7.Text = "";
            btn8.Enabled = true;
            btn8.Text = "";
            btn9.Enabled = true;
            btn9.Text = "";
            txtShow.Text = "";
            _turnCount = 0;
        }

        private void Value()
        {
            if (btn5.Text == "")
            {
                btn5.Text = "O";
                btn5.Enabled = false;
            }
            else
            {
                Prevent();
            }

        }
        private void Prevent()
        {
            if (btn3.Text == "" && btn5.Text == "X")
            {
                btn3.Text = "O";
                btn3.Enabled = false;
            }
            if (_turnCount >= 1)
            {
                if (btn5.Text == "X")
                {
                    ButtonFive();
                }
                else
                {
                    OtherButtons();
                }
            }
        }
        private void ButtonFive()
        {
            if (btn2.Text == btn5.Text && btn8.Text == "")
            {
                btn8.Text = "O";
                btn8.Enabled = false;
            }
            else if (btn8.Text == btn5.Text && btn2.Text == "")
            {
                btn2.Text = "O";
                btn2.Enabled = false;
            }
            else if (btn6.Text == btn5.Text && btn4.Text == "")
            {
                btn4.Text = "O";
                btn4.Enabled = false;
            }
            else if (btn4.Text == btn5.Text && btn6.Text == "")
            {
                btn6.Text = "O";
                btn6.Enabled = false;
            }
            else if (btn9.Text == btn5.Text && btn1.Text == "")
            {
                btn1.Text = "O";
                btn1.Enabled = false;
            }
            else if (btn1.Text == btn5.Text && btn9.Text == "")
            {
                btn9.Text = "O";
                btn9.Enabled = false;
            }
            else if (btn7.Text == btn5.Text)
            {
                if (btn4.Text == "")
                {
                    btn4.Text = "O";
                    btn4.Enabled = false;
                }
                else if (btn8.Text == "")
                {
                    btn8.Text = "O";
                    btn8.Enabled = false;
                }
                else if (btn2.Text == "")
                {
                    btn2.Text = "O";
                    btn2.Enabled = false;
                }
            }
        }
        private void OtherButtons()
        {
            if (btn3.Text == "" && (btn1.Text == "X" && btn2.Text == "X"))
            {
                btn3.Text = "O";
                btn3.Enabled = false;
            }
            else if (btn2.Text == "" && (btn1.Text == "X" && btn3.Text == "X"))
            {
                btn2.Text = "O";
                btn2.Enabled = false;
            }
            else if (btn1.Text == "" && (btn2.Text == "X" && btn3.Text == "X"))
            {
                btn1.Text = "O";
                btn1.Enabled = false;
            }


            else if (btn7.Text == "" && (btn1.Text == "X" && btn4.Text == "X"))
            {
                btn7.Text = "O";
                btn7.Enabled = false;
            }
            else if (btn4.Text == "" && (btn1.Text == "X" && btn7.Text == "X"))
            {
                btn4.Text = "O";
                btn4.Enabled = false;
            }
            else if (btn1.Text == "" && (btn4.Text == "X" && btn7.Text == "X"))
            {
                btn1.Text = "O";
                btn1.Enabled = false;
            }


            else if (btn9.Text == "" && (btn3.Text == "X" && btn6.Text == "X"))
            {
                btn9.Text = "O";
                btn9.Enabled = false;
            }
            else if (btn6.Text == "" && (btn3.Text == "X" && btn9.Text == "X"))
            {
                btn6.Text = "O";
                btn6.Enabled = false;
            }
            else if (btn3.Text == "" && (btn6.Text == "X" && btn9.Text == "X"))
            {
                btn3.Text = "O";
                btn3.Enabled = false;
            }


            else if (btn9.Text == "" && (btn7.Text == "X" && btn8.Text == "X"))
            {
                btn9.Text = "O";
                btn9.Enabled = false;
            }
            else if (btn8.Text == "" && (btn9.Text == "X" && btn7.Text == "X"))
            {
                btn8.Text = "O";
                btn8.Enabled = false;
            }
            else if (btn7.Text == "" && (btn8.Text == "X" && btn9.Text == "X"))
            {
                btn7.Text = "O";
                btn7.Enabled = false;
            }
            else
            {
                if (btn2.Text == "")
                {
                    btn2.Text = "O";
                    btn2.Enabled = false;
                }
                else if (btn8.Text == "")
                {
                    btn8.Text = "O";
                    btn8.Enabled = false;
                }
                else if (btn4.Text == "")
                {
                    btn4.Text = "O";
                    btn4.Enabled = false;
                }
                else if (btn6.Text == "")
                {
                    btn6.Text = "O";
                    btn6.Enabled = false;
                }
                else
                {
                    if (btn1.Text == "")
                    {
                        btn1.Text = "O";
                        btn1.Enabled = false;
                    }
                    else if (btn3.Text == "")
                    {
                        btn3.Text = "O";
                        btn3.Enabled = false;
                    }
                    else if (btn7.Text == "")
                    {
                        btn7.Text = "O";
                        btn7.Enabled = false;
                    }
                    else if (btn6.Text == "")
                    {
                        btn9.Text = "O";
                        btn9.Enabled = false;
                    }
                }
            }
        }
    }
}