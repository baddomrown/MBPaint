namespace MBPaint
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pCanvas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pColour6 = new System.Windows.Forms.Panel();
            this.pColour5 = new System.Windows.Forms.Panel();
            this.pColour4 = new System.Windows.Forms.Panel();
            this.pColour3 = new System.Windows.Forms.Panel();
            this.pColour2 = new System.Windows.Forms.Panel();
            this.pColour1 = new System.Windows.Forms.Panel();
            this.pColourMain = new System.Windows.Forms.Panel();
            this.pColour9 = new System.Windows.Forms.Panel();
            this.pColour15 = new System.Windows.Forms.Panel();
            this.pColour11 = new System.Windows.Forms.Panel();
            this.pColour14 = new System.Windows.Forms.Panel();
            this.pColour16 = new System.Windows.Forms.Panel();
            this.pColour13 = new System.Windows.Forms.Panel();
            this.pColour12 = new System.Windows.Forms.Panel();
            this.pColour10 = new System.Windows.Forms.Panel();
            this.pColour7 = new System.Windows.Forms.Panel();
            this.pColour8 = new System.Windows.Forms.Panel();
            this.pColour26 = new System.Windows.Forms.Panel();
            this.pColour19 = new System.Windows.Forms.Panel();
            this.pColour23 = new System.Windows.Forms.Panel();
            this.pColour28 = new System.Windows.Forms.Panel();
            this.pColour27 = new System.Windows.Forms.Panel();
            this.pColour17 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.pColour25 = new System.Windows.Forms.Panel();
            this.pColour24 = new System.Windows.Forms.Panel();
            this.pColour21 = new System.Windows.Forms.Panel();
            this.pColour22 = new System.Windows.Forms.Panel();
            this.pColour20 = new System.Windows.Forms.Panel();
            this.pColour18 = new System.Windows.Forms.Panel();
            this.pColourSec = new System.Windows.Forms.Panel();
            this.tbToolTip = new System.Windows.Forms.TextBox();
            this.pBrushSizeSmall = new System.Windows.Forms.Panel();
            this.pToolSelection = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pLargeCircleBrush = new System.Windows.Forms.Panel();
            this.bTextTool = new System.Windows.Forms.Button();
            this.bFillTool = new System.Windows.Forms.Button();
            this.bRubberTool = new System.Windows.Forms.Button();
            this.bPencilTool = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pColour17.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCanvas
            // 
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCanvas.Location = new System.Drawing.Point(84, 86);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(547, 330);
            this.pCanvas.TabIndex = 0;
            this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
            this.pCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseDown);
            this.pCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseMove);
            this.pCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.colourToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.clearPageToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.newPageToolStripMenuItem.Text = "New Page";
            // 
            // clearPageToolStripMenuItem
            // 
            this.clearPageToolStripMenuItem.Name = "clearPageToolStripMenuItem";
            this.clearPageToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clearPageToolStripMenuItem.Text = "Clear Page";
            this.clearPageToolStripMenuItem.Click += new System.EventHandler(this.clearPageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.colourToolStripMenuItem.Text = "Colour";
            this.colourToolStripMenuItem.Click += new System.EventHandler(this.colourToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pColour6
            // 
            this.pColour6.BackColor = System.Drawing.Color.Maroon;
            this.pColour6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour6.Location = new System.Drawing.Point(105, 30);
            this.pColour6.Name = "pColour6";
            this.pColour6.Size = new System.Drawing.Size(15, 15);
            this.pColour6.TabIndex = 2;
            this.pColour6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour6_MouseDown);
            // 
            // pColour5
            // 
            this.pColour5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pColour5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour5.Location = new System.Drawing.Point(105, 48);
            this.pColour5.Name = "pColour5";
            this.pColour5.Size = new System.Drawing.Size(15, 15);
            this.pColour5.TabIndex = 3;
            this.pColour5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour5_MouseDown);
            // 
            // pColour4
            // 
            this.pColour4.BackColor = System.Drawing.Color.Gray;
            this.pColour4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour4.Location = new System.Drawing.Point(84, 30);
            this.pColour4.Name = "pColour4";
            this.pColour4.Size = new System.Drawing.Size(15, 15);
            this.pColour4.TabIndex = 0;
            this.pColour4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour4_MouseDown);
            // 
            // pColour3
            // 
            this.pColour3.BackColor = System.Drawing.Color.Silver;
            this.pColour3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour3.Location = new System.Drawing.Point(84, 48);
            this.pColour3.Name = "pColour3";
            this.pColour3.Size = new System.Drawing.Size(15, 15);
            this.pColour3.TabIndex = 4;
            this.pColour3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour3_MouseDown);
            // 
            // pColour2
            // 
            this.pColour2.BackColor = System.Drawing.Color.Black;
            this.pColour2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour2.Location = new System.Drawing.Point(65, 30);
            this.pColour2.Name = "pColour2";
            this.pColour2.Size = new System.Drawing.Size(15, 15);
            this.pColour2.TabIndex = 1;
            this.pColour2.Paint += new System.Windows.Forms.PaintEventHandler(this.pColour2_Paint);
            this.pColour2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour2_MouseDown);
            // 
            // pColour1
            // 
            this.pColour1.BackColor = System.Drawing.Color.White;
            this.pColour1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour1.Location = new System.Drawing.Point(65, 48);
            this.pColour1.Name = "pColour1";
            this.pColour1.Size = new System.Drawing.Size(15, 15);
            this.pColour1.TabIndex = 2;
            this.pColour1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour1_MouseDown);
            // 
            // pColourMain
            // 
            this.pColourMain.BackColor = System.Drawing.Color.Black;
            this.pColourMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColourMain.Location = new System.Drawing.Point(10, 26);
            this.pColourMain.Name = "pColourMain";
            this.pColourMain.Size = new System.Drawing.Size(25, 25);
            this.pColourMain.TabIndex = 6;
            this.pColourMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColourMain_MouseDown);
            // 
            // pColour9
            // 
            this.pColour9.BackColor = System.Drawing.Color.Lime;
            this.pColour9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour9.Location = new System.Drawing.Point(147, 48);
            this.pColour9.Name = "pColour9";
            this.pColour9.Size = new System.Drawing.Size(15, 15);
            this.pColour9.TabIndex = 0;
            this.pColour9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour9_MouseDown);
            // 
            // pColour15
            // 
            this.pColour15.BackColor = System.Drawing.Color.Fuchsia;
            this.pColour15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour15.Location = new System.Drawing.Point(210, 48);
            this.pColour15.Name = "pColour15";
            this.pColour15.Size = new System.Drawing.Size(15, 15);
            this.pColour15.TabIndex = 1;
            this.pColour15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour15_MouseDown);
            // 
            // pColour11
            // 
            this.pColour11.BackColor = System.Drawing.Color.Aqua;
            this.pColour11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour11.Location = new System.Drawing.Point(168, 48);
            this.pColour11.Name = "pColour11";
            this.pColour11.Size = new System.Drawing.Size(15, 15);
            this.pColour11.TabIndex = 2;
            this.pColour11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour11_MouseDown);
            // 
            // pColour14
            // 
            this.pColour14.BackColor = System.Drawing.Color.Navy;
            this.pColour14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour14.Location = new System.Drawing.Point(189, 30);
            this.pColour14.Name = "pColour14";
            this.pColour14.Size = new System.Drawing.Size(15, 15);
            this.pColour14.TabIndex = 3;
            this.pColour14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour14_MouseDown);
            // 
            // pColour16
            // 
            this.pColour16.BackColor = System.Drawing.Color.Purple;
            this.pColour16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour16.Location = new System.Drawing.Point(210, 30);
            this.pColour16.Name = "pColour16";
            this.pColour16.Size = new System.Drawing.Size(15, 15);
            this.pColour16.TabIndex = 4;
            this.pColour16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour16_MouseDown);
            // 
            // pColour13
            // 
            this.pColour13.BackColor = System.Drawing.Color.Blue;
            this.pColour13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour13.Location = new System.Drawing.Point(189, 48);
            this.pColour13.Name = "pColour13";
            this.pColour13.Size = new System.Drawing.Size(15, 15);
            this.pColour13.TabIndex = 5;
            this.pColour13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour13_MouseDown);
            // 
            // pColour12
            // 
            this.pColour12.BackColor = System.Drawing.Color.Teal;
            this.pColour12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour12.Location = new System.Drawing.Point(168, 30);
            this.pColour12.Name = "pColour12";
            this.pColour12.Size = new System.Drawing.Size(15, 15);
            this.pColour12.TabIndex = 6;
            this.pColour12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour12_MouseDown);
            // 
            // pColour10
            // 
            this.pColour10.BackColor = System.Drawing.Color.Green;
            this.pColour10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour10.Location = new System.Drawing.Point(147, 30);
            this.pColour10.Name = "pColour10";
            this.pColour10.Size = new System.Drawing.Size(15, 15);
            this.pColour10.TabIndex = 7;
            this.pColour10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour10_MouseDown);
            // 
            // pColour7
            // 
            this.pColour7.BackColor = System.Drawing.Color.Yellow;
            this.pColour7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour7.Location = new System.Drawing.Point(126, 48);
            this.pColour7.Name = "pColour7";
            this.pColour7.Size = new System.Drawing.Size(15, 15);
            this.pColour7.TabIndex = 8;
            this.pColour7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour7_MouseDown);
            // 
            // pColour8
            // 
            this.pColour8.BackColor = System.Drawing.Color.Olive;
            this.pColour8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour8.Location = new System.Drawing.Point(126, 30);
            this.pColour8.Name = "pColour8";
            this.pColour8.Size = new System.Drawing.Size(15, 15);
            this.pColour8.TabIndex = 9;
            this.pColour8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour8_MouseDown);
            // 
            // pColour26
            // 
            this.pColour26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pColour26.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour26.Location = new System.Drawing.Point(315, 30);
            this.pColour26.Name = "pColour26";
            this.pColour26.Size = new System.Drawing.Size(15, 15);
            this.pColour26.TabIndex = 0;
            this.pColour26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour26_MouseDown);
            // 
            // pColour19
            // 
            this.pColour19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pColour19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour19.Location = new System.Drawing.Point(252, 48);
            this.pColour19.Name = "pColour19";
            this.pColour19.Size = new System.Drawing.Size(15, 15);
            this.pColour19.TabIndex = 1;
            this.pColour19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour19_MouseDown);
            // 
            // pColour23
            // 
            this.pColour23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pColour23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour23.Location = new System.Drawing.Point(294, 48);
            this.pColour23.Name = "pColour23";
            this.pColour23.Size = new System.Drawing.Size(15, 15);
            this.pColour23.TabIndex = 3;
            this.pColour23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour23_MouseDown);
            // 
            // pColour28
            // 
            this.pColour28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pColour28.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour28.Location = new System.Drawing.Point(335, 30);
            this.pColour28.Name = "pColour28";
            this.pColour28.Size = new System.Drawing.Size(15, 15);
            this.pColour28.TabIndex = 4;
            this.pColour28.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour28_MouseDown);
            // 
            // pColour27
            // 
            this.pColour27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(64)))));
            this.pColour27.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour27.Location = new System.Drawing.Point(335, 48);
            this.pColour27.Name = "pColour27";
            this.pColour27.Size = new System.Drawing.Size(15, 15);
            this.pColour27.TabIndex = 5;
            this.pColour27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour27_MouseDown);
            // 
            // pColour17
            // 
            this.pColour17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pColour17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour17.Controls.Add(this.panel21);
            this.pColour17.Location = new System.Drawing.Point(231, 48);
            this.pColour17.Name = "pColour17";
            this.pColour17.Size = new System.Drawing.Size(15, 15);
            this.pColour17.TabIndex = 6;
            this.pColour17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour17_MouseDown);
            // 
            // panel21
            // 
            this.panel21.Location = new System.Drawing.Point(54, 99);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(200, 100);
            this.panel21.TabIndex = 0;
            // 
            // pColour25
            // 
            this.pColour25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.pColour25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour25.Location = new System.Drawing.Point(315, 48);
            this.pColour25.Name = "pColour25";
            this.pColour25.Size = new System.Drawing.Size(15, 15);
            this.pColour25.TabIndex = 7;
            this.pColour25.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour25_MouseDown);
            // 
            // pColour24
            // 
            this.pColour24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.pColour24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour24.Location = new System.Drawing.Point(294, 30);
            this.pColour24.Name = "pColour24";
            this.pColour24.Size = new System.Drawing.Size(15, 15);
            this.pColour24.TabIndex = 0;
            this.pColour24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour24_MouseDown);
            // 
            // pColour21
            // 
            this.pColour21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pColour21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour21.Location = new System.Drawing.Point(273, 48);
            this.pColour21.Name = "pColour21";
            this.pColour21.Size = new System.Drawing.Size(15, 15);
            this.pColour21.TabIndex = 1;
            this.pColour21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour21_MouseDown);
            // 
            // pColour22
            // 
            this.pColour22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pColour22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour22.Location = new System.Drawing.Point(273, 30);
            this.pColour22.Name = "pColour22";
            this.pColour22.Size = new System.Drawing.Size(15, 15);
            this.pColour22.TabIndex = 8;
            this.pColour22.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour22_MouseDown);
            // 
            // pColour20
            // 
            this.pColour20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pColour20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour20.Location = new System.Drawing.Point(252, 30);
            this.pColour20.Name = "pColour20";
            this.pColour20.Size = new System.Drawing.Size(15, 15);
            this.pColour20.TabIndex = 0;
            this.pColour20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour20_MouseDown);
            // 
            // pColour18
            // 
            this.pColour18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.pColour18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour18.Location = new System.Drawing.Point(231, 30);
            this.pColour18.Name = "pColour18";
            this.pColour18.Size = new System.Drawing.Size(15, 15);
            this.pColour18.TabIndex = 1;
            this.pColour18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour18_MouseDown);
            // 
            // pColourSec
            // 
            this.pColourSec.BackColor = System.Drawing.Color.White;
            this.pColourSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColourSec.Location = new System.Drawing.Point(19, 34);
            this.pColourSec.Name = "pColourSec";
            this.pColourSec.Size = new System.Drawing.Size(25, 25);
            this.pColourSec.TabIndex = 10;
            this.pColourSec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColourSec_MouseDown);
            // 
            // tbToolTip
            // 
            this.tbToolTip.Location = new System.Drawing.Point(83, 422);
            this.tbToolTip.Name = "tbToolTip";
            this.tbToolTip.ReadOnly = true;
            this.tbToolTip.Size = new System.Drawing.Size(548, 20);
            this.tbToolTip.TabIndex = 16;
            this.tbToolTip.Text = "Help can be found at the top.";
            // 
            // pBrushSizeSmall
            // 
            this.pBrushSizeSmall.BackColor = System.Drawing.Color.Black;
            this.pBrushSizeSmall.Location = new System.Drawing.Point(46, 185);
            this.pBrushSizeSmall.Name = "pBrushSizeSmall";
            this.pBrushSizeSmall.Size = new System.Drawing.Size(4, 4);
            this.pBrushSizeSmall.TabIndex = 0;
            // 
            // pToolSelection
            // 
            this.pToolSelection.BackColor = System.Drawing.Color.Silver;
            this.pToolSelection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pToolSelection.Location = new System.Drawing.Point(8, 158);
            this.pToolSelection.Name = "pToolSelection";
            this.pToolSelection.Size = new System.Drawing.Size(70, 107);
            this.pToolSelection.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(32, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(10, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 16);
            this.panel2.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::MBPaint.Properties.Resources.smallcirclebrush;
            this.panel5.Location = new System.Drawing.Point(46, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 16);
            this.panel5.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::MBPaint.Properties.Resources.mediumcirclebrush;
            this.panel4.Location = new System.Drawing.Point(28, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(16, 16);
            this.panel4.TabIndex = 20;
            // 
            // pLargeCircleBrush
            // 
            this.pLargeCircleBrush.BackgroundImage = global::MBPaint.Properties.Resources.largecirclebrush;
            this.pLargeCircleBrush.Location = new System.Drawing.Point(10, 207);
            this.pLargeCircleBrush.Name = "pLargeCircleBrush";
            this.pLargeCircleBrush.Size = new System.Drawing.Size(16, 16);
            this.pLargeCircleBrush.TabIndex = 19;
            // 
            // bTextTool
            // 
            this.bTextTool.BackColor = System.Drawing.Color.Silver;
            this.bTextTool.BackgroundImage = global::MBPaint.Properties.Resources.tex1;
            this.bTextTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bTextTool.Location = new System.Drawing.Point(37, 127);
            this.bTextTool.Name = "bTextTool";
            this.bTextTool.Size = new System.Drawing.Size(25, 25);
            this.bTextTool.TabIndex = 14;
            this.bTextTool.UseVisualStyleBackColor = false;
            this.bTextTool.Click += new System.EventHandler(this.bTextTool_Click);
            // 
            // bFillTool
            // 
            this.bFillTool.BackColor = System.Drawing.Color.Silver;
            this.bFillTool.BackgroundImage = global::MBPaint.Properties.Resources.Bucket1;
            this.bFillTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFillTool.Location = new System.Drawing.Point(10, 127);
            this.bFillTool.Name = "bFillTool";
            this.bFillTool.Size = new System.Drawing.Size(25, 25);
            this.bFillTool.TabIndex = 13;
            this.bFillTool.UseVisualStyleBackColor = false;
            this.bFillTool.Click += new System.EventHandler(this.bFillTool_Click);
            // 
            // bRubberTool
            // 
            this.bRubberTool.BackColor = System.Drawing.Color.Silver;
            this.bRubberTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRubberTool.Image = global::MBPaint.Properties.Resources.rubberIcon;
            this.bRubberTool.Location = new System.Drawing.Point(37, 100);
            this.bRubberTool.Name = "bRubberTool";
            this.bRubberTool.Size = new System.Drawing.Size(25, 25);
            this.bRubberTool.TabIndex = 12;
            this.bRubberTool.UseVisualStyleBackColor = false;
            this.bRubberTool.Click += new System.EventHandler(this.bRubberTool_Click);
            // 
            // bPencilTool
            // 
            this.bPencilTool.BackColor = System.Drawing.Color.Silver;
            this.bPencilTool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPencilTool.Image = global::MBPaint.Properties.Resources.pencil;
            this.bPencilTool.Location = new System.Drawing.Point(10, 100);
            this.bPencilTool.Name = "bPencilTool";
            this.bPencilTool.Size = new System.Drawing.Size(25, 25);
            this.bPencilTool.TabIndex = 11;
            this.bPencilTool.UseVisualStyleBackColor = false;
            this.bPencilTool.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 447);
            this.Controls.Add(this.pToolSelection);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pLargeCircleBrush);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pBrushSizeSmall);
            this.Controls.Add(this.tbToolTip);
            this.Controls.Add(this.bTextTool);
            this.Controls.Add(this.bFillTool);
            this.Controls.Add(this.bRubberTool);
            this.Controls.Add(this.bPencilTool);
            this.Controls.Add(this.pColourMain);
            this.Controls.Add(this.pColourSec);
            this.Controls.Add(this.pColour24);
            this.Controls.Add(this.pColour27);
            this.Controls.Add(this.pColour25);
            this.Controls.Add(this.pColour28);
            this.Controls.Add(this.pColour21);
            this.Controls.Add(this.pColour22);
            this.Controls.Add(this.pColour20);
            this.Controls.Add(this.pColour26);
            this.Controls.Add(this.pColour23);
            this.Controls.Add(this.pColour18);
            this.Controls.Add(this.pColour17);
            this.Controls.Add(this.pColour15);
            this.Controls.Add(this.pColour16);
            this.Controls.Add(this.pColour13);
            this.Controls.Add(this.pColour19);
            this.Controls.Add(this.pColour12);
            this.Controls.Add(this.pColour10);
            this.Controls.Add(this.pColour14);
            this.Controls.Add(this.pColour7);
            this.Controls.Add(this.pColour11);
            this.Controls.Add(this.pColour8);
            this.Controls.Add(this.pColour1);
            this.Controls.Add(this.pColour3);
            this.Controls.Add(this.pColour9);
            this.Controls.Add(this.pColour2);
            this.Controls.Add(this.pColour5);
            this.Controls.Add(this.pColour4);
            this.Controls.Add(this.pColour6);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MBPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pColour17.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pColour6;
        private System.Windows.Forms.Panel pColour1;
        private System.Windows.Forms.Panel pColour2;
        private System.Windows.Forms.Panel pColour4;
        private System.Windows.Forms.Panel pColour5;
        private System.Windows.Forms.Panel pColour3;
        private System.Windows.Forms.Panel pColourMain;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Panel pColour9;
        private System.Windows.Forms.Panel pColour15;
        private System.Windows.Forms.Panel pColour11;
        private System.Windows.Forms.Panel pColour14;
        private System.Windows.Forms.Panel pColour16;
        private System.Windows.Forms.Panel pColour13;
        private System.Windows.Forms.Panel pColour12;
        private System.Windows.Forms.Panel pColour10;
        private System.Windows.Forms.Panel pColour7;
        private System.Windows.Forms.Panel pColour8;
        private System.Windows.Forms.Panel pColour26;
        private System.Windows.Forms.Panel pColour19;
        private System.Windows.Forms.Panel pColour23;
        private System.Windows.Forms.Panel pColour28;
        private System.Windows.Forms.Panel pColour27;
        private System.Windows.Forms.Panel pColour17;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel pColour25;
        private System.Windows.Forms.Panel pColour24;
        private System.Windows.Forms.Panel pColour21;
        private System.Windows.Forms.Panel pColour22;
        private System.Windows.Forms.Panel pColour20;
        private System.Windows.Forms.Panel pColour18;
        private System.Windows.Forms.Panel pColourSec;
        private System.Windows.Forms.Button bPencilTool;
        private System.Windows.Forms.Button bRubberTool;
        private System.Windows.Forms.Button bFillTool;
        private System.Windows.Forms.Button bTextTool;
        private System.Windows.Forms.TextBox tbToolTip;
        private System.Windows.Forms.Panel pBrushSizeSmall;
        private System.Windows.Forms.Panel pToolSelection;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pLargeCircleBrush;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

