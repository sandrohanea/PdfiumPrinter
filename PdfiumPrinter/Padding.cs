namespace PdfiumPrinter
{
    public struct Padding
    {
        public Padding(int value)
        {
            this.Left = value;
            this.Top = value;
            this.Right = value;
            this.Bottom = value;
        }

        public int Left { get; internal set; }
        public int Top { get; internal set; }
        public int Right { get; internal set; }
        public int Bottom { get; internal set; }
    }
}
