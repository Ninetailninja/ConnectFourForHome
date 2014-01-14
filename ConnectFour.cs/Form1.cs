using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1.cs
{
    public partial class Form1 : Form
    {
        public bool turnRed = true;
        public int fill1 = 0;
        public int fill2 = 0;
        public int fill3 = 0;
        public int fill4 = 0;
        public int fill5 = 0;
        public int fill6 = 0;
        public int fill7 = 0;
        public int win = 0;

        #region PieceCoordinates
        public int x1y1;
        public int x1y2;
        public int x1y3;
        public int x1y4;
        public int x1y5;
        public int x1y6;
        public int x2y1;
        public int x2y2;
        public int x2y3;
        public int x2y4;
        public int x2y5;
        public int x2y6;
        public int x3y1;
        public int x3y2;
        public int x3y3;
        public int x3y4;
        public int x3y5;
        public int x3y6;
        public int x4y1;
        public int x4y2;
        public int x4y3;
        public int x4y4;
        public int x4y5;
        public int x4y6;
        public int x5y1;
        public int x5y2;
        public int x5y3;
        public int x5y4;
        public int x5y5;
        public int x5y6;
        public int x6y1;
        public int x6y2;
        public int x6y3;
        public int x6y4;
        public int x6y5;
        public int x6y6;
        public int x7y1;
        public int x7y2;
        public int x7y3;
        public int x7y4;
        public int x7y5;
        public int x7y6;
        #endregion PieceCoordinates

        public Form1()
        {
            InitializeComponent();

            if (win == 1)
            {
                label1.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }
            if (win == 2)
            {
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }
                
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Blue);

            Brush b = new SolidBrush(Color.Blue);
            Brush bW = new SolidBrush(Color.White);

            Graphics g;
            g = this.CreateGraphics();

            //The Board
            int rowX = 50;
            int rowY = 50;

            for (int i = 0; i <= 7; i++)
            {
                g.FillRectangle(b, rowX, 50, 25, 500);
                rowX += 75;
            }

            for (int i = 0; i <= 6; i++)
            {
                g.FillRectangle(b, 50, rowY, 550, 25);
                rowY += 75;
            }

            g.FillRectangle(b, 50, 525, 550, 25);

        }

        public int didYouWin(bool tR, int x, int y)
        {
            #region CheckRow1
            //Checks Row 1 for a win
            if (tR == true & x == 1 & y == 1)
            {
                if (x1y1 == 1 & x1y2 == 1 & x1y3 == 1 & x1y4 == 1)
                    return win = 1;
                if (x1y1 == 1 & x2y1 == 1 & x3y1 == 1 & x4y1 == 1)
                    return win = 1;
                if (x1y1 == 1 & x2y2 == 1 & x3y3 == 1 & x4y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 1)
            {
                if (x1y1 == 2 & x1y2 == 2 & x1y3 == 2 & x1y4 == 2)
                    return win = 2;
                if (x1y1 == 2 & x2y1 == 2 & x3y1 == 2 & x4y1 == 2)
                    return win = 2;
                if (x1y1 == 2 & x2y2 == 2 & x3y3 == 2 & x4y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 1 & y == 2)
            {
                if (x1y2 == 1 & x1y3 == 1 & x1y4 == 1 & x1y5 == 1)
                    return win = 1;
                if (x1y2 == 1 & x2y2 == 1 & x3y2 == 1 & x4y2 == 1)
                    return win = 1;
                if (x1y2 == 1 & x2y3 == 1 & x3y4 == 1 & x4y5 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 2)
            {
                if (x1y2 == 2 & x1y3 == 2 & x1y4 == 2 & x1y5 == 2)
                    return win = 2;
                if (x1y2 == 2 & x2y2 == 2 & x3y2 == 2 & x4y2 == 2)
                    return win = 2;
                if (x1y2 == 2 & x2y3 == 2 & x3y4 == 2 & x4y5 == 2)
                    return win = 2;
            }
            if (tR == true & x == 1 & y == 3)
            {
                if (x1y3 == 1 & x1y4 == 1 & x1y5 == 1 & x1y6 == 1)
                    return win = 1;
                if (x1y3 == 1 & x2y3 == 1 & x3y3 == 1 & x4y3 == 1)
                    return win = 1;
                if (x1y3 == 1 & x2y4 == 1 & x3y5 == 1 & x4y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 3)
            {
                if (x1y3 == 2 & x1y4 == 2 & x1y5 == 2 & x1y6 == 2)
                    return win = 2;
                if (x1y3 == 2 & x2y3 == 2 & x3y3 == 2 & x4y3 == 2)
                    return win = 2;
                if (x1y3 == 2 & x2y4 == 2 & x3y5 == 2 & x4y6 == 2)
                    return win = 2;
            }
            if (tR == true & x == 1 & y == 4)
            {
                if (x1y1 == 1 & x1y2 == 1 & x1y3 == 1 & x1y4 == 1)
                    return win = 1;
                if (x1y4 == 1 & x2y4 == 1 & x3y4 == 1 & x4y4 == 1)
                    return win = 1;
                if (x1y4 == 1 & x2y3 == 1 & x3y2 == 1 & x4y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 4)
            {
                if (x1y1 == 2 & x1y2 == 2 & x1y3 == 2 & x1y4 == 2)
                    return win = 2;
                if (x1y4 == 2 & x2y4 == 2 & x3y4 == 2 & x4y4 == 2)
                    return win = 2;
                if (x1y4 == 2 & x2y3 == 2 & x3y2 == 2 & x4y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 1 & y == 5)
            {
                if (x1y2 == 1 & x1y3 == 1 & x1y4 == 1 & x1y5 == 1)
                    return win = 1;
                if (x1y5 == 1 & x2y5 == 1 & x3y5 == 1 & x4y5 == 1)
                    return win = 1;
                if (x1y5 == 1 & x2y4 == 1 & x3y3 == 1 & x4y2 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 5)
            {
                if (x1y2 == 2 & x1y3 == 2 & x1y4 == 2 & x1y5 == 2)
                    return win = 2;
                if (x1y5 == 2 & x2y5 == 2 & x3y5 == 2 & x4y5 == 2)
                    return win = 2;
                if (x1y5 == 2 & x2y4 == 2 & x3y3 == 2 & x4y2 == 2)
                    return win = 2;
            }
            if (tR == true & x == 1 & y == 6)
            {
                if (x1y3 == 1 & x1y4 == 1 & x1y5 == 1 & x1y6 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y6 == 1 & x3y6 == 1 & x4y6 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y5 == 1 & x3y4 == 1 & x4y3 == 1)
                    return win = 1;
            }
            if (tR == false & x == 1 & y == 6)
            {
                if (x1y3 == 2 & x1y4 == 2 & x1y5 == 2 & x1y6 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y6 == 2 & x3y6 == 2 & x4y6 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y5 == 2 & x3y4 == 2 & x4y3 == 2)
                    return win = 2;
            }
            #endregion Checkrow1

            #region Checkrow2
            if (tR == true & x == 2 & y == 1)
            {
                if (x1y1 == 1 & x2y1 == 1 & x3y1 == 1 & x4y1 == 1)
                    return win = 1;
                if (x2y1 == 1 & x3y1 == 1 & x4y1 == 1 & x5y1 == 1)
                    return win = 1;
                if (x2y1 == 1 & x3y2 == 1 & x4y3 == 1 & x5y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 1)
            {
                if (x1y1 == 2 & x2y1 == 2 & x3y1 == 2 & x4y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y1 == 2 & x4y1 == 2 & x5y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y2 == 2 & x4y3 == 2 & x5y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 2 & y == 2)
            {
                if (x1y2 == 1 & x2y2 == 1 & x3y2 == 1 & x4y2 == 1)
                    return win = 1;
                if (x2y2 == 1 & x3y2 == 1 & x4y2 == 1 & x5y2 == 1)
                    return win = 1;
                if (x2y2 == 1 & x3y3 == 1 & x4y4 == 1 & x5y5 == 1)
                    return win = 1;
                if (x1y1 == 1 & x2y2 == 1 & x3y3 == 1 & x4y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 2)
            {
                if (x1y1 == 2 & x2y1 == 2 & x3y1 == 2 & x4y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y1 == 2 & x4y1 == 2 & x5y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y2 == 2 & x4y3 == 2 & x5y4 == 2)
                    return win = 2;
                if (x1y1 == 2 & x2y2 == 2 & x3y3 == 2 & x4y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 2 & y == 3)
            {
                if (x1y3 == 1 & x2y3 == 1 & x3y3 == 1 & x4y3 == 1)
                    return win = 1;
                if (x2y3 == 1 & x3y3 == 1 & x4y3 == 1 & x5y3 == 1)
                    return win = 1;
                if (x1y4 == 1 & x2y3 == 1 & x3y2 == 1 & x4y1 == 1)
                    return win = 1;
                if (x1y2 == 1 & x2y3 == 1 & x3y4 == 1 & x4y5 == 1)
                    return win = 1;
                if (x2y3 == 1 & x3y4 == 1 & x4y5 == 1 & x5y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 3)
            {
                if (x1y3 == 2 & x2y3 == 2 & x3y3 == 2 & x4y3 == 2)
                    return win = 2;
                if (x2y3 == 2 & x3y3 == 2 & x4y3 == 2 & x5y3 == 2)
                    return win = 2;
                if (x1y4 == 2 & x2y3 == 2 & x3y2 == 2 & x4y1 == 2)
                    return win = 2;
                if (x1y2 == 2 & x2y3 == 2 & x3y4 == 2 & x4y5 == 2)
                    return win = 2;
                if (x2y3 == 2 & x3y4 == 2 & x4y5 == 1 & x5y6 == 2)
                    return win = 2;
            }
            if (tR == true & x == 2 & y == 4)
            {
                if (x1y4 == 1 & x2y4 == 1 & x3y4 == 1 & x4y4 == 1)
                    return win = 1;
                if (x1y3 == 1 & x2y4 == 1 & x3y5 == 1 & x4y6 == 1)
                    return win = 1;
                if (x1y4 == 1 & x2y3 == 1 & x3y2 == 1 & x4y1 == 1)
                    return win = 1;
                if (x2y4 == 1 & x3y4 == 1 & x4y4 == 1 & x5y4 == 1)
                    return win = 1;
                if (x2y1 == 1 & x2y2 == 1 & x2y3 == 1 & x2y4 == 1)
                    return win = 1;
                if (x1y5 == 1 & x2y4 == 1 & x3y3 == 1 & x4y2 == 1)
                    return win = 1;
                if (x2y4 == 1 & x3y3 == 1 & x4y2 == 1 & x5y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 4)
            {
                if (x1y4 == 2 & x2y4 == 2 & x3y4 == 2 & x4y4 == 2)
                    return win = 2;
                if (x1y3 == 2 & x2y4 == 2 & x3y5 == 2 & x4y6 == 2)
                    return win = 2;
                if (x1y4 == 2 & x2y3 == 2 & x3y2 == 2 & x4y1 == 2)
                    return win = 2;
                if (x2y4 == 2 & x3y4 == 2 & x4y4 == 2 & x5y4 == 2)
                    return win = 2;
                if (x2y1 == 2 & x2y2 == 2 & x2y3 == 2 & x2y4 == 2)
                    return win = 2;
                if (x1y5 == 2 & x2y4 == 2 & x3y3 == 2 & x4y2 == 2)
                    return win = 2;
                if (x2y4 == 2 & x3y3 == 2 & x4y2 == 2 & x5y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 2 & y == 5)
            {
                if (x2y2 == 1 & x2y3 == 1 & x2y4 == 1 & x2y5 == 1)
                    return win = 1;
                if (x1y5 == 1 & x2y5 == 1 & x3y5 == 1 & x4y5 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y5 == 1 & x3y4 == 1 & x4y3 == 1)
                    return win = 1;
                if (x2y5 == 1 & x3y5 == 1 & x4y5 == 1 & x5y5 == 1)
                    return win = 1;
                if (x2y1 == 1 & x2y2 == 1 & x2y3 == 1 & x2y4 == 1)
                    return win = 1;
                if (x2y5 == 1 & x3y4 == 1 & x4y3 == 1 & x5y2 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 5)
            {
                if (x2y2 == 2 & x2y3 == 2 & x2y4 == 2 & x2y5 == 2)
                    return win = 2;
                if (x1y5 == 2 & x2y5 == 2 & x3y5 == 2 & x4y5 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y5 == 2 & x3y4 == 2 & x4y3 == 2)
                    return win = 2;
                if (x2y5 == 2 & x3y5 == 2 & x4y5 == 2 & x5y5 == 2)
                    return win = 2;
                if (x2y5 == 2 & x2y2 == 2 & x2y3 == 2 & x2y4 == 2)
                    return win = 2;
                if (x1y5 == 2 & x3y4 == 2 & x4y3 == 2 & x5y2 == 2)
                    return win = 2;
            }
            if (tR == true & x == 2 & y == 6)
            {
                if (x2y3 == 1 & x2y4 == 1 & x2y5 == 1 & x2y6 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y6 == 1 & x3y6 == 1 & x4y6 == 1)
                    return win = 1;
                if (x2y6 == 1 & x3y5 == 1 & x2y4 == 1 & x3y3 == 1)
                    return win = 1;
                if (x2y6 == 1 & x3y6 == 1 & x4y6 == 1 & x5y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 2 & y == 6)
            {
                if (x2y3 == 2 & x2y4 == 2 & x2y5 == 2 & x2y6 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y6 == 2 & x3y6 == 2 & x4y6 == 2)
                    return win = 2;
                if (x2y6 == 2 & x3y5 == 2 & x2y4 == 2 & x3y3 == 2)
                    return win = 2;
                if (x2y6 == 2 & x3y6 == 2 & x4y6 == 2 & x5y6 == 2)
                    return win = 2;
            }
            #endregion Checkrow2

            #region Checkrow3
            if (tR == true & x == 3 & y == 1)
            {
                if (x1y1 == 1 & x2y1 == 1 & x3y1 == 1 & x4y1 == 1)
                    return win = 1;
                if (x2y1 == 1 & x3y1 == 1 & x4y1 == 1 & x5y1 == 1)
                    return win = 1;
                if (x3y1 == 1 & x4y1 == 1 & x5y1 == 1 & x6y1 == 1)
                    return win = 1;
                if (x3y1 == 1 & x3y2 == 1 & x3y3 == 1 & x3y4 == 1)
                    return win = 1;
                if (x3y1 == 1 & x4y2 == 1 & x5y3 == 1 & x6y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 1)
            {
                if (x1y1 == 2 & x2y1 == 2 & x3y1 == 2 & x4y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y1 == 2 & x4y1 == 2 & x5y1 == 2)
                    return win = 1;
                if (x3y1 == 2 & x4y1 == 2 & x5y1 == 2 & x6y1 == 2)
                    return win = 2;
                if (x3y1 == 2 & x3y2 == 2 & x3y3 == 2 & x3y4 == 2)
                    return win = 2;
                if (x3y1 == 2 & x4y2 == 2 & x5y3 == 2 & x6y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 3 & y == 2)
            {
                if (x1y2 == 1 & x2y2 == 1 & x3y2 == 1 & x4y2 == 1)
                    return win = 1;
                if (x2y2 == 1 & x3y2 == 1 & x4y2 == 1 & x5y2 == 1)
                    return win = 1;
                if (x3y2 == 1 & x4y2 == 1 & x5y2 == 1 & x6y2 == 1)
                    return win = 1;
                if (x2y1 == 1 & x3y2 == 1 & x4y3 == 1 & x5y4 == 1)
                    return win = 1;
                if (x4y1 == 1 & x3y2 == 1 & x2y3 == 1 & x1y4 == 1)
                    return win = 1;
                if (x3y2 == 1 & x4y3 == 1 & x5y4 == 1 & x6y5 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 2)
            {
                if (x1y2 == 2 & x2y2 == 2 & x3y2 == 2 & x4y2 == 2)
                    return win = 2;
                if (x2y2 == 2 & x3y2 == 2 & x4y2 == 2 & x5y2 == 2)
                    return win = 2;
                if (x3y2 == 2 & x4y2 == 2 & x5y2 == 2 & x6y2 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y2 == 2 & x4y3 == 2 & x5y4 == 2)
                    return win = 2;
                if (x4y1 == 2 & x3y2 == 2 & x2y3 == 2 & x1y4 == 2)
                    return win = 2;
                if (x3y2 == 2 & x4y3 == 2 & x5y4 == 2 & x6y5 == 2)
                    return win = 2;
            }
            if (tR == true & x == 3 & y == 3)
            {
                if (x1y3 == 1 & x2y3 == 1 & x3y3 == 1 & x4y3 == 1)
                    return win = 1;
                if (x2y3 == 1 & x3y3 == 1 & x4y3 == 1 & x5y3 == 1)
                    return win = 1;
                if (x3y3 == 1 & x4y3 == 1 & x5y3 == 1 & x6y3 == 1)
                    return win = 1;
                if (x1y1 == 1 & x2y2 == 1 & x3y3 == 1 & x4y4 == 1)
                    return win = 1;
                if (x2y2 == 1 & x3y3 == 1 & x4y4 == 1 & x5y5 == 1)
                    return win = 1;
                if (x3y3 == 1 & x4y4 == 1 & x5y5 == 1 & x6y6 == 1)
                    return win = 1;
                if (x5y1 == 1 & x4y2 == 1 & x3y3 == 1 & x2y4 == 1)
                    return win = 1;
                if (x4y2 == 1 & x3y3 == 1 & x2y4 == 1 & x1y5 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 3)
            {
                if (x1y3 == 2 & x2y3 == 2 & x3y3 == 2 & x4y3 == 2)
                    return win = 2;
                if (x2y3 == 2 & x3y3 == 2 & x4y3 == 2 & x5y3 == 2)
                    return win = 2;
                if (x3y3 == 2 & x4y3 == 2 & x5y3 == 2 & x6y3 == 2)
                    return win = 2;
                if (x1y1 == 2 & x2y2 == 2 & x3y3 == 2 & x4y4 == 2)
                    return win = 2;
                if (x2y2 == 2 & x3y3 == 2 & x4y4 == 2 & x5y5 == 2)
                    return win = 2;
                if (x3y3 == 2 & x4y4 == 2 & x5y5 == 2 & x6y6 == 2)
                    return win = 2;
                if (x5y1 == 2 & x4y2 == 2 & x3y3 == 2 & x2y4 == 2)
                    return win = 2;
                if (x4y2 == 2 & x3y3 == 2 & x2y4 == 2 & x1y5 == 2)
                    return win = 2;
            }
            if (tR == true & x == 3 & y == 4)
            {
                if (x1y4 == 1 & x2y4 == 1 & x3y4 == 1 & x4y4 == 1)
                    return win = 1;
                if (x2y4 == 1 & x3y4 == 1 & x4y4 == 1 & x5y4 == 1)
                    return win = 1;
                if (x3y4 == 1 & x4y4 == 1 & x5y4 == 1 & x6y4 == 1)
                    return win = 1;
                if (x3y1 == 1 & x3y2 == 1 & x3y3 == 1 & x3y4 == 1)
                    return win = 1;
                if (x1y2 == 1 & x2y3 == 1 & x3y4 == 1 & x4y5 == 1)
                    return win = 1;
                if (x2y3 == 1 & x3y4 == 1 & x4y5 == 1 & x5y6 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y5 == 1 & x3y4 == 1 & x4y3 == 1)
                    return win = 1;
                if (x2y5 == 1 & x3y4 == 1 & x4y3 == 1 & x5y2 == 1)
                    return win = 1;
                if (x3y4 == 1 & x4y3 == 1 & x5y2 == 1 & x6y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 4)
            {
                if (x1y4 == 2 & x2y4 == 2 & x3y4 == 2 & x4y4 == 2)
                    return win = 2;
                if (x2y4 == 2 & x3y4 == 2 & x4y4 == 2 & x5y4 == 2)
                    return win = 2;
                if (x3y4 == 2 & x4y4 == 2 & x5y4 == 2 & x6y4 == 2)
                    return win = 2;
                if (x3y1 == 2 & x3y2 == 2 & x3y3 == 2 & x3y4 == 2)
                    return win = 2;
                if (x1y2 == 2 & x2y3 == 2 & x3y4 == 2 & x4y5 == 2)
                    return win = 2;
                if (x2y3 == 2 & x3y4 == 2 & x4y5 == 2 & x5y6 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y5 == 2 & x3y4 == 2 & x4y3 == 2)
                    return win = 2;
                if (x2y5 == 2 & x3y4 == 2 & x4y2 == 2 & x5y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 3 & y == 5)
            {
                if (x1y5 == 1 & x2y5 == 1 & x3y5 == 1 & x4y5 == 1)
                    return win = 1;
                if (x2y5 == 1 & x3y5 == 1 & x4y5 == 1 & x5y5 == 1)
                    return win = 1;
                if (x3y5 == 1 & x4y5 == 1 & x5y5 == 1 & x6y5 == 1)
                    return win = 1;
                if (x3y2 == 1 & x3y3 == 1 & x3y4 == 1 & x3y5 == 1)
                    return win = 1;
                if (x2y6 == 1 & x3y5 == 1 & x4y4 == 1 & x5y3 == 1)
                    return win = 1;
                if (x3y5 == 1 & x4y4 == 1 & x5y3 == 1 & x6y2 == 1)
                    return win = 1;
                if (x1y3 == 1 & x2y4 == 1 & x3y5 == 1 & x4y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 5)
            {
                if (x1y5 == 2 & x2y5 == 2 & x3y5 == 2 & x4y5 == 2)
                    return win = 2;
                if (x2y5 == 2 & x3y5 == 2 & x4y5 == 2 & x5y5 == 2)
                    return win = 2;
                if (x3y5 == 2 & x4y5 == 2 & x5y5 == 2 & x6y5 == 2)
                    return win = 2;
                if (x3y2 == 2 & x3y3 == 2 & x3y4 == 2 & x3y5 == 2)
                    return win = 2;
                if (x2y6 == 2 & x3y5 == 2 & x4y4 == 2 & x5y3 == 2)
                    return win = 2;
                if (x3y5 == 2 & x4y4 == 2 & x5y3 == 2 & x6y2 == 2)
                    return win = 2;
                if (x1y3 == 2 & x2y4 == 2 & x3y5 == 2 & x4y6 == 2)
                    return win = 2;
            }
            if (tR == true & x == 3 & y == 6)
            {
                if (x1y6 == 1 & x2y6 == 1 & x3y6 == 1 & x4y6 == 1)
                    return win = 1;
                if (x2y6 == 1 & x3y6 == 1 & x4y6 == 1 & x5y6 == 1)
                    return win = 1;
                if (x3y6 == 1 & x4y6 == 1 & x5y6 == 1 & x6y6 == 1)
                    return win = 1;
                if (x3y3 == 1 & x3y4 == 1 & x3y5 == 1 & x3y6 == 1)
                    return win = 1;
                if (x3y6 == 1 & x4y5 == 1 & x5y3 == 1 & x6y2 == 1)
                    return win = 1;
            }
            if (tR == false & x == 3 & y == 6)
            {
                if (x1y6 == 2 & x2y6 == 2 & x3y6 == 2 & x4y6 == 2)
                    return win = 2;
                if (x2y6 == 2 & x3y6 == 2 & x4y6 == 2 & x5y6 == 2)
                    return win = 2;
                if (x3y6 == 2 & x4y6 == 2 & x5y6 == 2 & x6y6 == 2)
                    return win = 2;
                if (x3y3 == 2 & x3y4 == 2 & x3y5 == 2 & x3y6 == 2)
                    return win = 2;
                if (x3y6 == 2 & x4y5 == 2 & x5y3 == 2 & x6y2 == 2)
                    return win = 2;
            }
            #endregion Checkrow3

            #region Checkrow4
            if (tR == true & x == 4 & y == 1)
            {
                if (x1y1 == 1 & x2y1 == 1 & x3y1 == 1 & x4y1 == 1)
                    return win = 1;
                if (x2y1 == 1 & x3y1 == 1 & x4y1 == 1 & x5y1 == 1)
                    return win = 1;
                if (x3y1 == 1 & x4y1 == 1 & x5y1 == 1 & x6y1 == 1)
                    return win = 1;
                if (x4y1 == 1 & x5y1 == 1 & x6y1 == 1 & x7y1 == 1)
                    return win = 1;
                if (x4y1 == 1 & x3y2 == 1 & x2y3 == 1 & x1y4 == 1)
                    return win = 1;
                if (x4y1 == 1 & x5y2 == 1 & x6y3 == 1 & x7y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 4 & y == 1)
            {
                if (x1y1 == 2 & x2y1 == 2 & x3y1 == 2 & x4y1 == 2)
                    return win = 2;
                if (x2y1 == 2 & x3y1 == 2 & x4y1 == 2 & x5y1 == 2)
                    return win = 2;
                if (x3y1 == 2 & x4y1 == 2 & x5y1 == 2 & x6y1 == 2)
                    return win = 2;
                if (x4y1 == 2 & x5y1 == 2 & x6y1 == 2 & x7y1 == 2)
                    return win = 2;
                if (x4y1 == 2 & x3y2 == 2 & x2y3 == 2 & x1y4 == 2)
                    return win = 2;
                if (x4y1 == 2 & x5y2 == 2 & x6y3 == 2 & x7y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 4 & y == 2)
            {
                if (x1y2 == 1 & x2y2 == 1 & x3y2 == 1 & x4y2 == 1)
                    return win = 1;
                if (x2y2 == 1 & x3y2 == 1 & x4y2 == 1 & x5y2 == 1)
                    return win = 1;
                if (x3y2 == 1 & x4y2 == 1 & x5y2 == 1 & x6y2 == 1)
                    return win = 1;
                if (x4y2 == 1 & x5y2 == 1 & x6y2 == 1 & x7y2 == 1)
                    return win = 1;
                if (x3y1 == 1 & x4y2 == 1 & x5y3 == 1 & x6y4 == 1)
                    return win = 1;
                if (x1y5 == 1 & x2y4 == 1 & x3y3 == 1 & x4y2 == 1)
                    return win = 1;
                if (x2y4 == 1 & x3y3 == 1 & x4y2 == 1 & x5y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 4 & y == 2)
            {
                if (x1y2 == 2 & x2y2 == 2 & x3y2 == 2 & x4y2 == 2)
                    return win = 2;
                if (x2y2 == 2 & x3y2 == 2 & x4y2 == 2 & x5y2 == 2)
                    return win = 2;
                if (x3y2 == 2 & x4y2 == 2 & x5y2 == 2 & x6y2 == 2)
                    return win = 2;
                if (x4y2 == 2 & x5y2 == 2 & x6y2 == 2 & x7y2 == 2)
                    return win = 2;
                if (x3y1 == 2 & x4y2 == 2 & x5y3 == 2 & x6y4 == 2)
                    return win = 2;
                if (x1y5 == 2 & x2y4 == 2 & x3y3 == 2 & x4y2 == 2)
                    return win = 2;
                if (x2y4 == 2 & x3y3 == 2 & x4y2 == 2 & x5y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 4 & y == 3)
            {
                if (x1y3 == 1 & x2y3 == 1 & x3y3 == 1 & x4y4 == 1)
                    return win = 1;
                if (x2y3 == 1 & x3y3 == 1 & x4y3 == 1 & x5y3 == 1)
                    return win = 1;
                if (x3y3 == 1 & x4y3 == 1 & x5y3 == 1 & x6y3 == 1)
                    return win = 1;
                if (x4y3 == 1 & x5y3 == 1 & x6y3 == 1 & x7y3 == 1)
                    return win = 1;
                if (x5y4 == 1 & x4y3 == 1 & x3y2 == 1 & x2y1 == 1)
                    return win = 1;
                if (x3y4 == 1 & x4y3 == 1 & x5y4 == 1 & x6y5 == 1)
                    return win = 1;
                if (x4y3 == 1 & x5y4 == 1 & x6y5 == 1 & x7y6 == 1)
                    return win = 1;
                if (x1y6 == 1 & x2y5 == 1 & x3y4 == 1 & x4y3 == 1)
                    return win = 1;
            }

            if (tR == false & x == 4 & y == 3)
            {
                if (x1y3 == 2 & x2y3 == 2 & x3y3 == 2 & x4y4 == 2)
                    return win = 2;
                if (x2y3 == 2 & x3y3 == 2 & x4y3 == 2 & x5y3 == 2)
                    return win = 2;
                if (x3y3 == 2 & x4y3 == 2 & x5y3 == 2 & x6y3 == 2)
                    return win = 2;
                if (x4y3 == 2 & x5y3 == 2 & x6y3 == 2 & x7y3 == 2)
                    return win = 2;
                if (x5y4 == 2 & x4y3 == 2 & x3y2 == 2 & x2y1 == 2)
                    return win = 2;
                if (x3y4 == 2 & x4y3 == 2 & x5y4 == 2 & x6y5 == 2)
                    return win = 2;
                if (x4y3 == 2 & x5y4 == 2 & x6y5 == 2 & x7y6 == 2)
                    return win = 2;
                if (x1y6 == 2 & x2y5 == 2 & x3y4 == 2 & x4y3 == 2)
                    return win = 2;
            }

            if (tR == true & x == 4 & y == 4)
            {

                if (x1y4 == 1 & x2y4 == 1 & x3y4 == 1 & x4y4 == 1)

                    return win = 1;

                if (x2y4 == 1 & x3y4 == 1 & x4y4 == 1 & x5y4 == 1)

                    return win = 1;

                if (x3y4 == 1 & x4y4 == 1 & x5y4 == 1 & x6y4 == 1)

                    return win = 1;

                if (x4y4 == 1 & x5y4 == 1 & x6y4 == 1 & x7y4 == 1)

                    return win = 1;

                if (x4y1 == 1 & x4y2 == 1 & x4y3 == 1 & x4y4 == 1)

                    return win = 1;

                if (x1y1 == 1 & x2y2 == 1 & x3y3 == 1 & x4y4 == 1)

                    return win = 1;

                if (x2y2 == 1 & x3y3 == 1 & x4y4 == 1 & x5y5 == 1)

                    return win = 1;

                if (x3y3 == 1 & x4y4 == 1 & x5y5 == 1 & x6y6 == 1)

                    return win = 1;

                if (x2y6 == 1 & x3y5 == 1 & x4y4 == 1 & x5y3 == 1)

                    return win = 1;

                if (x3y5 == 1 & x4y4 == 1 & x5y3 == 1 & x6y2 == 1)

                    return win = 1;

                if (x4y4 == 1 & x5y3 == 1 & x6y2 == 1 & x7y1 == 1)

                    return win = 1;

            }

            if (tR == false & x == 4 & y == 4)
            {

                if (x1y4 == 2 & x2y4 == 2 & x3y4 == 2 & x4y4 == 2)

                    return win = 2;

                if (x2y4 == 2 & x3y4 == 2 & x4y4 == 2 & x5y4 == 2)

                    return win = 2;

                if (x3y4 == 2 & x4y4 == 2 & x5y4 == 2 & x6y4 == 2)

                    return win = 2;

                if (x4y4 == 2 & x5y4 == 2 & x6y4 == 2 & x7y4 == 2)

                    return win = 2;

                if (x4y1 == 2 & x4y2 == 2 & x4y3 == 2 & x4y4 == 2)

                    return win = 2;

                if (x1y1 == 2 & x2y2 == 2 & x3y3 == 2 & x4y4 == 2)

                    return win = 2;

                if (x2y2 == 2 & x3y3 == 2 & x4y4 == 2 & x5y5 == 2)

                    return win = 2;

                if (x3y3 == 2 & x4y4 == 2 & x5y5 == 2 & x6y6 == 2)

                    return win = 2;

                if (x2y6 == 2 & x3y5 == 2 & x4y4 == 2 & x5y3 == 2)

                    return win = 2;

                if (x3y5 == 2 & x4y4 == 2 & x5y3 == 2 & x6y2 == 2)

                    return win = 2;

                if (x4y4 == 2 & x5y3 == 2 & x6y2 == 2 & x7y1 == 2)

                    return win = 2;

            }

            if (tR == true & x == 4 & y == 5)
            {

                if (x1y5 == 1 & x2y5 == 1 & x3y5 == 1 & x4y5 == 1)

                    return win = 1;

                if (x2y5 == 1 & x3y5 == 1 & x4y5 == 1 & x5y5 == 1)

                    return win = 1;

                if (x3y5 == 1 & x4y5 == 1 & x5y5 == 1 & x6y5 == 1)

                    return win = 1;

                if (x4y5 == 1 & x5y5 == 1 & x6y5 == 1 & x7y5 == 1)

                    return win = 1;

                if (x4y2 == 1 & x4y3 == 1 & x4y4 == 1 & x4y5 == 1)

                    return win = 1;

                if (x3y6 == 1 & x4y5 == 1 & x5y3 == 1 & x6y2 == 1)

                    return win = 1;

                if (x4y5 == 1 & x5y3 == 1 & x6y2 == 1 & x7y1 == 1)

                    return win = 1;

                if (x1y2 == 1 & x2y3 == 1 & x3y4 == 1 & x4y5 == 1)

                    return win = 1;

                if (x2y3 == 1 & x3y4 == 1 & x4y5 == 1 & x5y6 == 1)

                    return win = 1;

            }

            if (tR == false & x == 4 & y == 5)
            {

                if (x1y5 == 2 & x2y5 == 2 & x3y5 == 2 & x4y5 == 2)

                    return win = 2;

                if (x2y5 == 2 & x3y5 == 2 & x4y5 == 2 & x5y5 == 2)

                    return win = 2;

                if (x3y5 == 2 & x4y5 == 2 & x5y5 == 2 & x6y5 == 2)

                    return win = 2;

                if (x4y5 == 2 & x5y5 == 2 & x6y5 == 2 & x7y5 == 2)

                    return win = 2;

                if (x4y2 == 2 & x4y3 == 2 & x4y4 == 2 & x4y5 == 2)

                    return win = 2;

                if (x3y6 == 2 & x4y5 == 2 & x5y3 == 2 & x6y2 == 2)

                    return win = 2;

                if (x4y5 == 2 & x5y3 == 2 & x6y2 == 2 & x7y1 == 2)

                    return win = 2;

                if (x1y2 == 2 & x2y3 == 2 & x3y4 == 2 & x4y5 == 2)

                    return win = 2;

                if (x2y3 == 2 & x3y4 == 2 & x4y5 == 2 & x5y6 == 2)

                    return win = 2;

            }

            if (tR == true & x == 4 & y == 6)
            {

                if (x1y6 == 1 & x2y6 == 1 & x3y6 == 1 & x4y6 == 1)

                    return win = 1;

                if (x2y6 == 1 & x3y6 == 1 & x4y6 == 1 & x5y6 == 1)

                    return win = 1;

                if (x3y6 == 1 & x4y6 == 1 & x5y6 == 1 & x6y6 == 1)

                    return win = 1;

                if (x4y6 == 1 & x5y6 == 1 & x6y6 == 1 & x7y6 == 1)

                    return win = 1;

                if (x1y3 == 1 & x2y4 == 1 & x3y5 == 1 & x4y6 == 1)

                    return win = 1;

                if (x4y6 == 1 & x5y5 == 1 & x6y4 == 1 & x7y3 == 1)

                    return win = 1;

                if (x4y3 == 1 & x4y4 == 1 & x4y5 == 1 & x4y6 == 1)

                    return win = 1;

            }

            if (tR == false & x == 4 & y == 6)
            {

                if (x1y6 == 2 & x2y6 == 2 & x3y6 == 2 & x4y6 == 2)

                    return win = 2;

                if (x2y6 == 2 & x3y6 == 2 & x4y6 == 2 & x5y6 == 2)

                    return win = 2;

                if (x3y6 == 2 & x4y6 == 2 & x5y6 == 2 & x6y6 == 2)

                    return win = 2;

                if (x4y6 == 2 & x5y6 == 2 & x6y6 == 2 & x7y6 == 2)

                    return win = 2;

                if (x1y3 == 2 & x2y4 == 2 & x3y5 == 2 & x4y6 == 2)

                    return win = 2;

                if (x4y6 == 2 & x5y5 == 2 & x6y4 == 2 & x7y3 == 2)

                    return win = 2;

                if (x4y3 == 2 & x4y4 == 2 & x4y5 == 2 & x4y6 == 2)

                    return win = 2;

            }

            #endregion Checkrow4

            #region Checkrow5

            if (tR == true & x == 5 & y == 1)
            {

                if (x2y1 == 1 & x3y1 == 1 & x4y1 == 1 & x5y1 == 1)

                    return win = 1;

                if (x3y1 == 1 & x4y1 == 1 & x5y1 == 1 & x6y1 == 1)

                    return win = 1;

                if (x4y1 == 1 & x5y1 == 1 & x6y1 == 1 & x7y1 == 1)

                    return win = 1;

                if (x2y4 == 1 & x3y3 == 1 & x4y2 == 1 & x5y1 == 1)

                    return win = 1;

            }

            if (tR == false & x == 5 & y == 1)
            {

                if (x2y1 == 2 & x3y1 == 2 & x4y1 == 2 & x5y1 == 2)

                    return win = 2;

                if (x3y1 == 2 & x4y1 == 2 & x5y1 == 2 & x6y1 == 2)

                    return win = 2;

                if (x4y1 == 2 & x5y1 == 2 & x6y1 == 2 & x7y1 == 2)

                    return win = 2;

                if (x2y4 == 2 & x3y3 == 2 & x4y2 == 2 & x5y1 == 2)

                    return win = 2;

            }

            if (tR == true & x == 5 & y == 2)
            {

                if (x2y2 == 1 & x3y2 == 1 & x4y2 == 1 & x5y2 == 1)

                    return win = 1;

                if (x3y2 == 1 & x4y2 == 1 & x5y2 == 1 & x6y2 == 1)

                    return win = 1;

                if (x4y2 == 1 & x5y2 == 1 & x6y2 == 1 & x7y2 == 1)

                    return win = 1;

                if (x4y1 == 1 & x5y2 == 1 & x6y3 == 1 & x7y4 == 1)

                    return win = 1;

                if (x3y4 == 1 & x4y3 == 1 & x5y2 == 1 & x6y1 == 1)

                    return win = 1;

                if (x2y5 == 1 & x3y4 == 1 & x4y3 == 1 & x5y2 == 1)

                    return win = 1;

            }

            if (tR == false & x == 5 & y == 2)
            {

                if (x2y2 == 2 & x3y2 == 2 & x4y2 == 2 & x5y2 == 2)

                    return win = 2;

                if (x3y2 == 2 & x4y2 == 2 & x5y2 == 2 & x6y2 == 2)

                    return win = 2;

                if (x4y2 == 2 & x5y2 == 2 & x6y2 == 2 & x7y2 == 2)

                    return win = 2;

                if (x4y1 == 2 & x5y2 == 2 & x6y3 == 2 & x7y4 == 2)

                    return win = 2;

                if (x3y4 == 2 & x4y3 == 2 & x5y2 == 2 & x6y1 == 2)

                    return win = 2;

                if (x2y5 == 2 & x3y4 == 2 & x4y3 == 2 & x5y2 == 2)

                    return win = 2;

            }

            if (tR == true & x == 5 & y == 3)
            {

                if (x2y3 == 1 & x3y3 == 1 & x4y3 == 1 & x5y3 == 1)

                    return win = 1;

                if (x3y3 == 1 & x4y3 == 1 & x5y3 == 1 & x6y3 == 1)

                    return win = 1;

                if (x4y3 == 1 & x5y3 == 1 & x6y3 == 1 & x7y3 == 1)

                    return win = 1;

                if (x3y1 == 1 & x4y2 == 1 & x5y3 == 1 & x6y4 == 1)

                    return win = 1;

                if (x4y2 == 1 & x5y3 == 1 & x6y4 == 1 & x7y5 == 1)

                    return win = 1;

                if (x2y6 == 1 & x3y5 == 1 & x4y4 == 1 & x5y3 == 1)

                    return win = 1;

                if (x3y5 == 1 & x4y4 == 1 & x5y3 == 1 & x6y2 == 1)

                    return win = 1;

                if (x4y4 == 1 & x5y3 == 1 & x6y2 == 1 & x7y1 == 1)

                    return win = 1;

            }

            if (tR == false & x == 5 & y == 3)
            {

                if (x2y3 == 2 & x3y3 == 2 & x4y3 == 2 & x5y3 == 2)

                    return win = 2;

                if (x3y3 == 2 & x4y3 == 2 & x5y3 == 2 & x6y3 == 2)

                    return win = 2;

                if (x4y3 == 2 & x5y3 == 2 & x6y3 == 2 & x7y3 == 2)

                    return win = 2;

                if (x3y1 == 2 & x4y2 == 2 & x5y3 == 2 & x6y4 == 2)

                    return win = 2;

                if (x4y2 == 2 & x5y3 == 2 & x6y4 == 2 & x7y5 == 2)

                    return win = 2;

                if (x2y6 == 2 & x3y5 == 2 & x4y4 == 2 & x5y3 == 2)

                    return win = 2;

                if (x3y5 == 2 & x4y4 == 2 & x5y3 == 2 & x6y2 == 2)

                    return win = 2;

                if (x4y4 == 2 & x5y3 == 2 & x6y2 == 2 & x7y1 == 2)

                    return win = 2;

            }

            if (tR == true & x == 5 & y == 4)
            {

                if (x2y4 == 1 & x3y4 == 1 & x4y4 == 1 & x5y4 == 1)

                    return win = 1;

                if (x3y4 == 1 & x4y4 == 1 & x5y4 == 1 & x6y4 == 1)

                    return win = 1;

                if (x4y4 == 1 & x5y4 == 1 & x6y4 == 1 & x7y4 == 1)

                    return win = 1;

                if (x5y1 == 1 & x5y2 == 1 & x5y3 == 1 & x5y4 == 1)

                    return win = 1;

                if (x2y1 == 1 & x3y2 == 1 & x4y3 == 1 & x5y4 == 1)

                    return win = 1;

                if (x3y2 == 1 & x4y3 == 1 & x5y4 == 1 & x6y5 == 1)

                    return win = 1;

                if (x4y3 == 1 & x5y4 == 1 & x6y5 == 1 & x7y6 == 1)

                    return win = 1;

                if (x3y6 == 1 & x4y5 == 1 & x5y4 == 1 & x6y3 == 1)

                    return win = 1;

                if (x4y5 == 1 & x5y4 == 1 & x6y3 == 1 & x7y2 == 1)

                    return win = 1;

            }

            if (tR == false & x == 5 & y == 4)
            {

                if (x2y4 == 2 & x3y4 == 2 & x4y4 == 2 & x5y4 == 2)

                    return win = 2;

                if (x3y4 == 2 & x4y4 == 2 & x5y4 == 2 & x6y4 == 2)

                    return win = 2;

                if (x4y4 == 2 & x5y4 == 2 & x6y4 == 2 & x7y4 == 2)

                    return win = 2;

                if (x5y1 == 2 & x5y2 == 2 & x5y3 == 2 & x5y4 == 2)

                    return win = 2;

                if (x2y1 == 2 & x3y2 == 2 & x4y3 == 2 & x5y4 == 2)

                    return win = 2;

                if (x3y2 == 2 & x4y3 == 2 & x5y4 == 2 & x6y5 == 2)

                    return win = 2;

                if (x4y3 == 2 & x5y4 == 2 & x6y5 == 2 & x7y6 == 2)

                    return win = 2;

                if (x3y6 == 2 & x4y5 == 2 & x5y4 == 2 & x6y3 == 2)

                    return win = 2;

                if (x4y5 == 2 & x5y4 == 2 & x6y3 == 2 & x7y2 == 2)

                    return win = 2;

            }

            if (tR == true & x == 5 & y == 5)
            {

                if (x2y5 == 1 & x3y5 == 1 & x4y5 == 1 & x5y5 == 1)

                    return win = 1;

                if (x3y5 == 1 & x4y5 == 1 & x5y5 == 1 & x6y5 == 1)

                    return win = 1;

                if (x4y5 == 1 & x5y5 == 1 & x6y5 == 1 & x7y5 == 1)

                    return win = 1;

                if (x5y2 == 1 & x5y3 == 1 & x5y4 == 1 & x5y5 == 1)

                    return win = 1;

                if (x2y2 == 1 & x3y3 == 1 & x4y4 == 1 & x5y5 == 1)

                    return win = 1;

                if (x3y3 == 1 & x4y4 == 1 & x5y5 == 1 & x6y6 == 1)

                    return win = 1;

                if (x4y6 == 1 & x5y5 == 1 & x6y4 == 1 & x7y3 == 1)

                    return win = 1;

            }

            if (tR == false & x == 5 & y == 5)
            {

                if (x2y5 == 2 & x3y5 == 2 & x4y5 == 2 & x5y5 == 2)

                    return win = 2;

                if (x3y5 == 2 & x4y5 == 2 & x5y5 == 2 & x6y5 == 2)

                    return win = 2;

                if (x4y5 == 2 & x5y5 == 2 & x6y5 == 2 & x7y5 == 2)

                    return win = 2;

                if (x5y2 == 2 & x5y3 == 2 & x5y4 == 2 & x5y5 == 2)

                    return win = 2;

                if (x2y2 == 2 & x3y3 == 2 & x4y4 == 2 & x5y5 == 2)

                    return win = 2;

                if (x3y3 == 2 & x4y4 == 2 & x5y5 == 2 & x6y6 == 2)

                    return win = 2;

                if (x4y6 == 2 & x5y5 == 2 & x6y4 == 2 & x7y3 == 2)

                    return win = 2;

            }

            if (tR == true & x == 5 & y == 6)
            {

                if (x2y6 == 1 & x3y6 == 1 & x4y6 == 1 & x5y6 == 1)

                    return win = 1;

                if (x3y6 == 1 & x4y6 == 1 & x5y6 == 1 & x6y6 == 1)

                    return win = 1;

                if (x4y6 == 1 & x5y6 == 1 & x6y6 == 1 & x7y6 == 1)

                    return win = 1;

                if (x5y3 == 1 & x5y4 == 1 & x5y5 == 1 & x5y6 == 1)

                    return win = 1;

                if (x2y3 == 1 & x3y4 == 1 & x4y5 == 1 & x5y6 == 1)

                    return win = 1;



            }

            if (tR == false & x == 5 & y == 6)
            {

                if (x2y6 == 2 & x3y6 == 2 & x4y6 == 2 & x5y6 == 2)

                    return win = 2;

                if (x3y6 == 2 & x4y6 == 2 & x5y6 == 2 & x6y6 == 2)

                    return win = 2;

                if (x4y6 == 2 & x5y6 == 2 & x6y6 == 2 & x7y6 == 2)

                    return win = 2;

                if (x5y3 == 2 & x5y4 == 2 & x5y5 == 2 & x5y6 == 2)

                    return win = 2;

                if (x2y3 == 2 & x3y4 == 2 & x4y5 == 2 & x5y6 == 2)

                    return win = 2;




            }

            #endregion Checkrow5

            #region Checkrow6
            if (tR == true & x == 6 & y == 1)
            {
                if (x3y1 == 1 & x4y1 == 1 & x5y1 == 1 & x6y1 == 1)
                    return win = 1;
                if (x4y1 == 1 & x5y1 == 1 & x6y1 == 1 & x7y1 == 1)
                    return win = 1;
                if (x3y4 == 1 & x4y3 == 1 & x5y2 == 1 & x6y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 1)
            {
                if (x3y1 == 2 & x4y1 == 2 & x5y1 == 2 & x6y1 == 2)
                    return win = 2;
                if (x4y1 == 2 & x5y1 == 2 & x6y1 == 2 & x7y1 == 2)
                    return win = 2;
                if (x3y4 == 2 & x4y3 == 2 & x5y2 == 2 & x6y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 6 & y == 2)
            {
                if (x3y2 == 1 & x4y2 == 1 & x5y2 == 1 & x6y2 == 1)
                    return win = 1;
                if (x4y2 == 1 & x5y2 == 1 & x6y2 == 1 & x7y2 == 1)
                    return win = 1;
                if (x3y5 == 1 & x4y4 == 1 & x5y3 == 1 & x6y2 == 1)
                    return win = 1;
                if (x4y4 == 1 & x5y3 == 1 & x6y2 == 1 & x7y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 2)
            {
                if (x3y2 == 2 & x4y2 == 2 & x5y2 == 2 & x6y2 == 2)
                    return win = 2;
                if (x4y2 == 2 & x5y2 == 2 & x6y2 == 2 & x7y2 == 2)
                    return win = 2;
                if (x3y5 == 2 & x4y4 == 2 & x5y3 == 2 & x6y2 == 2)
                    return win = 2;
                if (x4y4 == 2 & x5y3 == 2 & x6y2 == 2 & x7y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 6 & y == 3)
            {
                if (x3y3 == 1 & x4y3 == 1 & x5y3 == 1 & x6y3 == 1)
                    return win = 1;
                if (x4y3 == 1 & x5y3 == 1 & x6y3 == 1 & x7y3 == 1)
                    return win = 1;
                if (x3y6 == 1 & x4y5 == 1 & x5y4 == 1 & x6y3 == 1)
                    return win = 1;
                if (x4y5 == 1 & x5y4 == 1 & x6y3 == 1 & x7y2 == 1)
                    return win = 1;
                if (x4y1 == 1 & x5y2 == 1 & x6y3 == 1 & x7y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 3)
            {
                if (x3y3 == 2 & x4y3 == 2 & x5y3 == 2 & x6y3 == 2)
                    return win = 2;
                if (x4y3 == 2 & x5y3 == 2 & x6y3 == 2 & x7y3 == 2)
                    return win = 2;
                if (x3y6 == 2 & x4y5 == 2 & x5y4 == 2 & x6y3 == 2)
                    return win = 2;
                if (x4y5 == 2 & x5y4 == 2 & x6y3 == 2 & x7y2 == 2)
                    return win = 2;
                if (x4y1 == 2 & x5y2 == 2 & x6y3 == 2 & x7y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 6 & y == 4)
            {
                if (x3y4 == 1 & x4y4 == 1 & x5y4 == 1 & x6y4 == 1)
                    return win = 1;
                if (x4y4 == 1 & x5y4 == 1 & x6y4 == 1 & x7y4 == 1)
                    return win = 1;
                if (x6y1 == 1 & x6y2 == 1 & x6y3 == 1 & x6y4 == 1)
                    return win = 1;
                if (x4y6 == 1 & x5y5 == 1 & x6y4 == 1 & x7y3 == 1)
                    return win = 1;
                if (x3y1 == 1 & x4y2 == 1 & x5y3 == 1 & x6y4 == 1)
                    return win = 1;
                if (x4y2 == 1 & x5y3 == 1 & x6y4 == 1 & x7y5 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 4)
            {
                if (x3y4 == 2 & x4y4 == 2 & x5y4 == 2 & x6y4 == 2)
                    return win = 2;
                if (x4y4 == 2 & x5y4 == 2 & x6y4 == 2 & x7y4 == 2)
                    return win = 2;
                if (x6y1 == 2 & x6y2 == 2 & x6y3 == 2 & x6y4 == 2)
                    return win = 2;
                if (x4y6 == 2 & x5y5 == 2 & x6y4 == 2 & x7y3 == 2)
                    return win = 2;
                if (x3y1 == 2 & x4y2 == 2 & x5y3 == 2 & x6y4 == 2)
                    return win = 2;
                if (x4y2 == 2 & x5y3 == 2 & x6y4 == 2 & x7y5 == 2)
                    return win = 2;
            }
            if (tR == true & x == 6 & y == 5)
            {
                if (x3y5 == 1 & x4y5 == 1 & x5y5 == 1 & x6y5 == 1)
                    return win = 1;
                if (x4y5 == 1 & x5y5 == 1 & x6y5 == 1 & x7y5 == 1)
                    return win = 1;
                if (x6y2 == 1 & x6y3 == 1 & x6y4 == 1 & x6y5 == 1)
                    return win = 1;
                if (x3y2 == 1 & x4y3 == 1 & x5y4 == 1 & x6y5 == 1)
                    return win = 1;
                if (x4y3 == 1 & x5y4 == 1 & x6y5 == 1 & x7y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 5)
            {
                if (x3y5 == 2 & x4y5 == 2 & x5y5 == 2 & x6y5 == 2)
                    return win = 2;
                if (x4y5 == 2 & x5y5 == 2 & x6y5 == 2 & x7y5 == 2)
                    return win = 2;
                if (x6y2 == 2 & x6y3 == 2 & x6y4 == 2 & x6y5 == 2)
                    return win = 2;
                if (x3y2 == 2 & x4y3 == 2 & x5y4 == 2 & x6y5 == 2)
                    return win = 2;
                if (x4y3 == 2 & x5y4 == 2 & x6y5 == 2 & x7y6 == 2)
                    return win = 2;
            }
            if (tR == true & x == 6 & y == 6)
            {
                if (x3y6 == 1 & x4y6 == 1 & x5y6 == 1 & x6y6 == 1)
                    return win = 1;
                if (x4y6 == 1 & x5y6 == 1 & x6y6 == 1 & x7y6 == 1)
                    return win = 1;
                if (x6y3 == 1 & x6y4 == 1 & x6y5 == 1 & x6y6 == 1)
                    return win = 1;
                if (x3y3 == 1 & x4y4 == 1 & x5y5 == 1 & x6y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 6 & y == 6)
            {
                if (x3y6 == 2 & x4y6 == 2 & x5y6 == 2 & x6y6 == 2)
                    return win = 2;
                if (x4y6 == 2 & x5y6 == 2 & x6y6 == 2 & x7y6 == 2)
                    return win = 2;
                if (x6y3 == 2 & x6y4 == 2 & x6y5 == 2 & x6y6 == 2)
                    return win = 2;
                if (x3y3 == 2 & x4y4 == 2 & x5y5 == 2 & x6y6 == 2)
                    return win = 2;
            }
            #endregion Checkrow6

            #region Checkrow6
            if (tR == true & x == 7 & y == 1)
            {
                if (x4y1 == 1 & x5y1 == 1 & x6y1 == 1 & x7y1 == 1)
                    return win = 1;
                if (x4y4 == 1 & x5y3 == 1 & x6y2 == 1 & x7y1 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 1)
            {
                if (x4y1 == 2 & x5y1 == 2 & x6y1 == 2 & x7y1 == 2)
                    return win = 2;
                if (x4y4 == 2 & x5y3 == 2 & x6y2 == 2 & x7y1 == 2)
                    return win = 2;
            }
            if (tR == true & x == 7 & y == 2)
            {
                if (x4y2 == 1 & x5y2 == 1 & x6y2 == 1 & x7y2 == 1)
                    return win = 1;
                if (x4y5 == 1 & x5y4 == 1 & x6y3 == 1 & x7y2 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 2)
            {
                if (x4y2 == 2 & x5y2 == 2 & x6y2 == 2 & x7y2 == 2)
                    return win = 2;
                if (x4y5 == 2 & x5y4 == 2 & x6y3 == 2 & x7y2 == 2)
                    return win = 2;
            }
            if (tR == true & x == 7 & y == 3)
            {
                if (x4y3 == 1 & x5y3 == 1 & x6y3 == 1 & x7y3 == 1)
                    return win = 1;
                if (x4y6 == 1 & x5y5 == 1 & x6y4 == 1 & x7y3 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 3)
            {
                if (x4y3 == 2 & x5y3 == 2 & x6y3 == 2 & x7y3 == 2)
                    return win = 2;
                if (x4y6 == 2 & x5y5 == 2 & x6y4 == 2 & x7y3 == 2)
                    return win = 2;
            }
            if (tR == true & x == 7 & y == 4)
            {
                if (x4y4 == 1 & x5y4 == 1 & x6y4 == 1 & x7y4 == 1)
                    return win = 1;
                if (x7y1 == 1 & x7y2 == 1 & x7y3 == 1 & x7y4 == 1)
                    return win = 1;
                if (x4y1 == 1 & x5y2 == 1 & x6y3 == 1 & x7y4 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 4)
            {
                if (x4y4 == 2 & x5y4 == 2 & x6y4 == 2 & x7y4 == 2)
                    return win = 2;
                if (x7y1 == 2 & x7y2 == 2 & x7y3 == 2 & x7y4 == 2)
                    return win = 2;
                if (x4y1 == 2 & x5y2 == 2 & x6y3 == 2 & x7y4 == 2)
                    return win = 2;
            }
            if (tR == true & x == 7 & y == 5)
            {
                if (x4y5 == 1 & x5y5 == 1 & x6y5 == 1 & x7y5 == 1)
                    return win = 1;
                if (x7y2 == 1 & x7y3 == 1 & x7y4 == 1 & x7y5 == 1)
                    return win = 1;
                if (x4y2 == 1 & x5y3 == 1 & x6y4 == 1 & x7y5 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 5)
            {
                if (x4y5 == 2 & x5y5 == 2 & x6y5 == 2 & x7y5 == 2)
                    return win = 2;
                if (x7y2 == 2 & x7y3 == 2 & x7y4 == 2 & x7y5 == 2)
                    return win = 2;
                if (x4y2 == 2 & x5y3 == 2 & x6y4 == 2 & x7y5 == 2)
                    return win = 2;
            }
            if (tR == true & x == 7 & y == 6)
            {
                if (x4y6 == 1 & x5y6 == 1 & x6y6 == 1 & x7y6 == 1)
                    return win = 1;
                if (x7y3 == 1 & x7y4 == 1 & x7y5 == 1 & x7y6 == 1)
                    return win = 1;
                if (x4y3 == 1 & x5y4 == 1 & x6y5 == 1 & x7y6 == 1)
                    return win = 1;
            }
            if (tR == false & x == 7 & y == 6)
            {
                if (x4y6 == 2 & x5y6 == 2 & x6y6 == 2 & x7y6 == 2)
                    return win = 2;
                if (x7y3 == 2 & x7y4 == 2 & x7y5 == 2 & x7y6 == 2)
                    return win = 2;
                if (x4y3 == 2 & x5y4 == 2 & x6y5 == 2 & x7y6 == 2)
                    return win = 2;
            }
            #endregion Checkrow6
            return 0;

        }


        public int placePeice(int x, int y, bool tR)
        {
            Brush r = new SolidBrush(Color.Red);
            Brush b = new SolidBrush(Color.Black);
            Graphics g;
            g = this.CreateGraphics();

            //Piece 1 of Row 1
            if (y == 0 & x == 1 & tR == true)
            {
                g.FillEllipse(r, 75, 450, 50, 50);
                x1y1 = 1;
                return fill1 = 1;
            }
            else if (y == 0 & x == 1 & tR == false)
            {
                g.FillEllipse(b, 75, 450, 50, 50);
                x1y1 = 2;
                return fill1 = 1;

            }//Piece 2 of Row 1
            else if (y == 1 & x == 1 & tR == true)
            {
                g.FillEllipse(r, 75, 375, 50, 50);
                x1y2 = 1;
                return fill1 = 2;
            }
            else if (y == 1 & x == 1 & tR == false)
            {
                g.FillEllipse(b, 75, 375, 50, 50);
                x1y2 = 2;
                return fill1 = 2;

            }//Piece 3 of Row 1

            else if (y == 2 & x == 1 & tR == true)
            {

                g.FillEllipse(r, 75, 300, 50, 50);

                x1y3 = 1;

                return fill1 = 3;

            }

            else if (y == 2 & x == 1 & tR == false)
            {

                g.FillEllipse(b, 75, 300, 50, 50);

                x1y3 = 2;

                return fill1 = 3;

            }//Piece 4 of Row 1

            else if (y == 3 & x == 1 & tR == true)
            {

                g.FillEllipse(r, 75, 225, 50, 50);

                x1y4 = 1;

                return fill1 = 4;

            }

            else if (y == 3 & x == 1 & tR == false)
            {

                g.FillEllipse(b, 75, 225, 50, 50);

                x1y4 = 2;

                return fill1 = 4;

            }//Piece 5 of Row 1

            else if (y == 4 & x == 1 & tR == true)
            {

                g.FillEllipse(r, 75, 150, 50, 50);

                x1y5 = 1;

                return fill1 = 5;

            }

            else if (y == 4 & x == 1 & tR == false)
            {

                g.FillEllipse(b, 75, 150, 50, 50);

                x1y5 = 2;

                return fill1 = 5;

            }//Piece 6 of Row 1

            else if (y == 5 & x == 1 & tR == true)
            {

                g.FillEllipse(r, 75, 75, 50, 50);

                x1y6 = 1;

                return fill1 = 6;

            }

            else if (y == 5 & x == 1 & tR == false)
            {

                g.FillEllipse(b, 75, 75, 50, 50);

                x1y6 = 2;

                return fill1 = 6;

            }//Piece 1 of Row 2

            else if (y == 0 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 450, 50, 50);

                x2y1 = 1;

                return fill2 = 1;

            }

            else if (y == 0 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 450, 50, 50);

                x2y1 = 2;

                return fill2 = 1;

            }//Piece 2 of Row 2

            else if (y == 1 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 375, 50, 50);

                x2y2 = 1;

                return fill2 = 2;

            }

            else if (y == 1 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 375, 50, 50);

                x2y2 = 2;

                return fill2 = 2;

            }//Piece 3 of Row 2

            else if (y == 2 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 300, 50, 50);

                x2y3 = 1;

                return fill2 = 3;

            }

            else if (y == 2 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 300, 50, 50);

                x2y3 = 2;

                return fill2 = 3;

            }//Piece 4 of Row 2

            else if (y == 3 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 225, 50, 50);

                x2y4 = 1;

                return fill2 = 4;

            }

            else if (y == 3 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 225, 50, 50);

                x2y4 = 2;

                return fill2 = 4;

            }//Piece 5 of Row 2

            else if (y == 4 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 150, 50, 50);

                x2y5 = 1;

                return fill2 = 5;

            }

            else if (y == 4 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 150, 50, 50);

                x2y5 = 2;

                return fill2 = 5;

            }//Piece 6 of Row 2

            else if (y == 5 & x == 2 & tR == true)
            {

                g.FillEllipse(r, 150, 75, 50, 50);

                x2y6 = 1;

                return fill2 = 6;

            }

            else if (y == 5 & x == 2 & tR == false)
            {

                g.FillEllipse(b, 150, 75, 50, 50);

                x2y6 = 2;

                return fill2 = 6;

            }//Piece 1 of Row 3

            if (y == 0 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 450, 50, 50);

                x3y1 = 1;

                return fill3 = 1;

            }

            else if (y == 0 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 450, 50, 50);

                x3y1 = 2;

                return fill3 = 1;

            }//Piece 2 of Row 3

            else if (y == 1 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 375, 50, 50);

                x3y2 = 1;

                return fill3 = 2;

            }

            else if (y == 1 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 375, 50, 50);

                x3y2 = 2;

                return fill3 = 2;

            }//Piece 3 of Row 3

            else if (y == 2 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 300, 50, 50);

                x3y3 = 1;

                return fill3 = 3;

            }

            else if (y == 2 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 300, 50, 50);

                x3y3 = 2;

                return fill3 = 3;

            }//Piece 4 of Row 3

            else if (y == 3 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 225, 50, 50);

                x3y4 = 1;

                return fill3 = 4;

            }

            else if (y == 3 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 225, 50, 50);

                x3y4 = 2;

                return fill3 = 4;

            }//Piece 5 of Row 3

            else if (y == 4 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 150, 50, 50);

                x3y5 = 1;

                return fill3 = 5;

            }

            else if (y == 4 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 150, 50, 50);

                x3y5 = 2;

                return fill3 = 5;

            }//Piece 6 of Row 3

            else if (y == 5 & x == 3 & tR == true)
            {

                g.FillEllipse(r, 225, 75, 50, 50);

                x3y6 = 1;

                return fill3 = 6;

            }

            else if (y == 5 & x == 3 & tR == false)
            {

                g.FillEllipse(b, 225, 75, 50, 50);

                x3y6 = 2;

                return fill3 = 6;

            }//Piece 1 of Row 4

            if (y == 0 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 450, 50, 50);

                x4y1 = 1;

                return fill4 = 1;

            }

            else if (y == 0 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 450, 50, 50);

                x4y1 = 2;

                return fill4 = 1;

            }//Piece 2 of Row 4

            else if (y == 1 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 375, 50, 50);

                x4y2 = 1;

                return fill4 = 2;

            }

            else if (y == 1 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 375, 50, 50);

                x4y2 = 2;

                return fill4 = 2;

            }//Piece 3 of Row 4

            else if (y == 2 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 300, 50, 50);

                x4y3 = 1;

                return fill4 = 3;

            }

            else if (y == 2 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 300, 50, 50);

                x4y3 = 2;

                return fill4 = 3;

            }//Piece 4 of Row 4

            else if (y == 3 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 225, 50, 50);

                x4y4 = 1;

                return fill4 = 4;

            }

            else if (y == 3 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 225, 50, 50);

                x4y4 = 2;

                return fill4 = 4;

            }//Piece 5 of Row 4

            else if (y == 4 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 150, 50, 50);

                x4y5 = 1;

                return fill4 = 5;

            }

            else if (y == 4 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 150, 50, 50);

                x4y5 = 2;

                return fill4 = 5;

            }//Piece 6 of Row 4

            else if (y == 5 & x == 4 & tR == true)
            {

                g.FillEllipse(r, 300, 75, 50, 50);

                x4y6 = 1;

                return fill4 = 6;

            }

            else if (y == 5 & x == 4 & tR == false)
            {

                g.FillEllipse(b, 300, 75, 50, 50);

                x4y6 = 2;

                return fill4 = 6;

            }//Piece 1 of Row 5

            else if (y == 0 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 450, 50, 50);

                x5y1 = 1;

                return fill5 = 1;

            }

            else if (y == 0 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 450, 50, 50);

                x5y1 = 2;

                return fill5 = 1;

            }//Piece 2 of Row 5

            else if (y == 1 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 375, 50, 50);

                x5y2 = 1;

                return fill5 = 2;

            }

            else if (y == 1 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 375, 50, 50);

                x5y2 = 2;

                return fill5 = 2;

            }//Piece 3 of Row 5

            else if (y == 2 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 300, 50, 50);

                x5y3 = 1;

                return fill5 = 3;

            }

            else if (y == 2 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 300, 50, 50);

                x5y3 = 2;

                return fill5 = 3;

            }//Piece 4 of Row 5

            else if (y == 3 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 225, 50, 50);

                x5y4 = 1;

                return fill5 = 4;

            }

            else if (y == 3 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 225, 50, 50);

                x5y4 = 2;

                return fill5 = 4;

            }//Piece 5 of Row 5

            else if (y == 4 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 150, 50, 50);

                x5y5 = 1;

                return fill5 = 5;

            }

            else if (y == 4 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 150, 50, 50);

                x5y5 = 2;

                return fill5 = 5;

            }//Piece 6 of Row 5

            else if (y == 5 & x == 5 & tR == true)
            {

                g.FillEllipse(r, 375, 75, 50, 50);

                x5y6 = 1;

                return fill5 = 6;

            }

            else if (y == 5 & x == 5 & tR == false)
            {

                g.FillEllipse(b, 375, 75, 50, 50);

                x5y6 = 2;

                return fill5 = 6;

            }//Piece 1 of Row 6

            else if (y == 0 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 450, 50, 50);

                x6y1 = 1;

                return fill6 = 1;

            }

            else if (y == 0 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 450, 50, 50);

                x6y1 = 2;

                return fill6 = 1;

            }//Piece 2 of Row 6

            else if (y == 1 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 375, 50, 50);

                x6y2 = 1;

                return fill6 = 2;

            }

            else if (y == 1 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 375, 50, 50);

                x6y2 = 2;

                return fill6 = 2;

            }//Piece 3 of Row 6

            else if (y == 2 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 300, 50, 50);

                x6y3 = 1;

                return fill6 = 3;

            }

            else if (y == 2 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 300, 50, 50);

                x6y3 = 2;

                return fill6 = 3;

            }//Piece 4 of Row 6

            else if (y == 3 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 225, 50, 50);

                x6y4 = 1;

                return fill6 = 4;

            }

            else if (y == 3 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 225, 50, 50);

                x6y4 = 2;

                return fill6 = 4;

            }//Piece 5 of Row 6

            else if (y == 4 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 150, 50, 50);

                x6y5 = 1;

                return fill6 = 5;

            }

            else if (y == 4 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 150, 50, 50);

                x6y5 = 2;

                return fill6 = 5;

            }//Piece 6 of Row 6

            else if (y == 5 & x == 6 & tR == true)
            {

                g.FillEllipse(r, 450, 75, 50, 50);

                x6y6 = 1;

                return fill6 = 6;

            }

            else if (y == 5 & x == 6 & tR == false)
            {

                g.FillEllipse(b, 450, 75, 50, 50);

                x6y6 = 2;

                return fill6 = 6;

            }//Piece 1 of Row 7

            else if (y == 0 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 450, 50, 50);

                x7y1 = 1;

                return fill7 = 1;

            }

            else if (y == 0 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 450, 50, 50);

                x7y1 = 2;

                return fill7 = 1;

            }//Piece 2 of Row 7

            else if (y == 1 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 375, 50, 50);

                x7y2 = 1;

                return fill7 = 2;

            }

            else if (y == 1 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 375, 50, 50);

                x7y2 = 2;

                return fill7 = 2;

            }//Piece 3 of Row 7

            else if (y == 2 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 300, 50, 50);

                x7y3 = 1;

                return fill7 = 3;

            }

            else if (y == 2 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 300, 50, 50);

                x7y3 = 2;

                return fill7 = 3;

            }//Piece 4 of Row 7

            else if (y == 3 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 225, 50, 50);

                x7y4 = 1;

                return fill7 = 4;

            }

            else if (y == 3 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 225, 50, 50);

                x7y4 = 2;

                return fill7 = 4;

            }//Piece 5 of Row 7

            else if (y == 4 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 150, 50, 50);

                x7y5 = 1;

                return fill7 = 5;

            }

            else if (y == 4 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 150, 50, 50);

                x7y5 = 2;

                return fill7 = 5;

            }//Piece 6 of Row 7

            else if (y == 5 & x == 7 & tR == true)
            {

                g.FillEllipse(r, 525, 75, 50, 50);

                x7y6 = 1;

                return fill7 = 6;

            }

            else if (y == 5 & x == 7 & tR == false)
            {

                g.FillEllipse(b, 525, 75, 50, 50);

                x7y6 = 2;

                return fill7 = 6;

            }

            else

                return 0;



        }


        private void button1_Click(object sender, EventArgs e)
        {
            int row = 1;

            
                placePeice(row, fill1, turnRed);




                didYouWin(turnRed, row, fill1);




                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int row = 2;


            

                placePeice(row, fill2, turnRed);

                didYouWin(turnRed, row, fill2);


                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int row = 3;


            

                placePeice(row, fill3, turnRed);

                didYouWin(turnRed, row, fill3);


                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            int row = 4;


            

                placePeice(row, fill4, turnRed);

                didYouWin(turnRed, row, fill4);


                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;

                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int row = 5;


            
                placePeice(row, fill5, turnRed);

                didYouWin(turnRed, row, fill5);


                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            int row = 6;


           
                placePeice(row, fill6, turnRed);

                didYouWin(turnRed, row, fill6);


                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

            int row = 7;

            
                placePeice(row, fill7, turnRed);


                didYouWin(turnRed, row, fill7);

                if (turnRed == true)

                    turnRed = false;

                else

                    turnRed = true;




                if (win == 1)

                    label1.Visible = true;

                else if (win == 2)

                    label2.Visible = true;

                if (turnRed == true)
                {
                    label3.Visible = true;
                    label4.Visible = false;
                }
                if (turnRed == false)
                {
                    label3.Visible = false;
                    label4.Visible = true;
                }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            turnRed = true;
            fill1 = 0;
            fill2 = 0;
            fill3 = 0;
            fill4 = 0;
            fill5 = 0;
            fill6 = 0;
            fill7 = 0;

            this.Refresh();

            label1.Visible = false;
            label2.Visible = false;

            turnRed = true;
            label3.Visible = true;
            label4.Visible = false;

             x1y1 = 0;
             x1y2 = 0;
             x1y3 = 0;
             x1y4 = 0;
             x1y5 = 0;
             x1y6 = 0;
             x2y1 = 0;
             x2y2 = 0;
             x2y3 = 0;
             x2y4 = 0;
             x2y5 = 0;
             x2y6 = 0;
             x3y1 = 0;
             x3y2 = 0;
             x3y3 = 0;
             x3y4 = 0;
             x3y5 = 0;
             x3y6 = 0;
             x4y1 = 0;
             x4y2 = 0;
             x4y3 = 0;
             x4y4 = 0;
             x4y5 = 0;
             x4y6 = 0;
             x5y1 = 0;
             x5y2 = 0;
             x5y3 = 0;
             x5y4 = 0;
             x5y5 = 0;
             x5y6 = 0;
             x6y1 = 0;
             x6y2 = 0;
             x6y3 = 0;
             x6y4 = 0;
             x6y5 = 0;
             x6y6 = 0;
             x7y1 = 0;
             x7y2 = 0;
             x7y3 = 0;
             x7y4 = 0;
             x7y5 = 0;
             x7y6 = 0;

             win = 0;
        }

    }
}