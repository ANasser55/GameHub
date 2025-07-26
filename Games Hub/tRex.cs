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
    public partial class tRex : Form
    {
        int id = 0;
        bool jumping = false; // boolean to check if player is jumping or not
        int jumpSpeed; // integer to set jump speed
        int force = 12; // force of the jump in an integer
        int score = 0; // default score integer set to 0
        int obstacleSpeed = 10; // the default speed for the obstacles
        Random rnd = new Random(); // create a new random class
        int position;
        bool isGameover = false;
        private object rand;


        public tRex()
        {
            InitializeComponent();
        }

        private void restGame()
        {
            // This is the reset function
            force = 12; // set the force to 8
            jumpSpeed = 0; // set the jump speed to 0
            jumping = false; // change jumping to false
            score = 0; // set score to 0
            obstacleSpeed = 10; // set obstacle speed back to 10
            scoreLabel.Text = "Score: " + score; // change the score text to just show the score
            running.Image = Properties.Resources.running; // change the t rex image to running
            isGameover = false;
            running.Top = 367;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rnd.Next(10, 100) + (x.Width * 10);
                    x.Left = position;
                }
            }

            gameTm.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            running.Top += jumpSpeed;
            scoreLabel.Text = "Score: " + score;
            highscorelabel1.Text = "high Score :" + scoresTableAdapter.GetRexScore(id);
            // if jumping is true and force is less than 0
            // then change jumping to false
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            // if jumping is true
            // then change jump speed to -12 
            // reduce force by 1
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                // else change the jump speed to 12
                jumpSpeed = 12;
            }

            if (running.Top > 366 && jumping == false)
            {
                force = 12;
              //  running.Top = 367;
                jumpSpeed = 0;

            }

            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of obstacle
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; // move the obstacles towards the left

                    if (x.Left < -100)
                    {

                        x.Left = this.ClientSize.Width + rnd.Next(200, 500) + (x.Width * 15);

                        score++;
                    }

                    if (running.Bounds.IntersectsWith(x.Bounds))
                    {
                        // we stop the timer
                        gameTm.Stop();
                        // change the t rex image to the dead one
                        running.Image = Properties.Resources.dead;
                        // show press r to restart on the score text label
                        scoreLabel.Text += "  Press R to restart";
                        if (scoresTableAdapter.GetRexScore(id) < score)
                        {
                            highscorelabel1.Text = "high Score :" + score.ToString();
                        }
                        if (scoresTableAdapter.GetRexScore(id) == null)
                        {
                            scoresTableAdapter.InsertQueryScores(id, 0, 0, 0, score);
                        }
                        else if (score > scoresTableAdapter.GetRexScore(id))
                        {
                            scoresTableAdapter.UpdateQueryRexScore(score, id);
                        }
                        isGameover = true;
                    }
                }
            }

        }

        private void tRex_KeyUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            if (e.KeyCode == Keys.R && isGameover == true)
            {
                restGame();
            }
        }

        private void tRex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                menuform menu1 = new menuform();
                menu1.Show();
            }

            
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void accountsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void accountsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void tRex_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.database1DataSet.scores);
            // TODO: This line of code loads data into the 'database1DataSet.accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.database1DataSet.accounts);
            id = (int)accountsTableAdapter.GetID(loogInForm.UserName);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
