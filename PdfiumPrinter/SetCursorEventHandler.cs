using System;
using System.Drawing;

#pragma warning disable 1591

namespace PdfiumPrinter
{
    public class SetCursorEventArgs : EventArgs
    {
        public Point Location { get; private set; }

        public HitTest HitTest { get; private set; }
        
        public SetCursorEventArgs(Point location, HitTest hitTest)
        {
            Location = location;
            HitTest = hitTest;
        }
    }

    public delegate void SetCursorEventHandler(object sender, SetCursorEventArgs e);
}
