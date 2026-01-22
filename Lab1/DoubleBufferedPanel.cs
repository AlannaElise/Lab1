using System.Windows.Forms; //Provide Panel and PaintEventArgs classes

namespace Lab1
{
    //Custom panel with double buffering to reduce flickering
    internal class DoubleBufferedPanel : Panel
    {
        //Constructor: enables double buffering
        public DoubleBufferedPanel()
        {
            this.DoubleBuffered = true; //Enable double buffering
            this.ResizeRedraw = true; //Redraw panel when it is resized
        }

        //Override background painting to prevent flickering
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //Do nothing to avoid clearing the background
        }
    }
}
