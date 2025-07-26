using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games_Hub
{
    class pic : PictureBox
    {
       public int picNum = new int();//to check what photo is in a picture box
        public pic(int w, int h)
        {
            Width = w;
            Height = h;
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Transparent;
            picNum = 1;
        }
    }
}
