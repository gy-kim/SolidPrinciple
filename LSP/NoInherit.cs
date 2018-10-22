using System;

namespace LSP
{
    public abstract class Shape { }

    public class Square : Shape
    {
        public int SideLength;

        public int Area()
        {
            return SideLength * SideLength;
        }
    }

    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }
}
