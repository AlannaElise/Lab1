using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    internal class Line : Shape
    {
        public Line(int x1, int x2, int y1, int y2, Color c) : base(x1, x2, y1, y2, c)
        {
        }

        public override void drawColoredShape(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen, oldX, oldY, newX, newY);

        }
    }
}
