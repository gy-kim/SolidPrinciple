using System;
using Xunit;
using Xunit.Abstractions;
using LSP;

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
    }
}
