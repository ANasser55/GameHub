using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Hub
{
    public partial class XO : Form
    {
        public XO()
        {
            InitializeComponent();
        }
        public int player = 2;
        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;//when X win the label X win will increase 1 
            OWin.Text = "O: " + s2;//when O win the label O win will increase 1
            Draws.Text = "Draws: " + sd;//when the match is draw the draw label will increase 1

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "")
            {
                if (player % 2 == 0)
                {
                    button.Text = "X";//player turn X
                    player++;
                    turns++;

                }
                else
                {
                    button.Text = "O";//player turn O
                    player++;
                    turns++;
                }
                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game");
                    sd++;
                    NewGame();
                }
                if(CheckWinner()==true)//this will check if the game is draw will display a message box "Tie Game"
                {
                    if(button.Text=="X")
                    {
                        MessageBox.Show("X won");//this will check if the game is Xwin will display a message box "X win"
                        s1++;
                        NewGame();


                    }
                    else
                    {
                        MessageBox.Show("O won");//this will check if the game is Owin will display a message box "O win"
                        s2++;
                        NewGame();

                    }
                }
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)//exit button to close the appliaction
        {
            this.Close();
            menuform menu1 = new menuform();
            menu1.Show();
        }
        void NewGame()//this will reset all the button to start new game
        {
           player = 2;
           turns = 0;
           A1.Text = A2.Text = A3.Text = B1.Text = B2.Text = B3.Text = C1.Text = C2.Text = C3.Text = "";
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }
        private void newgame_btn_Click(object sender, EventArgs e)//this button that call the function newgame
        {
            NewGame();
        }
        bool CheckDraw()//this function called check draw to check draw games
        {
            if ((turns == 9)&&CheckWinner()==false)
                return true;
            else
                return false;
        }
        bool CheckWinner()//function to check the winner
        {
            //horizintal checks
            if((A1.Text==A2.Text) && (A2.Text==A3.Text)&&A1.Text !="")
                return true;
          
            else if((B1.Text == B2.Text) && (B2.Text == B3.Text) && B1.Text != "")
                return true;
           

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && C1.Text != "")
                return true;
            

            //vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && A1.Text != "")
                return true;
           

            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && A2.Text != "")
                return true;
            

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && A3.Text != "")
                return true;
            

            //diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && A1.Text != "")
                return true;
            

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && A3.Text != "")
                return true;
            

            else
                return false;

        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void XO_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    menuform menu1 = new menuform();
                    menu1.Show();
                    break;
            }
        }
    }
}
    