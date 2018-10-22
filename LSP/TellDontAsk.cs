using System;
namespace LSP
{
    public class TellDontAsk 
    {
        public abstract class Shape
        {
            public abstract int Area();
        }

        public class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override int Area()
            {
                return Height * Width;
            }
        }

        public class Square : Shape
        {
            public int SideLength;

            public override int Area()
            {
                return SideLength * SideLength;
            }
        }
    }
}
