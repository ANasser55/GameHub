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
    public partial class menuform : Form
    {
        public menuform()
        {
            InitializeComponent();
        }
        private void movepanel(Control btn)
        {
            panelslide.Width = btn.Width;
            panelslide.Left = btn.Left;
            

        }

        private void game_btn_Click(object sender, EventArgs e)
        {
            movepanel(games_btn);

        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            movepanel(help_btn);
            MessageBox.Show("1-It is a fixed shooter, reminiscent of the original Space Invaders (of which the game is a parody of)," +
                " in which the player controls a lone spacecraft by moving it horizontally across the bottom of the screen and firing at" +
                " swarms of invading extraterrestrial chickens. \n" +
                "2-a game in which two players alternately put Xs and Os in" +
                " compartments of a figure formed by two vertical lines crossing two horizontal lines" +
                " and each tries to get a row of three Xs or three Os before the opponent does.\n" +
                "3-On a Scale of One to T-Rex is a family-friendly party game for people who are bad a" +
                "t charades. Players must perform ridiculous actions like Be a T - Rex or Scratch an Itch You Cant Reach" +
                " on a scale of 1 to 10. The twist is that the quality of your action doesn't matter.\n" +
                "4-The game was released in May 2013 but received a sudden rise in popularity in early 2014" +
                " and became a sleeper hit. Flappy Bird received poor reviews from some critics, who criticized its" +
                " high level of difficulty and alleged plagiarism in graphics and game mechanics, while other" +
                " reviewers found it addictive. At the end of January 2014, it was the most-downloaded free game" +
                " in the App Store for iOS. During this period, its developer said that Flappy Bird was earning $50,000" +
                " a day from in-app advertisements as well as sales.\n" +
                "5-The third game is word guessing its smart and a thought provoking game that test the user intellect and grabs");

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            movepanel(exit_btn);
            System.Windows.Forms.Application.ExitThread();
        }

        private void games_btn_MouseMove(object sender, MouseEventArgs e)
        {
            gamespanel.Visible = true;
        }

        private void SlidePic_MouseMove(object sender, MouseEventArgs e)
        {
            gamespanel.Visible = false;
        }


        private void chickeninvaders_btn_MouseMove(object sender, MouseEventArgs e)
        {
            arrow1.Visible = true;
            pic1.Visible = true;
        }

        private void chickeninvaders_btn_MouseLeave(object sender, EventArgs e)
        {
            arrow1.Visible = false;
            pic1.Visible = false;
        }

        private void xo_btn_MouseMove(object sender, MouseEventArgs e)
        {
            arrow2.Visible = true;
            pic2.Visible = true;
        }

        private void xo_btn_MouseLeave(object sender, EventArgs e)
        {
            arrow2.Visible = false;
            pic2.Visible = false;
        }

        private void flappybird_btn_MouseMove(object sender, MouseEventArgs e)
        {
            arrow3.Visible = true;
            pic3.Visible = true;
        }

        private void flappybird_btn_MouseLeave(object sender, EventArgs e)
        {
            arrow3.Visible = false;
            pic3.Visible = false;
        }

        private void word_btn_MouseMove(object sender, MouseEventArgs e)
        {
            arrow4.Visible = true;
            pic4.Visible = true;
        }

        private void word_btn_MouseLeave(object sender, EventArgs e)
        {
            arrow4.Visible = false;
            pic4.Visible = false;
        }

        private void trex_btn_MouseMove(object sender, MouseEventArgs e)
        {
            arrow5.Visible = true;
            pic5.Visible = true;
        }

        private void trex_btn_MouseLeave(object sender, EventArgs e)
        {
            arrow5.Visible = false;
            pic5.Visible = false;
        }

        private void chickeninvaders_btn_Click(object sender, EventArgs e)
        {
            chickenInvaders1 ck1 = new chickenInvaders1();
            this.Hide();
            ck1.Show();
        }

        private void xo_btn_Click(object sender, EventArgs e)
        {
            XO xo1 = new XO();
            this.Hide();
            xo1.Show();
        }

        private void flappybird_btn_Click(object sender, EventArgs e)
        {
            Flappy_Bird fl1 = new Flappy_Bird();
            this.Hide();
            fl1.Show();
        }

        private void word_btn_Click(object sender, EventArgs e)
        {
            wordGuess1 wr1 = new wordGuess1();
            this.Hide();
            wr1.Show();
        }

        private void trex_btn_Click(object sender, EventArgs e)
        {
            tRex tr1 = new tRex();
            this.Hide();
            tr1.Show();
        }
    }
}
