using System.Diagnostics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const string L = "Line";
        private const string R = "Rectangle";
        private const string E = "Ellipse";
        string userChoice;
        int oldX, oldY;
        Bitmap map;
        Graphics m;
        bool drawing = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            map = new Bitmap(panel1.Width, panel1.Height);
            m = Graphics.FromImage(map);
            panel1.BackgroundImage = map;
            panel1.BackgroundImageLayout = ImageLayout.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X; oldY = e.Y;
            drawing = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics gMap = Graphics.FromImage(map);
            drawing = false;
            Shape shape;

            if (userChoice == L)
                shape = new Line(oldX, oldY, e.X, e.Y, Color.BlueViolet);
            else if (userChoice == R)
                shape = new Rectangle(oldX, oldY, e.X, e.Y, Color.BlueViolet);
            else
                shape = new Ellipse(oldX, oldY, e.X, e.Y, Color.BlueViolet);

            shape.drawColorShape(gMap);
            panel1.BackgroundImage = map;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap temp = (Bitmap)map.Clone();
            if (drawing == true)
            {
                Graphics gTemp = Graphics.FromImage(temp);
                Pen pen = new Pen(Color.BlueViolet); // same color as before

                if (userChoice == L)
                {
                    gTemp.DrawLine(pen, oldX, oldY, e.X, e.Y);
                }
                else if (userChoice == R)
                {
                    int x = Math.Min(oldX, e.X);
                    int y = Math.Min(oldY, e.Y);
                    int width = Math.Abs(e.X - oldX);
                    int height = Math.Abs(e.Y - oldY);
                    gTemp.DrawRectangle(pen, x, y, width, height);
                }
                else
                {
                    int x = Math.Min(oldX, e.X);
                    int y = Math.Min(oldY, e.Y);
                    int width = Math.Abs(e.X - oldX);
                    int height = Math.Abs(e.Y - oldY);
                    gTemp.DrawEllipse(pen, x, y, width, height);
                }

                panel1.BackgroundImage = temp;

            }
        }

        private void Line_Click(object sender, EventArgs e)
        {
            userChoice = L;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            userChoice = R;
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            userChoice = E;
        }
    }
}
