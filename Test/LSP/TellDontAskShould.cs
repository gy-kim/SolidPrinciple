using System;
using Xunit;
using Xunit.Abstractions;
using LSP;
using System.Collections.Generic;

namespace Test.LSP
{
    public class TellDontAskShould
    {
        private readonly ITestOutputHelper _output;

        public TellDontAskShould(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void SixFor2X3Rectangle()
        {
            var sut = new TellDontAsk.Rectangle { Height = 2, Width = 3 };
            Assert.Equal(6, sut.Area());
        }

        [Fact]
        public void NineFor3X3Square()
        {
            var sut = new TellDontAsk.Square { SideLength = 3 };
            Assert.Equal(9, sut.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromRectangle()
        {
            var sut = new TellDontAsk.Rectangle { Height = 4, Width = 5 };
            Assert.Equal(20, sut.Area());
        }

        [Fact]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<TellDontAsk.Shape>
            {
                new TellDontAsk.Rectangle { Height = 4, Width = 5 },
                new TellDontAsk.Square { SideLength = 3 }
            };

            var sut = new List<int>();
            foreach (var shape in shapes)
            {
                sut.Add(shape.Area());
            }

            Assert.Equal(20, sut[0]);
            Assert.Equal(9, sut[1]);
        }
    }
}
