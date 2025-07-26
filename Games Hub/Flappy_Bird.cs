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
    public partial class Flappy_Bird : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        int highscore = 0;
        int id = 0;

        public Flappy_Bird()
        {
            InitializeComponent();
        }


        private void endGame()//display score and show "game over"when the game is end
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over !!! ";
            if (scoresTableAdapter.GetFlappyScore(id) < score)
            {
                highscorelabel1.Text = "high Score :" + score.ToString();
            }
            if (scoresTableAdapter.GetFlappyScore(id) == null)
            {
                scoresTableAdapter.InsertQueryScores(id, 0, score, 0, 0);
            }
            else if (score > scoresTableAdapter.GetFlappyScore(id))
            {
                scoresTableAdapter.UpdateQueryFlappyBirdScore(score, id);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)//this fucnction control the speed of pipes and birds and make the pipes respawn
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            scoreText.Text = " score : " + score;
            highscorelabel1.Text = "high Score :" + scoresTableAdapter.GetFlappyScore(id);

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
                if (score > highscore)
                    highscore = score;
            }
            if (pipeBottom2.Left < -150)
            {
                pipeBottom2.Left = 800;
                score++;
                if (score > highscore)
                    highscore = score;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
                if (score > highscore)
                    highscore = score;
            }
            if (pipeTop2.Left < -180)
            {
                pipeTop2.Left = 950;
                score++;
                if (score > highscore)
                    highscore = score;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 14;
            }

            if (score > 20)
            {
                pipeSpeed = 27;
            }

            if (flappyBird.Top < -25)
            {
                endGame();
            }

        }

        private void Flappy_Bird_KeyUp(object sender, KeyEventArgs e)//when you hold space btn the bird go up 
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }

        }

        private void Flappy_Bird_KeyDown(object sender, KeyEventArgs e)//when you realse the space btn the bird go down
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    gravity = -5;
                    break;
                case Keys.Escape:
                    this.Close();
                    menuform menu1 = new menuform();
                    menu1.Show();
                    break;
            }
        }

        private void accountsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Flappy_Bird_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.scores' table. You can move, or remove it, as needed.
            //this.scoresTableAdapter.Fill(this.database1DataSet.scores);
            // TODO: This line of code loads data into the 'database1DataSet.accounts' table. You can move, or remove it, as needed.
            //this.accountsTableAdapter.Fill(this.database1DataSet.accounts);
            id = (int)accountsTableAdapter.GetID(loogInForm.UserName);

        }
    }

}
