using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Games_Hub
{
    public partial class chickenInvaders2 : Form
    {
        int id = 0;
        public chickenInvaders2()
        {
            InitializeComponent();
        }

       

        PictureBox[] chickens = new PictureBox[24];//to store chickens 
        PictureBox[] hearts = new PictureBox[3];//store hearts
        string distnasion = "left";//the direction of chickens movment
        //
        //sound effects
        SoundPlayer laserBeam = new SoundPlayer(Games_Hub.Properties.Resources.Laser_Beam);
        SoundPlayer explosion = new SoundPlayer(Games_Hub.Properties.Resources.Explosion_sound);
        SoundPlayer hit = new SoundPlayer(Games_Hub.Properties.Resources.Chicken_hit);
        //
        int timeSec;//counter that increase by 1 every second
        //
        //lists of type pic to store the run time generated picture boxes
        List<pic> blasts = new List<pic>();
        List<pic> eggs = new List<pic>();
        //
        Random rd = new Random();//generate a random number represents which chicken will drop an egg
        int randEgg;//the random number i menetiond (:
        int lives = 3;
        int score, deadChickens = 0;



        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.database1DataSet.accounts);
            // TODO: This line of code loads data into the 'database1DataSet.scores' table. You can move, or remove it, as needed.
            this.scoresTableAdapter.Fill(this.database1DataSet.scores);

            id = (int)accountsTableAdapter.GetID(loogInForm.UserName);//get the id of the player from data base
            highScorelabel.Text = "high Score: " + scoresTableAdapter.GetchickenScore(id);//set the high score to the high score stored in data base
            
           //
           //add chickens to the array
            chickens[0] = c1;
            chickens[1] = c2;
            chickens[2] = c3;
            chickens[3] = c4;
            chickens[4] = c5;
            chickens[5] = c6;
            chickens[6] = c7;
            chickens[7] = c8;
            chickens[8] = c9;
            chickens[9] = c10;
            chickens[10] = c11;
            chickens[11] = c12;
            chickens[12] = c13;
            chickens[13] = c14;
            chickens[14] = c15;
            chickens[15] = c16;
            chickens[16] = c17;
            chickens[17] = c18;
            chickens[18] = c19;
            chickens[19] = c20;
            chickens[20] = c21;
            chickens[21] = c22;
            chickens[22] = c23;
            chickens[23] = c24;
            //
            //
            //add hearts to array
            hearts[0] = heart1;
            hearts[1] = heart2;
            hearts[2] = heart3;
            //
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                //
                //move the space ship
                case Keys.Up:
                    spaceShip.Top -= 10;
                    break;
                case Keys.Down:
                    spaceShip.Top += 10;
                    break;
                case Keys.Left:
                    spaceShip.Left -= 10;
                    break;
                case Keys.Right:
                    spaceShip.Left += 10;
                    break;
                //
                case Keys.Space://fire blasts
                    laserBeam.Play();
                    fire();
                    break;
                case Keys.Escape:
                    {
                        //
                        //return to main menu
                        this.Close();
                        menuform menu1 = new menuform();
                        menu1.Show();
                        //
                    }
                    break;

            }
        }

        private void fire()
        {
            pic blast = new pic(17, 25);//generate a new picture box with size (17, 25)
            blast.Left = spaceShip.Left + spaceShip.Width / 2 - 9;//set the picture location to the middle of the space ship
            blast.Top = spaceShip.Top - 22;//set the picture location to the top of the space ship
            blast.Image = Games_Hub.Properties.Resources.Laser;//add leaser image to the picture box
            blasts.Add(blast);//add this picture box to balsts list  
            Controls.Add(blast);//show the picture box

        }

        private void secTimer_Tick(object sender, EventArgs e)
        {
            timeSec++;//increment by 1 every second

            if (timeSec > 1)//restore the ship if it is exploded
            {
                spaceShip.Image = Games_Hub.Properties.Resources.Spaceship;
            }

        }

        private void dropEgg_Tick(object sender, EventArgs e)
        {
            randEgg = rd.Next(0, 23);
            while(!chickens[randEgg].Visible)//if the chicken dropping the egg is not visible (dead) pic anoter one
            {
                randEgg = rd.Next(0, 23);
            }

                pic egg = new pic(15, 18);//generate new picture box 
                egg.Image = Games_Hub.Properties.Resources.Egg;//add egg image
                egg.Left = chickens[randEgg].Left + chickens[randEgg].Width / 2 - egg.Width / 2;//set location
                egg.Top = chickens[randEgg].Top + chickens[randEgg].Height;
                egg.BringToFront();
                Controls.Add(egg);
                eggs.Add(egg);//add to the egg list

           



        }

        private void scoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.scoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Movment_Tick(object sender, EventArgs e)
        {
            if (scoresTableAdapter.GetchickenScore(id) < score)//change the high score label if the player broke it
            {
                highScorelabel.Text = "high Score :" + score.ToString();
            }
            if (scoresTableAdapter.GetchickenScore(id) == null)//if id is Null (user didint play any game) 
            {
                scoresTableAdapter.InsertQueryScores(id, score, 0, 0, 0);//chicken invaders is the firist game he play so it will insert id and chicken invaders score , other games scors will be 0
            }
            else if (score > scoresTableAdapter.GetchickenScore(id))//id is not Null that means he played a game before and score higher than stored in data base
            {
                scoresTableAdapter.UpdateQueryChickenScore(score, id);//search for this id's chicken invaders score the update it with the new high score
            }

            //
            //chicken movment
            //
            if (chickens[0].Location.X > 60 && distnasion == "left")//move to left
            {
                for (int i = 0; i < 24; i++)
                {

                    chickens[i].Left -= 10;
                }

            }
            else if (chickens[7].Location.X < 1005)//change the direction
            {
                distnasion = "right";
                for (int i = 0; i < 24; i++)
                {

                    chickens[i].Left += 10;
                }

                if (chickens[7].Location.X > 1000)
                {
                    distnasion = "left";
                }

            }
            //
            //laser movment
            //
            for (int i = 0; i < blasts.Count; i++)
            {

                blasts[i].Top -= 20;
                for (int j=0; j<24; j++) 
                {
                    if(blasts[i].Bounds.IntersectsWith(chickens[j].Bounds) && chickens[j].Visible && blasts[i].Visible)//check if laser intersect with a chicken
                    {
                        hit.Play();
                        chickens[j].Hide();
                        blasts[i].Hide();
                        score += 10;
                        deadChickens++;
                        scoreLable.Text = "Score:" + score.ToString();
                        scoreLable.Text = "Score:" + score.ToString();
                        break;
                    }

                }

                if(blasts[i].Top==0)
                {
                    blasts.Remove(blasts[i]);//remove the blasts when it reach the top of screen
                }

               
            }
            if (deadChickens == 24)//all chickens are dead
            {
                deadChickens = 0;
                timeSec = 0;
                gameOver.Text = "You won \n Be Ready for the next level";
                gameOver.Visible = true;
            }
            if (timeSec > 3 && deadChickens == 0)//make the chickens visible and start the next level
            {
                gameOver.Visible = false;
                for (int i = 0; i < 24; i++)
                {
                    chickens[i].Visible = true;
                }
            }
            //
            //egg movment
            //
            for (int i = 0; i < eggs.Count; i++)
            {
                if (eggs[i].Location.Y < 555)//droping down
                {
                    eggs[i].Top += 15;

                }
                else if (eggs[i].picNum == 1)//picNum1 = egg //picNum2 = broken egg so if the egg reaches the screen bottom cnage image to broken egg
                {
                    eggs[i].Image = Games_Hub.Properties.Resources.Broken_Egg;
                    eggs[i].picNum = 2;
                    eggs[i].Height = 16;
                    eggs[i].Width = 32;
                    timeSec = 0;

                }

                if (eggs[i].picNum == 2 && timeSec > 3)//hide the broken egg after 3 sec
                {
                    eggs[i].Hide();
                }

                    if (spaceShip.Bounds.IntersectsWith(eggs[i].Bounds) && eggs[i].Visible && eggs[i].picNum == 1)//if egg intersected with the space ship image will change to explosion
                {
                    timeSec = 0;
                    eggs[i].Hide();
                    explosion.Play();
                    spaceShip.Image = Games_Hub.Properties.Resources.Explosion;
                    lives--;
                    hearts[lives].Hide();
                    if (lives == 0)
                    {
                        movmentTimer.Stop();
                        secTimer.Stop();
                        dropEgg.Stop();
                        gameOver.Text = "GAME OVER";
                        gameOver.Visible = true;
                    }
                }
            }

        }





    }
}
