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

namespace Games_Hub
{
    public partial class chickenInvaders1 : Form
    {
        public chickenInvaders1()
        {
            InitializeComponent();
        }

        int[] targetColor = { 255, 255, 255 }; //white
        int red, green, blue;//basic colors
        Boolean faded; //to know if the text is visable or not
        SoundPlayer backSound = new SoundPlayer(Games_Hub.Properties.Resources.Sound_track);//to plat the sound track

     
        void fadeOut()
        {
            //change the three basic colors to make the fade out effict
            red = pressTxt.ForeColor.R;
            green = pressTxt.ForeColor.G;
            blue = pressTxt.ForeColor.B;
            //
            //turning the basic colors gradually into the background color 
            if (red > this.BackColor.R)
                red--;
            else if (red < this.BackColor.R)
                red++;
            if (green > this.BackColor.G)
                green--;
            else if (green < this.BackColor.G)
                green++;
            if (blue > this.BackColor.B)
                blue--;
            else if (blue < this.BackColor.B)
                blue++;
            if (red == this.BackColor.R && green == this.BackColor.G && blue == this.BackColor.B)
                faded = true; //text is not visable (text color = background color)
            //
            //set the new color as font color
            pressTxt.ForeColor = Color.FromArgb(red, green, blue);

        }


        void fadeIn()
        {
            //change the three basic colors to make the fade in effict
            red = pressTxt.ForeColor.R;
            green = pressTxt.ForeColor.G;
            blue = pressTxt.ForeColor.B;
            //
            //turning the basic color gradually into white (original font color) 
            if (red > targetColor[0])
                red--;
            else if (red < targetColor[0])
                red++;
            if (green > targetColor[1])
                green--;
            else if (green < targetColor[1])
                green++;
            if (blue > targetColor[2])
                blue--;
            else if (blue < targetColor[2])
                blue++;
            if (red == targetColor[0] && green == targetColor[1] && blue == targetColor[2])
                faded = false;//text is visable (text color = white)
            //
            //set the new color as font color
            pressTxt.ForeColor = Color.FromArgb(red, green, blue);


        }
        private void chickenInvaders1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    {
                        //
                        //hide the current form an show the game form and stop the sound track
                        base.Hide();
                        chickenInvaders2 ch2 = new chickenInvaders2();
                        ch2.Show();
                        backSound.Stop();
                    }
                    break;
                case Keys.Escape:
                    {
                        //
                        //return to the main menu
                        this.Close();
                        menuform menu1 = new menuform();
                        menu1.Show();
                    }
                   break;
            }
        }
        private void chickenInvaders1_Load(object sender, EventArgs e)
        {
            backSound.Play();//plat the sound track when form show up
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (faded)//if the text color = the back ground it will start changing to white
            {
                fadeIn();
            }
            else//if the text color = white it will start changing to back ground color
            {
                fadeOut();
            }
        }
    }
}
