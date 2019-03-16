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
                pen.Color = pColourMain.BackColor;
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
            pColourMain.BackColor = pColour2.BackColor;
        }

        private void pColourMain_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColourMain.BackColor;
            pColourMain.BringToFront();
        }

        private void clearPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pCanvas.BackColor = Color.White;
        }

        private void pCanvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pColour1_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour1.BackColor;
            pColourMain.BackColor = pColour1.BackColor;
        }

        private void pColour3_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour3.BackColor;
            pColourMain.BackColor = pColour3.BackColor;
        }

        private void pColour4_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour4.BackColor;
            pColourMain.BackColor = pColour4.BackColor;
        }

        private void pColour5_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour5.BackColor;
            pColourMain.BackColor = pColour5.BackColor;
        }

        private void pColour6_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour6.BackColor;
            pColourMain.BackColor = pColour6.BackColor;
        }

        private void pColour7_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour7.BackColor;
            pColourMain.BackColor = pColour7.BackColor;
        }

        private void pColour9_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour9.BackColor;
            pColourMain.BackColor = pColour9.BackColor;
        }

        private void pColour11_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour11.BackColor;
            pColourMain.BackColor = pColour11.BackColor;
        }

        private void pColour13_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour13.BackColor;
            pColourMain.BackColor = pColour13.BackColor;
        }

        private void pColour15_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour15.BackColor;
            pColourMain.BackColor = pColour15.BackColor;
        }

        private void pColour17_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour17.BackColor;
            pColourMain.BackColor = pColour17.BackColor;
        }

        private void pColour19_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour19.BackColor;
            pColourMain.BackColor = pColour19.BackColor;
        }

        private void pColour21_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour21.BackColor;
            pColourMain.BackColor = pColour21.BackColor;
        }

        private void pColour23_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour23.BackColor;
            pColourMain.BackColor = pColour23.BackColor;
        }

        private void pColour25_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour25.BackColor;
            pColourMain.BackColor = pColour25.BackColor;
        }

        private void pColour27_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour27.BackColor;
            pColourMain.BackColor = pColour27.BackColor;
        }

        private void pColour8_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour8.BackColor;
            pColourMain.BackColor = pColour8.BackColor;
        }

        private void pColour10_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour10.BackColor;
            pColourMain.BackColor = pColour10.BackColor;
        }

        private void pColour12_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour12.BackColor;
            pColourMain.BackColor = pColour12.BackColor;
        }

        private void pColour14_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour14.BackColor;
            pColourMain.BackColor = pColour14.BackColor;
        }

        private void pColour16_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour16.BackColor;
            pColourMain.BackColor = pColour16.BackColor;
        }

        private void pColour18_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour18.BackColor;
            pColourMain.BackColor = pColour18.BackColor;
        }

        private void pColour20_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour20.BackColor;
            pColourMain.BackColor = pColour20.BackColor;
        }

        private void pColour22_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour22.BackColor;
            pColourMain.BackColor = pColour22.BackColor;
        }

        private void pColour24_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour24.BackColor;
            pColourMain.BackColor = pColour14.BackColor;
        }

        private void pColour26_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour26.BackColor;
            pColourMain.BackColor = pColour26.BackColor;
        }

        private void pColour28_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColour28.BackColor;
            pColourMain.BackColor = pColour28.BackColor;
        }

        private void pColourSec_MouseDown(object sender, MouseEventArgs e)
        {
            pen.Color = pColourSec.BackColor;
            pColourSec.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbToolTip.Text = ("This is a pencil.");
            pen.Color = pColourMain.BackColor;
            pBrushSizeSmall.BringToFront();
        }

        private void bRubberTool_Click(object sender, EventArgs e)
        {
            tbToolTip.Text = ("This is a eraser.");
            pen.Color = pColourSec.BackColor;
        }

        private void bFillTool_Click(object sender, EventArgs e)
        {
            tbToolTip.Text = ("This is a fill bucket.");
        }

        private void bTextTool_Click(object sender, EventArgs e)
        {
            tbToolTip.Text = ("This is text.");
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an MSpaint tribute, made by Madeleine Brown in Visual Studio Community using C# with graphics made in GIMP. Made in 2 Days.");
        }
    }
}
