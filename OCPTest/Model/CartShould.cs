using System;
using Xunit;
using Xunit.Abstractions;

namespace OCPTest.Model
{
    public class CartShould
    {
        private readonly ITestOutputHelper _output;
        private readonly OCP.Model.Cart _sut;

        public CartShould(ITestOutputHelper output)
        {
            this._output = output;
            this._sut = new OCP.Model.Cart();
        }

        [Fact]
        public void ZeroWhenEmpty()
        {
            Assert.Equal(0, _sut.TotalAmount());
        }
    }
}
