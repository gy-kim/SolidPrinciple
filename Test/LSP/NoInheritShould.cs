using System;
using Xunit;
using Xunit.Abstractions;
using LSP;
using System.Collections.Generic;

namespace Test.LSP
{
    public class NoInheritShould
    {
        private readonly ITestOutputHelper _output;

        public NoInheritShould(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void SixFor2X3Rectangle()
        {
            var sut = new Rectangle { Height = 2, Width = 3 };
            Assert.Equal(6, sut.Area());
        }

        [Fact]
        public void NineFor3X3Square()
        {
            var sut = new Square { SideLength = 3 };
            Assert.Equal(9, sut.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
            {
                new Rectangle { Height = 4, Width = 5 },
                new Square { SideLength = 3 }
            };

            var sut = new List<int>();

            foreach(var shape in shapes)
            {
                if (shape.GetType() == typeof(Rectangle))
                {
                    sut.Add(((Rectangle)shape).Area());
                }
                if (shape.GetType() == typeof(Square))
                {
                    sut.Add(((Square)shape).Area());
                }
            }

            Assert.Equal(20, sut[0]);
            Assert.Equal(9, sut[1]);
        }
    }
}
