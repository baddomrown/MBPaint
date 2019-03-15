using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MBPaint
{
    public partial class Main : Form
    {
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;

        public Main()
        {
            InitializeComponent();
            g = pCanvas.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pColourMain.BackColor = colorDialog1.Color;
            }
        }

        private void pColour2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;

            //pCanvas.Cursor = Cursors.SizeAll;


        }

        private void pCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y),e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void pCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
        }

        private void pColour2_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour2.BackColor; 
        }

        private void pColourMain_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColourMain.BackColor;
        }

        private void clearPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pCanvas.BackColor = Color.White;
        }
    }
}
