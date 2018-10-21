using System;
using Xunit;
using Xunit.Abstractions;
using OCP.Model;

namespace OCPTest.Model
{
    public class CartShould
    {
        private readonly ITestOutputHelper _output;
        private readonly Cart _sut;

        public CartShould(ITestOutputHelper output)
        {
            this._output = output;
            this._sut = new Cart();
        }

        [Fact]
        public void ZeroWhenEmpty()
        {
            Assert.Equal(0, _sut.TotalAmount());
        }

        [Fact]
        public void FiveWithOneEachItem()
        {
            _sut.Add(new OrderItem() { Quantity = 1, Sku = "EACH_WIDGET" });
            Assert.Equal(5.0m, _sut.TotalAmount());
        }
    }
}
