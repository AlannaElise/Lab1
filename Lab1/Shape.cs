using System.Drawing; //Apply Graphics and Color classes for drawing

namespace Lab1
{
    //Abstract base class for all drawable shapes
    internal abstract class Shape
    {
        public int oldX, oldY, newX, newY; //Starting and ending point coordinates
        public Color color; //Shape colors

        //Constructor: initializes coordinates and color
        public Shape(int oldX, int oldY, int newX, int newY, Color c)
        {
            this.oldX = oldX; //Assign starting X coordinate
            this.oldY = oldY; //Assign starting Y coordinate
            this.newX = newX; //Assign ending X coordinate
            this.newY = newY; //Assign ending Y coordinate
            color = c; //Assign color
        }

        //Polymorphic method to draw the shape with color
        public abstract void drawColoredShape(Graphics g);
    }
}