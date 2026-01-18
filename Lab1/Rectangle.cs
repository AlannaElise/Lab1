using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Rectangle : Shape
    {
        public Rectangle(int x1, int x2, int y1, int y2, Color c) : base(x1, x2, y1, y2, c)
        {
        }

        public override void drawColorShape(Graphics g)
        {
            Pen pen = new Pen(color);
            int x = Math.Min(oldX, newX);
            int y = Math.Min(oldY, newY);
            int width = Math.Abs(newX - oldX);
            int height = Math.Abs(newY - oldY);
            g.DrawRectangle(pen, x, y, width, height);

        }
    }
}
