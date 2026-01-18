using System.Diagnostics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const string L = "Line";
        private const string R = "Rectangle";
        private const string E = "Ellipse";
        string userChoice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int oldX, oldY;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = e.X; oldY = e.Y;

            if (userChoice == L)
            {
                Debug.WriteLine(L);
            }
            else if (userChoice == R)
            {
                Debug.WriteLine(R);
            }
            else
            {
                Debug.WriteLine(E);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();



            Pen pen = new Pen(Color.BlueViolet);
            g.DrawLine(pen, oldX, oldY, e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

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
