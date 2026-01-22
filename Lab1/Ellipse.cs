using System.Drawing; //Apply Graphics, Pen, and Color classes

namespace Lab1
{
    //Ellipse shape class
    internal class Ellipse : Shape
    {
        //Constructor: initializes ellipse endpoints and color
        public Ellipse(int x1, int y1, int x2, int y2, Color c)
            : base(x1, y1, x2, y2, c)
        {
        }

        //Draw a colored ellipse
        public override void drawColoredShape(Graphics g)
        {
            int x = Math.Min(oldX, newX); //Left X coordinate
            int y = Math.Min(oldY, newY); //Top Y coordinate
            int width = Math.Abs(newX - oldX); //Ellipse width
            int height = Math.Abs(newY - oldY); //Ellipse height

            using Pen pen = new Pen(color); //Create a pen with the shape color
            g.DrawEllipse(pen, x, y, width, height); //Draw the ellipse
        }
    }
}

