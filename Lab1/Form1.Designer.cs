namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Line = new Button();
            Rectangle = new Button();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            panel1 = new Panel();
            Ellipse = new Button();
            trackBar3 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            SuspendLayout();
            // 
            // Line
            // 
            Line.Location = new Point(28, 18);
            Line.Name = "Line";
            Line.Size = new Size(111, 31);
            Line.TabIndex = 0;
            Line.Text = "Line";
            Line.UseVisualStyleBackColor = true;
            Line.Click += Line_Click;
            // 
            // Rectangle
            // 
            Rectangle.Location = new Point(145, 17);
            Rectangle.Name = "Rectangle";
            Rectangle.Size = new Size(99, 35);
            Rectangle.TabIndex = 1;
            Rectangle.Text = "Rectangle";
            Rectangle.UseVisualStyleBackColor = true;
            Rectangle.Click += Rectangle_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(383, 16);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(105, 45);
            trackBar1.TabIndex = 2;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(509, 16);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(107, 45);
            trackBar2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(28, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 354);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Ellipse
            // 
            Ellipse.Location = new Point(250, 17);
            Ellipse.Name = "Ellipse";
            Ellipse.Size = new Size(95, 33);
            Ellipse.TabIndex = 5;
            Ellipse.Text = "Ellipse";
            Ellipse.UseVisualStyleBackColor = true;
            Ellipse.Click += Ellipse_Click;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(641, 18);
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(104, 45);
            trackBar3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar3);
            Controls.Add(Ellipse);
            Controls.Add(panel1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(Rectangle);
            Controls.Add(Line);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Line;
        private Button Rectangle;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Panel panel1;
        private Button Ellipse;
        private TrackBar trackBar3;
    }
}
