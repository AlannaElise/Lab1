using System.Drawing; //Apply Graphics, Pen, and Color classes

namespace Lab1
{
    //Line shape class
    internal class Line : Shape
    {
        //Constructor: initializes line endpoints and color
        public Line(int x1, int y1, int x2, int y2, Color c)
            : base(x1, y1, x2, y2, c)
        {
        }

        //Draw a colored line 
        public override void drawColoredShape(Graphics g)
        {
            using Pen pen = new Pen(color); //Create a pen with the shape color
            g.DrawLine(pen, oldX, oldY, newX, newY); //Draw the line from start to end
        }
    }
}