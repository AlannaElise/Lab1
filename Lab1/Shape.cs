using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lab1
{
    internal abstract class Shape
    {
        public int oldX, oldY, newX, newY;
        public Color color;

        public Shape(int oldX, int oldY, int newX, int newY, Color c)
        {
            this.oldX = oldX;
            this.oldY = oldY;
            this.newX = newX;
            this.newY = newY;
            color = c;
        }

        public abstract void drawColorShape(Graphics g);
    }
}
