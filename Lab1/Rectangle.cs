using System.Drawing; //Apply Graphics and Color classes

namespace Lab1
{
    //Rectangle shape class
    internal class Rectangle : Shape
    {
        //Constructor: initializes rectangle endpoints and color
        public Rectangle(int x1, int y1, int x2, int y2, Color c)
            : base(x1, y1, x2, y2, c)
        {
        }

        //Draw a colored rectangle
        public override void drawColoredShape(Graphics g)
        {
            int x = Math.Min(oldX, newX); //Left X coordinate
            int y = Math.Min(oldY, newY); //Top Y coordinate
            int width = Math.Abs(newX - oldX); //Rectangle width
            int height = Math.Abs(newY - oldY); //Rectangle height

            using Pen pen = new Pen(color); //Create a pen with the shape color
            g.DrawRectangle(pen, x, y, width, height); //Draw the rectangle
        }
    }
}
