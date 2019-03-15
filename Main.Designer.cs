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
            this.pCanvas = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pCanvas
            // 
            this.pCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCanvas.Location = new System.Drawing.Point(61, 70);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(553, 335);
            this.pCanvas.TabIndex = 0;
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
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
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
            this.pColour6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour6.Location = new System.Drawing.Point(599, 27);
            this.pColour6.Name = "pColour6";
            this.pColour6.Size = new System.Drawing.Size(15, 15);
            this.pColour6.TabIndex = 2;
            // 
            // pColour5
            // 
            this.pColour5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour5.Location = new System.Drawing.Point(599, 45);
            this.pColour5.Name = "pColour5";
            this.pColour5.Size = new System.Drawing.Size(15, 15);
            this.pColour5.TabIndex = 3;
            // 
            // pColour4
            // 
            this.pColour4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour4.Location = new System.Drawing.Point(578, 27);
            this.pColour4.Name = "pColour4";
            this.pColour4.Size = new System.Drawing.Size(15, 15);
            this.pColour4.TabIndex = 0;
            // 
            // pColour3
            // 
            this.pColour3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour3.Location = new System.Drawing.Point(578, 45);
            this.pColour3.Name = "pColour3";
            this.pColour3.Size = new System.Drawing.Size(15, 15);
            this.pColour3.TabIndex = 4;
            // 
            // pColour2
            // 
            this.pColour2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour2.Location = new System.Drawing.Point(557, 27);
            this.pColour2.Name = "pColour2";
            this.pColour2.Size = new System.Drawing.Size(15, 15);
            this.pColour2.TabIndex = 1;
            this.pColour2.Paint += new System.Windows.Forms.PaintEventHandler(this.pColour2_Paint);
            this.pColour2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColour2_MouseDown);
            // 
            // pColour1
            // 
            this.pColour1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColour1.Location = new System.Drawing.Point(557, 45);
            this.pColour1.Name = "pColour1";
            this.pColour1.Size = new System.Drawing.Size(15, 15);
            this.pColour1.TabIndex = 2;
            // 
            // pColourMain
            // 
            this.pColourMain.BackColor = System.Drawing.Color.Black;
            this.pColourMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pColourMain.Location = new System.Drawing.Point(513, 27);
            this.pColourMain.Name = "pColourMain";
            this.pColourMain.Size = new System.Drawing.Size(25, 25);
            this.pColourMain.TabIndex = 6;
            this.pColourMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pColourMain_MouseDown);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPageToolStripMenuItem,
            this.clearPageToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // newPageToolStripMenuItem
            // 
            this.newPageToolStripMenuItem.Name = "newPageToolStripMenuItem";
            this.newPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newPageToolStripMenuItem.Text = "New Page";
            // 
            // clearPageToolStripMenuItem
            // 
            this.clearPageToolStripMenuItem.Name = "clearPageToolStripMenuItem";
            this.clearPageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearPageToolStripMenuItem.Text = "Clear Page";
            this.clearPageToolStripMenuItem.Click += new System.EventHandler(this.clearPageToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 417);
            this.Controls.Add(this.pColourMain);
            this.Controls.Add(this.pColour1);
            this.Controls.Add(this.pColour3);
            this.Controls.Add(this.pColour2);
            this.Controls.Add(this.pColour5);
            this.Controls.Add(this.pColour4);
            this.Controls.Add(this.pColour6);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MBPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

