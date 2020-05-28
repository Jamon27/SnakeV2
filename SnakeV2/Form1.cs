using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeV2
{
    public partial class Form1 : Form
    {
        Point[] p;
        int len;
        int direction;// 1 left, 2 right, 3 top, 4 bottom
        enum Direction
        {
            Left,
            Right
        }

        public Form1()
        {
            InitializeComponent();
            len = 5;
            direction = 4;
            p = new Point[200];
            //            for (int i = 0; i < 5; i++)
            //           { 
            //               p[i].X = 100;
            //               p[i].Y = 100*i*10;
            //          }
            panel2.Invalidate();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 198; i >= 0; i--) {
                p[i+1].X = p[i].X;
                p[i+1].Y = p[i].Y;
            }
            if (direction == 1)
            {
                p[0].X = p[1].X - 10;
                p[0].Y = p[1].Y;
            }
            if (direction == 2)
            {
                p[0].X = p[1].X + 10;
                p[0].Y = p[1].Y;
            }
            if (direction == 3)
            {
                p[0].X = p[1].X ;
                p[0].Y = p[1].Y - 10;
            }
            if (direction == 4)
            {
                p[0].X = p[1].X;
                p[0].Y = p[1].Y+10;
            }
            SolidBrush b = new SolidBrush(Color.Black);
            for (int i= 0; i < len; i++)
            {
                e.Graphics.FillEllipse(b, p[i].X, p[i].Y, 10, 10);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                direction = 1;
            }
            if (e.KeyCode == Keys.Right)
            {
                direction = 2;
            }
            if (e.KeyCode == Keys.Up)
            {
                direction = 3;
            }
            if (e.KeyCode == Keys.Down)
            {
                direction = 4;
            }
        }
        //SnakeClass testAnimal = new SnakeClass(10, 5, 100);
        
        private void drawBorders()
        {
            SolidBrush b = new SolidBrush(Color.Black);
            
 
        }

        private void drawBorders(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Brown, 10 );
            e.Graphics.DrawRectangle(blackPen, 0, 0, 500, 500);
        }
    }
}
