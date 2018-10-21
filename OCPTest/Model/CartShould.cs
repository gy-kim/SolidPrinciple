using System;
using Xunit;
using Xunit.Abstractions;
using OCP.Model;

namespace OCPTest.Model
{
    [Trait("Category", "OCP_Cart")]
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

        [Fact]
        public void TwoWithHalfKiloWeightItem()
        {
            this._sut.Add(new OrderItem { Quantity = 500, Sku = "WEIGHT_PEANUTS" });
            Assert.Equal(2m, _sut.TotalAmount());
        }

        [Fact]
        public void EightyCentsWithTwoSpecialItem()
        {
            this._sut.Add(new OrderItem { Quantity = 2, Sku = "SPECIAL_CANDYBAR" });
            Assert.Equal(0.80m, _sut.TotalAmount());
        }

        [Fact]
        public void TwoDollarsWithSixSpecialItem()
        {
            this._sut.Add(new OrderItem { Quantity = 6, Sku = "SPECIAL_CANDYBAR" });
            Assert.Equal(2m, _sut.TotalAmount());
        }
    }
}
