using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MasterMind1._0
{
    
    class SpriteCutter  
    {

        private Image img;
        private Bitmap frame;
        private int spriteWidth;
        private int spriteHeight;
        private int currentFrame;
        private int direction;



        public SpriteCutter(Image img, int frameSize, int dir, int curfrm)
        {
            this.img = img;
            spriteHeight = frameSize;
            spriteWidth = frameSize;
            direction = dir;
            currentFrame = curfrm;

            cutFrame(img, currentFrame);
        }

        public void cutFrame(Image img, int frm)
        {
            Rectangle frameSource = new Rectangle(frm * spriteWidth, direction * spriteHeight, spriteWidth, spriteHeight);
            frame = new Bitmap(spriteWidth, spriteHeight);
            Graphics g = Graphics.FromImage(frame);
            g.DrawImage(img, 0, 0, frameSource, GraphicsUnit.Pixel);
            g.Dispose();
        }

        public Image getFrame
        {
            get { return frame; }
        }








    }
}