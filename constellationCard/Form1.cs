﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace constellationCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundClick(object sender, MouseEventArgs e)
        {
            //sets up everything needed to draw graphics
            Graphics formGraphics = this.CreateGraphics();
            Pen orangePen = new Pen(Color.Orange, 3);
            SolidBrush hotPinkBrush = new SolidBrush(Color.HotPink);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            Font sansFont = new Font("Comic Sans MS", 9);
            Font sansLarge = new Font("Comic Sans MS", 15, FontStyle.Bold);

            //wipes everything that was there and sets the background to white
            titleLabel.Dispose();
            nameLabel.Dispose();
            dateLabel.Dispose();
            formGraphics.Clear(Color.Black);

            //draws stars for constellations, with a half second wait before each start appears
            Thread.Sleep(500);
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 - 95, 155, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 - 92, 102, 10, 10);
            Thread.Sleep(500);
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 + 70, 82, 10, 10);

            //waits for 1.5 seconds then draws lines between the stars 
            Thread.Sleep(1500);
            formGraphics.DrawLine(orangePen, this.Width / 2 - 90, 160, this.Width / 2 - 87, 107);
            formGraphics.DrawLine(orangePen, this.Width / 2 - 87, 107, this.Width / 2 + 75, 87);
            formGraphics.DrawLine(orangePen, this.Width / 2 + 75, 87, this.Width / 2 - 90, 160);

            //re draws the "stars" so that they appear above the lines
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 - 95, 155, 10, 10);
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 - 92, 102, 10, 10);
            formGraphics.FillEllipse(yellowBrush, this.Width / 2 + 70, 82, 10, 10);

            //waits a second, then displays my text one line at a time with a .25 second pause inbetween each line
            Thread.Sleep(1000);
            formGraphics.DrawString("The Triangulum Constellation", sansLarge, hotPinkBrush, 5, 250);
            Thread.Sleep(250);
            formGraphics.DrawString("Triangulum has had many names, most of which", sansFont, whiteBrush, 10, 275);
            Thread.Sleep(250);
            formGraphics.DrawString("have something to do with triangles. The Romans", sansFont, whiteBrush, 10, 290);
            Thread.Sleep(250);
            formGraphics.DrawString("called it sicilia, due to its resemblance to the", sansFont, whiteBrush, 10, 305);
            Thread.Sleep(250);
            formGraphics.DrawString("triangular island of Sicily. The Babylonians", sansFont, whiteBrush, 10, 320);
            Thread.Sleep(250);
            formGraphics.DrawString("called it \"The Plow\", however this constellation", sansFont, whiteBrush, 10, 335);
            Thread.Sleep(250);
            formGraphics.DrawString("contains another star called Gamma Andromodae.", sansFont, whiteBrush, 10, 350);
        }
    }
}
