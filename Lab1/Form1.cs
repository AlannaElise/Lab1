using System; //Basic system functions
using System.Drawing; //Apply Graphics, Bitmap, Color classes
using System.Windows.Forms; //Windows Forms controls

namespace Lab1
{
    public partial class Form1 : Form
    {
        //Shapes
        private const string L = "Line";
        private const string R = "Rectangle";
        private const string E = "Ellipse";

        //Current selected shape
        private string userChoice = L;

        private int oldX, oldY; //Mouse starting coordinates
        private bool drawing = false; //Indicate whether the mouse is currently drawing

        private Bitmap map; //Bitmap used as the permanent drawing canvas

        //Temporary shape used for live preview while dragging
        private Shape? previewShape = null;

        //Form constructor
        public Form1()
        {
            InitializeComponent(); //Initialize UI components
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Replace the default panel with a double-buffered panel
            var dbPanel = new DoubleBufferedPanel();
            dbPanel.Name = panel1.Name;
            dbPanel.Dock = panel1.Dock;
            dbPanel.Location = panel1.Location;
            dbPanel.Size = panel1.Size;
            dbPanel.Anchor = panel1.Anchor;

            //Reattach panel events
            dbPanel.Paint += panel1_Paint;
            dbPanel.MouseDown += panel1_MouseDown;
            dbPanel.MouseMove += panel1_MouseMove;
            dbPanel.MouseUp += panel1_MouseUp;
            dbPanel.Resize += panel1_Resize;

            //Replace old panel with the new one
            this.Controls.Remove(panel1);
            panel1.Dispose();
            panel1 = dbPanel;
            this.Controls.Add(panel1);
            panel1.BringToFront();

            //Set initial window size
            this.ClientSize = new Size(520, 360);

            //Configure RGB track bars (0–255)
            trackBar1.Minimum = 0; trackBar1.Maximum = 255; trackBar1.Value = 0; //Red
            trackBar2.Minimum = 0; trackBar2.Maximum = 255; trackBar2.Value = 0; //Green
            trackBar3.Minimum = 0; trackBar3.Maximum = 255; trackBar3.Value = 0; //Blue

            //Create the initial drawing bitmap
            map = new Bitmap(Math.Max(1, panel1.Width), Math.Max(1, panel1.Height));
            using (Graphics g = Graphics.FromImage(map))
            {
                g.Clear(Color.White); //Set the background color is white
            }

            //Handle resize events
            panel1.Resize += panel1_Resize;

            //Force initial repaint
            panel1.Invalidate();
        }

        //Handle resizing of the drawing panel
        private void panel1_Resize(object? sender, EventArgs e)
        {
            if (panel1.Width <= 0 || panel1.Height <= 0) return;

            //Initialize bitmap if it does not exist
            if (map == null)
            {
                map = new Bitmap(panel1.Width, panel1.Height);
                using (Graphics g = Graphics.FromImage(map))
                {
                    g.Clear(Color.White);
                }
                panel1.Invalidate();
                return;
            }

            //Do not shrink the bitmap
            if (panel1.Width <= map.Width && panel1.Height <= map.Height)
            {
                
                panel1.Invalidate();
                return;
            }

            //Expand bitmap when panel becomes larger
            int newW = Math.Max(panel1.Width, map.Width);
            int newH = Math.Max(panel1.Height, map.Height);

            Bitmap newMap = new Bitmap(newW, newH);
            using (Graphics g = Graphics.FromImage(newMap))
            {
                g.Clear(Color.White);
                g.DrawImageUnscaled(map, 0, 0);
            }

            map.Dispose(); //Dispose old bitmap
            map = newMap;

            previewShape = null; //Clear preview
            panel1.Invalidate();
        }

        //Return the current selected RGB color
        private Color CurrentColor()
        {
            return Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        //Create a shape based on the selected type
        private Shape CreateShape(int x1, int y1, int x2, int y2, Color c)
        {
            
            
            if (userChoice == L) return new Lab1.Line(x1, y1, x2, y2, c);
            if (userChoice == R) return new Lab1.Rectangle(x1, y1, x2, y2, c);
            return new Lab1.Ellipse(x1, y1, x2, y2, c);
        }

        //Paint event: draws permanent bitmap and preview shape
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(map, 0, 0);
            previewShape?.drawColoredShape(e.Graphics);
        }

        //Mouse button pressed: start drawing
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            oldX = e.X;
            oldY = e.Y;
            drawing = true;

            
            previewShape = CreateShape(oldX, oldY, e.X, e.Y, CurrentColor());
            panel1.Invalidate();
        }

        //Mouse moved: update preview shape
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            
            previewShape = CreateShape(oldX, oldY, e.X, e.Y, CurrentColor());
            panel1.Invalidate();
        }

        //Mouse released: finalize shape
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!drawing) return;
            drawing = false;

            using (Graphics gMap = Graphics.FromImage(map))
            {
                Shape shape = CreateShape(oldX, oldY, e.X, e.Y, CurrentColor());
                shape.drawColoredShape(gMap);
            }

            
            previewShape = null;
            panel1.Invalidate();
        }

        //Select line drawing mode
        private void Line_Click(object sender, EventArgs e)
        {
            userChoice = L;
        }

        //Select rectangle drawing mode
        private void Rectangle_Click(object sender, EventArgs e)
        {
            userChoice = R;
        }

        //Select ellipse drawing mode
        private void Ellipse_Click(object sender, EventArgs e)
        {
            userChoice = E;
        }
    }
}